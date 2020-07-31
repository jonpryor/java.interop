/*
 * This Java source file was generated by the Gradle 'init' task.
 */
package com.microsoft.android;

import java.io.IOException;

import com.github.javaparser.*;
import com.github.javaparser.ParserConfiguration;

import com.microsoft.android.ast.*;
import com.microsoft.android.util.Parameter;

public class App {
	public static final String APP_NAME = "java-source-utils";

	public static void main (final String[] args) throws Throwable {
		JavaSourceUtilsOptions options;
		try {
			options = JavaSourceUtilsOptions.parse(args);
			if (options == null) {
				System.out.println(APP_NAME + " " + JavaSourceUtilsOptions.HELP_STRING);
				return;
			}
		} catch (Throwable t) {
			System.err.println(APP_NAME + ": error: " + t.getMessage());
			if (JavaSourceUtilsOptions.verboseOutput) {
				t.printStackTrace(System.err);
			}
			System.err.println("Usage: " + APP_NAME + " " + JavaSourceUtilsOptions.HELP_STRING);
			System.exit(1);
			return;
		}

		try {
			final   JavaParser                parser          = createParser(options);
			final   JniPackagesInfoFactory    packagesFactory = new JniPackagesInfoFactory(parser);
			final   JniPackagesInfo           packages        = packagesFactory.parse(options.inputFiles);

			if ((options.outputParamsTxt = Parameter.normalize(options.outputParamsTxt, "")).length() > 0) {
				generateParamsTxt(options.outputParamsTxt, packages);
			}
			generateXml(options, packages);
			options.close();
		}
		catch (Throwable t) {
			options.close();
			System.err.println(APP_NAME + ": internal error: " + t.getMessage());
			if (JavaSourceUtilsOptions.verboseOutput) {
				t.printStackTrace(System.err);
			}
			System.exit(2);
			return;
		}
	}

	static JavaParser createParser(JavaSourceUtilsOptions options) throws IOException {
		final   ParserConfiguration config = options.createConfiguration();
		final   JavaParser          parser = new JavaParser(config);
		return parser;
	}

	static void generateParamsTxt(String filename, JniPackagesInfo packages) throws Throwable {
		try (final   ParameterNameGenerator    paramsTxtGen    = new ParameterNameGenerator(filename)) {
			paramsTxtGen.writePackages(packages);
		}
	}

	static void generateXml(JavaSourceUtilsOptions options, JniPackagesInfo packages) throws Throwable {
		try (final   JavadocXmlGenerator       javadocXmlGen   = new JavadocXmlGenerator(options.outputJavadocXml)) {
			javadocXmlGen.writeCopyrightInfo(options.docCopyrightFile, options.docUrlPrefix, options.docUrlStyle);
			javadocXmlGen.writePackages(packages);
		}
	}
}
