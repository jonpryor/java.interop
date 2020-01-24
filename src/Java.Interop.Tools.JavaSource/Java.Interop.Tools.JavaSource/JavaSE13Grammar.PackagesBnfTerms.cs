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

	partial class JavaSE13Grammar {
		// §7 Packages and Modules: https://docs.oracle.com/javase/specs/jls/se13/html/jls-7.html
		public class PackagesBnfTerms {
			internal void CreateRules (JavaSE13Grammar grammar)
			{
				CompilationUnit.Rule = OrdinaryCompilationUnit
#if TODO
					| ModularCompilationUnit
#endif	// TODO
					;

				OrdinaryCompilationUnit.Rule = PackageDeclaration_opt + ImportDeclarations + TypeDeclarations;

				PackageDeclaration.Rule = /* PackageModifiers + */ "package" + grammar.LexicalTerms.Identifier + grammar.LexicalTerms.DotIdentifiers + ";";
				PackageDeclaration.AstConfig.NodeCreator = (context, parseNode) => {
					var package	        = GetPackage (context);
					package.Name        = parseNode.ChildNodes [1].AstNode.ToString () + parseNode.ChildNodes [2].AstNode.ToString ();
					parseNode.AstNode   = package;
				};
				PackageDeclaration_opt.Rule = PackageDeclaration | grammar.Empty;
				PackageDeclaration_opt.AstConfig.NodeCreator = (context, parseNode) => {
					parseNode.AstNode   = GetPackage (context);
				};

				ImportDeclaration.Rule  = "import" + grammar.LexicalTerms.Identifier + grammar.LexicalTerms.DotIdentifiers + ";";
				ImportDeclaration.AstConfig.NodeCreator = (context, parseNode) => {
					var package = GetPackage (context);
					var import  = parseNode.ChildNodes [1].AstNode.ToString () + parseNode.ChildNodes [2].AstNode.ToString ();
					package.Imports.Add (import);
					parseNode.AstNode   = package;
				};

				TypeDeclaration.Rule = grammar.Empty;

				// PackageModifier.Rule = Annotation;

				ImportDeclarations.MakeStarRule (grammar, ImportDeclaration);
				TypeDeclarations.MakeStarRule (grammar, TypeDeclaration);
				PackageModifiers.MakeStarRule (grammar, PackageModifier);
			}

			internal void OnGrammarDataConstructed (LanguageData language)
			{
			}

			// §7.3 Compilation Units: https://docs.oracle.com/javase/specs/jls/se13/html/jls-7.html#jls-7.3
			public  readonly    NonTerminal CompilationUnit             = new NonTerminal (nameof (CompilationUnit), UseFirstChildAstNode);
			public  readonly    NonTerminal OrdinaryCompilationUnit     = new NonTerminal (nameof (OrdinaryCompilationUnit), UseFirstChildAstNode);
			public  readonly    NonTerminal ModularCompilationUnit      = new NonTerminal (nameof (ModularCompilationUnit), UseFirstChildAstNode);

			// §7.4.1 Named Packages: https://docs.oracle.com/javase/specs/jls/se13/html/jls-7.html#jls-7.4.1
			public  readonly    NonTerminal PackageDeclaration          = new NonTerminal (nameof (PackageDeclaration));
			public  readonly    NonTerminal PackageDeclaration_opt      = new NonTerminal (nameof (PackageDeclaration_opt));
			public  readonly    NonTerminal PackageModifier             = new NonTerminal (nameof (PackageModifier));
			public  readonly    NonTerminal PackageModifiers            = new NonTerminal (nameof (PackageModifiers));

			// §7.5: Import Declarations: https://docs.oracle.com/javase/specs/jls/se13/html/jls-7.html#jls-7.5
			public  readonly    NonTerminal ImportDeclaration           = new NonTerminal (nameof (ImportDeclaration));
			public  readonly    NonTerminal ImportDeclarations          = new NonTerminal (nameof (ImportDeclarations), UseFirstChildAstNode);

			// §7.6: Top-Level Type Declarations: https://docs.oracle.com/javase/specs/jls/se13/html/jls-7.html#jls-7.6
			public  readonly    NonTerminal TypeDeclaration             = new NonTerminal (nameof (TypeDeclaration), UseFirstChildAstNode);
			public  readonly    NonTerminal TypeDeclarations            = new NonTerminal (nameof (TypeDeclarations), UseFirstChildAstNode);

			// §7.7: Module Declarations
			public  readonly    NonTerminal ModuleDeclaration           = new NonTerminal (nameof (ModuleDeclaration));

			static JavaPackage GetPackage (AstContext context)
			{
				if (context.Values.TryGetValue ("package", out var package) &&
						package is JavaPackage p) {
					return p;
				}
				p = new JavaPackage (null);
				context.Values ["package"] = p;
				return p;
			}
		}
	}
}
