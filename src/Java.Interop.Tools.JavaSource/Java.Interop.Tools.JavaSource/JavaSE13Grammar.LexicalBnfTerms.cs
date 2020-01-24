using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Irony.Ast;
using Irony.Parsing;

using Xamarin.Android.Tools.ApiXmlAdjuster;

namespace Java.Interop.Tools.JavaSource {

	using static IronyHelpers;

	// https://docs.oracle.com/javase/specs/jls/se13/html/jls-19.html
	// https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html
	partial class JavaSE13Grammar {
		public class LexicalBnfTerms {
			internal void CreateRules (JavaSE13Grammar grammar)
			{
				TypeIdentifier.Rule = Identifier;
				BooleanLiteral.Rule = grammar.ToTerm ("true")
					| grammar.ToTerm ("false");
				IntegerLiteral.Rule = DecimalIntegerLiteral
					| HexIntegerLiteral
					| OctalIntegerLiteral
					| BinaryIntegerLiteral;
				FloatingPointLiteral.Rule = DecimalFloatingPointLiteral
					| HexadecimalFloatingPointLiteral;
				Literal.Rule = IntegerLiteral
					| FloatingPointLiteral
					| BooleanLiteral
					| CharacterLiteral
					| StringLiteral
					| NullLiteral;

				Identifier.AstConfig.NodeCreator = (context, parseNode) => {
					parseNode.AstNode = parseNode.Token.Value;
				};
				DotIdentifier.Rule = "." + Identifier;
				DotIdentifiers.MakeStarRule (grammar, DotIdentifier);
			}

			internal void OnGrammarDataConstructed (LanguageData language)
			{
				NullLiteral.Init (language.GrammarData);
			}

			// §3.7 Comments: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.7
			public  readonly    Terminal    EndOfLineComment            = new CommentTerminal ("EndOfLineComment", "//", "\r", "\n", "\u2085", "\u2028", "\u2029");
			public  readonly    Terminal    TraditionalComment          = new CommentTerminal ("TraditionalComment", "/*", "*/");
			public  readonly    Terminal    JavaDocComment              = new CommentTerminal ("JavaDocComment", "/**", "*/");

			// § 3.8 Identifiers: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.8
			// https://docs.oracle.com/en/java/javase/13/docs/api/java.base/java/lang/Character.html#isJavaIdentifierStart(char)
			const string JavaIdentifierStart = "[" +
				@"\p{L}" +      // Letters
				@"\p{Nl}" +     // LETTER_NUMBER
				@"\p{Sc}" +     // Currency symbols
				@"\p{Pc}" +     // Connecting punctuation
				"]";

			// https://docs.oracle.com/en/java/javase/13/docs/api/java.base/java/lang/Character.html#isJavaIdentifierPart(char)
			const string JavaIdentifierPart  = "[" +
				@"\p{L}" +      // Letters
				@"\p{Sc}" +     // Currency symbols
				@"\p{Pc}" +     // Connecting punctuation
				@"\d" +         // Digit
				// @"" +        // numeric letter?
				@"\p{Mc}" +     // Combining mark
				@"\p{Mn}" +     // Non-spacing Mark
				// @"" +        // isIdentifierIgnorable?
				"]";

			public  readonly    Terminal    Identifier                  = new RegexBasedTerminal (nameof (Identifier), JavaIdentifierStart + JavaIdentifierPart + "*");
			public  readonly    NonTerminal TypeIdentifier              = new NonTerminal (nameof (TypeIdentifier));

			public  readonly    NonTerminal DotIdentifier               = new NonTerminal (".Identifier", WithCreator (v => "." + string.Join ("", v)));
			public  readonly    NonTerminal DotIdentifiers              = new NonTerminal ("(.Identifier)*", FlattenChildNodes);

			// §3.10 Literals: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.10
			public  readonly    NonTerminal Literal                     = new NonTerminal (nameof (Literal));

			// §3.10.1 Integer Literals: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.10.1
			const string Digits                     = "(0|[1-9])([_0-9]*[0-9])?";

