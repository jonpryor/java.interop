OS           ?= $(shell uname)

CONFIGURATION = Debug

XA_CONFIGURATION  = XAIntegrationDebug

GENDARME_URL = https://cloud.github.com/downloads/spouliot/gendarme/gendarme-2.10-bin.zip

PACKAGES = \
	packages/NUnit.2.6.3/NUnit.2.6.3.nupkg \
	packages/NUnit.Runners.2.6.3/NUnit.Runners.2.6.3.nupkg

DEPENDENCIES = \
	bin/Test$(CONFIGURATION)/libNativeTiming.dylib

XA_INTEGRATION_OUTPUTS = \
	bin/$(XA_CONFIGURATION)/Java.Interop.dll

TESTS = \
	bin/Test$(CONFIGURATION)/Java.Interop-Tests.dll \
	bin/Test$(CONFIGURATION)/Java.Interop.Dynamic-Tests.dll \
	bin/Test$(CONFIGURATION)/Java.Interop.Export-Tests.dll \
	bin/Test$(CONFIGURATION)/LogcatParse-Tests.dll \
	bin/Test$(CONFIGURATION)/generator-Tests.dll \
	bin/Test$(CONFIGURATION)/Xamarin.Android.Tools.ApiXmlAdjuster-Tests.dll \
	bin/Test$(CONFIGURATION)/Xamarin.Android.Tools.Bytecode-Tests.dll

PTESTS = \
	bin/Test$(CONFIGURATION)/Java.Interop-PerformanceTests.dll

ATESTS = \
	bin/Test$(CONFIGURATION)/Android.Interop-Tests.dll

XBUILD = xbuild $(if $(V),/v:diag,)
NUNIT_CONSOLE = packages/NUnit.Runners.2.6.3/tools/nunit-console.exe

all: bin/Build$(CONFIGURATION)/JdkHeaders.props $(PACKAGES) $(DEPENDENCIES) $(TESTS) $(XA_INTEGRATION_OUTPUTS)

xa-all: $(XA_INTEGRATION_OUTPUTS)

clean:
	$(XBUILD) /t:Clean
	rm -Rf bin/$(CONFIGURATION)

include build-tools/scripts/jdk.mk

$(PACKAGES) $(NUNIT_CONSOLE):
	nuget restore


osx-setup: bin/$(CONFIGURATION)/JdkHeaders

xa-fxcop: lib/gendarme-2.10/gendarme.exe bin/$(XA_CONFIGURATION)/Java.Interop.dll
	mono --debug $< --html xa-gendarme.html $(if @(GENDARME_XML),--xml xa-gendarme.xml) --ignore xa-gendarme-ignore.txt bin/$(XA_CONFIGURATION)/Java.Interop.dll

lib/gendarme-2.10/gendarme.exe:
	-mkdir -p `dirname "$@"`
	curl -o lib/gendarme-2.10/gendarme-2.10-bin.zip $(GENDARME_URL)
	(cd lib/gendarme-2.10 ; unzip gendarme-2.10-bin.zip)

bin/Test$(CONFIGURATION)/libNativeTiming.dylib: tests/NativeTiming/timing.c $(wildcard $(JI_JDK_INCLUDE_PATHS)/jni.h)
	mkdir -p `dirname "$@"`
	gcc -g -shared -o $@ $< -m32 $(JI_JDK_INCLUDE_PATHS:%=-I%)

bin/Test$(CONFIGURATION)/Java.Interop-Tests.dll: $(wildcard src/Java.Interop/*/*.cs src/Java.Interop/Tests/*/*.cs)
	$(XBUILD)
	touch $@

bin/Test$(CONFIGURATION)/Java.Interop.Dynamic-Tests.dll: $(wildcard src/Java.Interop.Dynamic/*/*.cs src/Java.Interop.Dynamic/Tests/*/*.cs)
	$(XBUILD)
	touch $@

bin/Test$(CONFIGURATION)/Java.Interop.Export-Tests.dll: $(wildcard src/Java.Interop.Export/*/*.cs src/Java.Interop.Export/Tests/*/*.cs)
	$(XBUILD)
	touch $@

bin/Test$(CONFIGURATION)/Java.Interop-PerformanceTests.dll: $(wildcard tests/Java.Interop-PerformanceTests/*.cs) bin/Test$(CONFIGURATION)/libNativeTiming.dylib
	$(XBUILD)
	touch $@

bin/Test$(CONFIGURATION)/Android.Interop-Tests.dll: $(wildcard src/Android.Interop/*/*.cs src/Android.Interop/Tests/*/*.cs)
	$(XBUILD)
	touch $@

bin/$(XA_CONFIGURATION)/Java.Interop.dll: $(wildcard src/Java.Interop/*/*.cs) src/Java.Interop/Java.Interop.csproj
	$(XBUILD) /p:Configuration=$(XA_CONFIGURATION) $(if $(SNK),"/p:AssemblyOriginatorKeyFile=$(SNK)",)

CSHARP_REFS = \
	bin/$(CONFIGURATION)/Java.Interop.dll               \
	bin/$(CONFIGURATION)/Java.Interop.Export.dll        \
	bin/$(CONFIGURATION)/Java.Runtime.Environment.dll   \
	bin/$(CONFIGURATION)/TestJVM.dll                    \
	$(PTESTS)                                           \
	$(TESTS)

