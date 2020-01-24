
using System;
using System.Linq;

using NUnit.Framework;

using Java.Interop.Tools.JavaSource;

using Irony;
using Irony.Parsing;

namespace Java.Interop.Tools.JavaSource.Tests
{
	[TestFixture]
	public class JavaSE13GrammarLexicalBnfTermsTests {
		[Test]
		public void Comments ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (Comments)) {
				Rule = g.LexicalTerms.EndOfLineComment
					| g.LexicalTerms.TraditionalComment
					| g.LexicalTerms.JavaDocComment,
			};
			g.NonGrammarTerminals.Clear ();
			var p = new Parser (g);

			AssertParse (p, "EndOfLineComment",     "// foo",       category: TokenCategory.Comment);
			AssertParse (p, "TraditionalComment",   "/* bar */",    category: TokenCategory.Comment);
			AssertParse (p, "JavaDocComment",       "/** baz */",   category: TokenCategory.Comment);

			AssertParse (p, "SYNTAX_ERROR",   "/* bar", ParseTreeStatus.Error);
		}

		public void Identifiers ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (Identifiers)) {
				Rule = g.LexicalTerms.Identifier,
			};
			var p = new Parser (g);

			AssertParse (p, "Identifier",   "foo");
			AssertParse (p, "SYNTAX_ERROR",   "42",   ParseTreeStatus.Error);
		}

		[Test]
		public void IntegerLiterals ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (IntegerLiterals)) {
				Rule = g.LexicalTerms.IntegerLiteral,
			};
			var p = new Parser (g);

			AssertParse (p, "DecimalIntegerLiteral", "0");
			AssertParse (p, "HexIntegerLiteral", "0x0");
			AssertParse (p, "HexIntegerLiteral", "0x0_0");
			AssertParse (p, "HexIntegerLiteral", "0xffff_ffff");
			AssertParse (p, "OctalIntegerLiteral", "0377_7777_7777");
			AssertParse (p, "BinaryIntegerLiteral", "0b1000_0000_0000_0000_0000_0000_0000_0000");

			// Reults in two parsed tokens: {'0x0', '_'}
			// AssertParse (p, "SYNTAX_ERROR", "0x0_",    ParseTreeStatus.Error);
		}

		[Test]
		public void FloatingPointLiterals ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (FloatingPointLiterals)) {
				Rule = g.LexicalTerms.FloatingPointLiteral,
			};
			var p = new Parser (g);

			AssertParse (p, "DecimalFloatingPointLiteral", "1e1f");
			AssertParse (p, "DecimalFloatingPointLiteral", "2.f");
			AssertParse (p, "DecimalFloatingPointLiteral", ".3f");
			AssertParse (p, "DecimalFloatingPointLiteral", "0f");
			AssertParse (p, "DecimalFloatingPointLiteral", "3.14f");
			AssertParse (p, "DecimalFloatingPointLiteral", "6.022137e+23f");

			AssertParse (p, "DecimalFloatingPointLiteral", "1e1");
			AssertParse (p, "DecimalFloatingPointLiteral", "2.");
			AssertParse (p, "DecimalFloatingPointLiteral", ".3");
			AssertParse (p, "DecimalFloatingPointLiteral", "0.0");
			AssertParse (p, "DecimalFloatingPointLiteral", "3.14");
			AssertParse (p, "DecimalFloatingPointLiteral", "1e137");
		}

		[Test]
		public void BooleanLiterals ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (BooleanLiterals)) {
				Rule = g.LexicalTerms.BooleanLiteral,
			};
			var p = new Parser (g);

			AssertParse (p, "true", "true");
			AssertParse (p, "false", "false");

			AssertParse (p, "SYNTAX_ERROR", "NaN", ParseTreeStatus.Error);
		}

		[Test]
		public void CharacterLiterals ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (CharacterLiterals)) {
				Rule = g.LexicalTerms.CharacterLiteral,
			};
			var p = new Parser (g);

			AssertParse (p, "CharacterLiteral", "'c'");
			AssertParse (p, "CharacterLiteral", @"'\n'");
			AssertParse (p, "CharacterLiteral", @"'\\'");
			AssertParse (p, "CharacterLiteral", @"'\''");
			AssertParse (p, "CharacterLiteral", @"' '");
			// AssertParse (p, "CharacterLiteral", @"'\u0020'");

			AssertParse (p, "SYNTAX_ERROR", "'\n'", ParseTreeStatus.Error);
			AssertParse (p, "SYNTAX_ERROR", "'too-long'", ParseTreeStatus.Error);
			AssertParse (p, "SYNTAX_ERROR", @"'\too-long'", ParseTreeStatus.Error);
		}

		[Test]
		public void StringLiterals ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (StringLiterals)) {
				Rule = g.LexicalTerms.StringLiteral,
			};
			var p = new Parser (g);

			AssertParse (p, "StringLiteral", "\"\"");
			AssertParse (p, "StringLiteral", "\"foo\"");
			// TODO: AssertParse (p, "StringLiteral", @"contains\nnew\rlines");
		}

		[Test]
		public void NullLiterals ()
		{
			var g = new JavaSE13Grammar ();
			g.Root = new NonTerminal (nameof (NullLiterals)) {
				Rule = g.LexicalTerms.NullLiteral,
			};
			var p = new Parser (g);

			AssertParse (p, "null", "null");

			AssertParse (p, "SYNTAX_ERROR", "is_not_null", ParseTreeStatus.Error);
		}

		static void AssertParse (Parser p, string type, string input, ParseTreeStatus status = ParseTreeStatus.Parsed, TokenCategory category = TokenCategory.Content)
		{
			var t = p.Parse (input);

			// Skip over "EOF" and other inserted tokens
			if (status == ParseTreeStatus.Error && category == TokenCategory.Content) {
				category = TokenCategory.Error;
			}
			var c = t.Tokens.Count (v => v.Category == category);
			var m = "{" + string.Join (", ", t.Tokens.Select (v => $"\"{v.Text}\"/{v.Category}")) + "}";
			Assert.AreEqual (1, c, $"{input} token count; expected 1, got {c}: {m}");
			Assert.AreEqual (status, t.Status,  $"{input} status");
			Assert.AreEqual (type, t.Tokens [0].Terminal.Name, $"{input} name");
		}
	}
}