			public  readonly    NonTerminal IntegerLiteral              = new NonTerminal (nameof (IntegerLiteral));
			public  readonly    Terminal    DecimalIntegerLiteral       = new RegexBasedTerminal (nameof (DecimalIntegerLiteral), $"({Digits})([lL])?");
			const string HexDigit                   = "[0-9A-Fa-f]";
			const string HexDigitOrUnderscore       = "[0-9A-Fa-f_]";
			const string HexDigitsAndUnderscores    = HexDigitOrUnderscore + "+";
			const string HexDigits                  = HexDigit + "(" + HexDigitOrUnderscore + "*" + HexDigit + ")?";
			const string HexNumeral                 = "0[Xx]" + HexDigits;
			public  readonly    Terminal    HexIntegerLiteral           = new RegexBasedTerminal (nameof (HexIntegerLiteral),     $@"{HexNumeral}([lL])?");
			public  readonly    Terminal    OctalIntegerLiteral         = new RegexBasedTerminal (nameof (OctalIntegerLiteral),   @"0[0-7]([0-7_]*[0-7])?");
			public  readonly    Terminal    BinaryIntegerLiteral        = new RegexBasedTerminal (nameof (BinaryIntegerLiteral),  @"0[Bb][01]([01_]*[01])?");

			// §3.10.2 Floating-Point Literals: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.10.2
			public  readonly    NonTerminal FloatingPointLiteral        = new NonTerminal (nameof (FloatingPointLiteral));
			const string FloatTypeSuffix            = "[fFdD]";
			const string SignedInteger              = "[+-]?" + Digits;
			const string ExponentIndicator          = "[eE]";
			const string ExponentPart               = ExponentIndicator + SignedInteger;
			public  readonly    Terminal    DecimalFloatingPointLiteral = new RegexBasedTerminal (nameof (DecimalFloatingPointLiteral),  "(" +
				$@"{Digits}\.({Digits})?({ExponentPart})?({FloatTypeSuffix})?" +
				"|" +
				$@"\.{Digits}({ExponentPart})?({FloatTypeSuffix})?" +
				"|" +
				$@"{Digits}{ExponentPart}({FloatTypeSuffix})?" +
				"|" +
				$@"{Digits}({ExponentPart})?{FloatTypeSuffix}" +
			")");
			const string HexSignficand              = "(" +
				HexNumeral + @"\.?" +
				"|" +
				"0[Xx](" + HexDigits + @")?\." + HexDigits + ")" +
				")";
			const string BinaryExponentIndicator    = "[pP]";
			const string BinaryExponent             = BinaryExponentIndicator + SignedInteger;
			public  readonly    Terminal    HexadecimalFloatingPointLiteral     = new RegexBasedTerminal (nameof (HexadecimalFloatingPointLiteral),
				$"({HexSignficand}{BinaryExponent}{FloatTypeSuffix}?");

			// §3.10.3 Boolean Literals: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.10.3
			public  readonly    NonTerminal BooleanLiteral              = new NonTerminal (nameof (BooleanLiteral));

			// §3.10.4 Character Literals: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.10.4
			const string EscapeSequence             = @"(\b|\t|\n|\f|\r|\""|\'|\\|\[0-3][0-7][0-7]|\[0-7][0-7]|\[0-7])";
			public  readonly    Terminal CharacterLiteral               = new StringLiteral (nameof (CharacterLiteral), startEndSymbol: "'", options: StringOptions.IsChar | StringOptions.AllowsAllEscapes);
			#if false
			public  readonly    Terminal CharacterLiteral               = new RegexBasedTerminal (nameof (CharacterLiteral),  "'" +
				"(" +
					"[^\\'\u000a\u000d]" +  // SingleCharacter
					"|" +
					EscapeSequence +        // EscapeSequence
				")'");
				#endif

			// §3.10.5 String Literals: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.10.5
			public  readonly    Terminal    StringLiteral               = new StringLiteral (nameof (StringLiteral), "\"", StringOptions.AllowsAllEscapes);
			#if false
			public  readonly    Terminal    StringLiteral               = new RegexBasedTerminal (nameof (StringLiteral), "\"" +
				"(" +
					"[^\\\"\u000a\u000d]" + // StringCharacter
					"|" +
					EscapeSequence +
				")*\"");
				#endif

			// §3.10.7 The Null Literal: https://docs.oracle.com/javase/specs/jls/se13/html/jls-3.html#jls-3.10.7
			public  readonly    Terminal    NullLiteral                 = new KeyTerm ("null", "null");
		}
	}
}