shell:
	cd bin/$(CONFIGURATION) && \
	MONO_TRACE_LISTENER=Console.Out \
	MONO_OPTIONS=--debug=casts csharp $(patsubst %,-r:%,$(notdir $(CSHARP_REFS)))

# $(call RUN_TEST,filename,log-lref?)
define RUN_TEST
	MONO_TRACE_LISTENER=Console.Out \
	JAVA_INTEROP_GREF_LOG=g-$(basename $(notdir $(1))).txt $(if $(2),JAVA_INTEROP_LREF_LOG=l-$(basename $(notdir $(1))).txt,) \
	mono --debug=casts $$MONO_OPTIONS --runtime=v4.0.0 \
		$(NUNIT_CONSOLE) $(NUNIT_EXTRA) $(1) \
		$(if $(RUN),-run:$(RUN)) \
		-output=bin/Test$(CONFIGURATION)/TestOutput-$(basename $(notdir $(1))).txt ;
endef

run-tests: $(TESTS) bin/Test$(CONFIGURATION)/libjava-interop.dylib
	$(foreach t,$(TESTS), $(call RUN_TEST,$(t),1))

run-ptests: $(PTESTS) bin/Test$(CONFIGURATION)/libjava-interop.dylib
	$(foreach t,$(PTESTS), $(call RUN_TEST,$(t)))

bin/Test$(CONFIGURATION)/libjava-interop.dylib: bin/$(CONFIGURATION)/libjava-interop.dylib
	cp $< $@

run-android: $(ATESTS)
	(cd src/Android.Interop/Tests; $(XBUILD) '/t:Install;RunTests' $(if $(FIXTURE),/p:TestFixture=$(FIXTURE)))

run-test-jnimarshal: bin/$(CONFIGURATION)/Java.Interop.Export-Tests.dll
	MONO_TRACE_LISTENER=Console.Out \
	mono --debug bin/$(CONFIGURATION)/jnimarshalmethod-gen.exe bin/$(CONFIGURATION)/Java.Interop.Export-Tests.dll
	$(call RUN_TEST,$<)


GENERATOR_EXPECTED_TARGETS  = tools/generator/Tests/expected.targets

# $(call GEN_CORE_OUTPUT, outdir)
define GEN_CORE_OUTPUT
	-$(RM) -Rf $(1)
	mkdir -p $(1)
	mono --debug bin/Test$(CONFIGURATION)/generator.exe -o $(1) $(2) tools/generator/Tests-Core/api.xml \
		--enummethods=tools/generator/Tests-Core/methods.xml \
		--enumfields=tools/generator/Tests-Core/fields.xml \
		--enumdir=$(1)
endef

run-test-generator-core:
	$(call GEN_CORE_OUTPUT,bin/Test$(CONFIGURATION)/generator-core)
	diff -rup tools/generator/Tests-Core/expected bin/Test$(CONFIGURATION)/generator-core
	$(call GEN_CORE_OUTPUT,bin/Test$(CONFIGURATION)/generator-core,--codegen-target=JavaInterop1)
	diff -rup tools/generator/Tests-Core/expected.ji bin/Test$(CONFIGURATION)/generator-core

update-test-generator-core:
	$(call GEN_CORE_OUTPUT,tools/generator/Tests-Core/expected)
	$(call GEN_CORE_OUTPUT,tools/generator/Tests-Core/expected.ji,--codegen-target=JavaInterop1)

update-test-generator-nunit:
	-$(MAKE) run-tests TESTS=bin/Test$(CONFIGURATION)/generator-Tests.dll
	for f in `find tools/generator/Tests/expected -name \*.cs` ; do \
		source=`echo $$f | sed 's#^tools/generator/Tests/expected#bin/Test$(CONFIGURATION)/out#'` ; \
		if [ -f "$$source" ]; then \
			cp -f "$$source" "$$f" ; \
		fi; \
	done
	for source in `find bin/Test$(CONFIGURATION)/out.ji -type f` ; do \
		f=`echo $$source | sed 's#^bin/Test$(CONFIGURATION)/out.ji#tools/generator/Tests/expected.ji#'` ; \
		mkdir -p `dirname $$f`; \
		cp -f "$$source" "$$f" ; \
	done
	echo '<Project DefaultTargets="Build" ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">' > $(GENERATOR_EXPECTED_TARGETS)
	echo '  <ItemGroup>' >> $(GENERATOR_EXPECTED_TARGETS)
	for f in `find tools/generator/Tests/expected* -type f | sort -i` ; do \
		include=`echo $$f | sed 's#^tools/generator/Tests/##' | tr / \\\\` ; \
		echo "    <Content Include='$$include'>" >> $(GENERATOR_EXPECTED_TARGETS); \
		echo "      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>" >> $(GENERATOR_EXPECTED_TARGETS); \
		echo "    </Content>" >> $(GENERATOR_EXPECTED_TARGETS); \
	done
	echo '  </ItemGroup>' >> $(GENERATOR_EXPECTED_TARGETS)
	echo '</Project>' >> $(GENERATOR_EXPECTED_TARGETS)
