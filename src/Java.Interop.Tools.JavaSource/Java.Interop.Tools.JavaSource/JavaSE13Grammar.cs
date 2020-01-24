#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

using Irony;
using Irony.Ast;
using Irony.Parsing;

using Xamarin.Android.Tools.ApiXmlAdjuster;

namespace Java.Interop.Tools.JavaSource {

	// https://docs.oracle.com/javase/specs/jls/se13/html/index.html
	public partial class JavaSE13Grammar : Grammar {

		public  readonly    LexicalBnfTerms     LexicalTerms;
		public  readonly    PackagesBnfTerms    PackagesTerms;

		public JavaSE13Grammar ()
			: base (caseSensitive: true)
		{
			LexicalTerms    = new LexicalBnfTerms ();
			PackagesTerms   = new PackagesBnfTerms ();

			LexicalTerms.CreateRules (this);
			PackagesTerms.CreateRules (this);

			NonGrammarTerminals.Add (LexicalTerms.EndOfLineComment);
			NonGrammarTerminals.Add (LexicalTerms.TraditionalComment);

			this.Root = PackagesTerms.CompilationUnit;
		}

		public override void OnGrammarDataConstructed (LanguageData language)
		{
			LexicalTerms.OnGrammarDataConstructed (language);
			PackagesTerms.OnGrammarDataConstructed (language);
		}
	}

	public static class IronyCoda {
		public static string DumpTree (this ParseTree tree)
		{
			return DumpTree (tree.Root);
		}

		public static string DumpTree (this ParseTreeNode node)
		{
			var o = new StringWriter ();
			AppendNode (o, node, 0);
			return o.ToString ();
		}

		static void AppendNode (TextWriter o, ParseTreeNode node, int level)
		{
			for (int i = 0; i < level; i++)
				o.Write ("  ");
			o.WriteLine (node);
			foreach (ParseTreeNode child in node.ChildNodes)
				AppendNode (o, child, level + 1);
		}
	}
}
