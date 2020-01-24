using System;
using System.Linq;

using NUnit.Framework;

using Java.Interop.Tools.JavaSource;

using Irony;
using Irony.Ast;
using Irony.Parsing;

using Xamarin.Android.Tools.ApiXmlAdjuster;

namespace Java.Interop.Tools.JavaSource.Tests
{
	[TestFixture]
	public class JavaSE13GrammarPackagesBnfTermsTests {

		[Test]
		public void PackageDeclaration ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = g.PackagesTerms.PackageDeclaration;
			g.LanguageFlags = LanguageFlags.Default | LanguageFlags.CreateAst;
			var p = new Parser (g);
			// p.Language.AstDataVerified = true;

			var t = p.Parse ("package foo.bar.baz;");
			var parsedPackage = (JavaPackage) t.Root.AstNode;
			Assert.IsNotNull (parsedPackage);
			Assert.AreEqual ("foo.bar.baz", parsedPackage.Name);

			AssertParseSequence (p, ParseTreeStatus.Parsed,
					"package foo.bar;",
					types:  new[]{"package", "Identifier",  ".", "Identifier",  ";", g.Eof.Name},
					tokens: new[]{"package", "foo",         ".", "bar",         ";", ""}
			);

			AssertParseSequence (p, ParseTreeStatus.Error,
					"package;",
					types:  new[]{"package", ";"},
					tokens: new[]{"package", ";"}
			);
		}

		static void AssertParseSequence (Parser p, ParseTreeStatus status, string input, string[] types, string[] tokens)
		{
			if (types.Length != tokens.Length)
				throw new ArgumentException ("types.Length != tokens.Length!");
			var t = p.Parse (input);
			Assert.AreEqual (status, t.Status, $"Parse(`{input}`).Status=={status}");
			var _tokens = "{" + string.Join (", ", t.Tokens.Select (v => $"\"{v.Text}\"/{v.Terminal.Name}")) + "}";
			Assert.AreEqual (tokens.Length, t.Tokens.Count, $"Parse(`{input}`).Tokens.Count != {tokens.Length}: {_tokens}");
			for (int i = 0; i < tokens.Length; ++i) {
				var tok = t.Tokens [i];
				Assert.AreEqual (types [i], tok.Terminal.Name);
				Assert.AreEqual (tokens [i], tok.Text);
			}
		}
	}
}
