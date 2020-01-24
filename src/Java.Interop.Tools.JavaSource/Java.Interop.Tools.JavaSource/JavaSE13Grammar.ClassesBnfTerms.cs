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
		// §8 Classes: https://docs.oracle.com/javase/specs/jls/se13/html/jls-8.html
		public class ClassesBnfTerms {
			internal void CreateRules (JavaSE13Grammar grammar)
			{
				ClassDeclaration.Rule = NormalClassDeclaration | EnumClassDeclaration;
				NormalClassDeclaration.Rule = ClassModifier.Q () + "class" + grammar.LexicalTerms.TypeIdentifier + TypeParameters.Q () +
					Superclass.Q () + Superinterfaces.Q () +
					ClassBody;

				ClassModifier.Rule = /* TODO: Annotations */ grammar.ToTerm ("public")
					| "protected"
					| "private"
					| "abstract"
					| "static"
					| "final"
					| "strictfp";

				var ClassType = new NonTerminal ("ClassType", FlattenChildNodes);
				Superclass.Rule = "extends" + ClassType;
			}

			internal void OnGrammarDataConstructed (LanguageData language)
			{
			}

			// §8.1 Class Declrations: https://docs.oracle.com/javase/specs/jls/se13/html/jls-8.html#jls-8.1
			public  readonly    NonTerminal ClassDeclaration            = new NonTerminal (nameof (ClassDeclaration), FlattenChildNodes);
			public  readonly    NonTerminal NormalClassDeclaration      = new NonTerminal (nameof (NormalClassDeclaration), FlattenChildNodes);
			public  readonly    NonTerminal EnumClassDeclaration        = new NonTerminal (nameof (EnumClassDeclaration), FlattenChildNodes);

			// §8.1.1 Class Modifiers: https://docs.oracle.com/javase/specs/jls/se13/html/jls-8.html#jls-8.1.1
			public  readonly    NonTerminal ClassModifier               = new NonTerminal (nameof (ClassModifier), FlattenChildNodes);

			// §8.1.2 Generic Classes and Type Parameters: https://docs.oracle.com/javase/specs/jls/se13/html/jls-8.html#jls-8.1.2
			public  readonly    NonTerminal TypeParameters              = new NonTerminal (nameof (TypeParameters), FlattenChildNodes);

			// §8.1.4 Superclasses and Subclasses: https://docs.oracle.com/javase/specs/jls/se13/html/jls-8.html#jls-8.1.4
			public  readonly    NonTerminal Superclass                  = new NonTerminal (nameof (Superclass), FlattenChildNodes);

			// §8.1.5 Superinterfaces: https://docs.oracle.com/javase/specs/jls/se13/html/jls-8.html#jls-8.1.5
			public  readonly    NonTerminal Superinterfaces             = new NonTerminal (nameof (Superinterfaces), FlattenChildNodes);
			public  readonly    NonTerminal InterfaceTypeList           = new NonTerminal (nameof (InterfaceTypeList), FlattenChildNodes);

			// §8.1.6 Class Body and Member Declarations: https://docs.oracle.com/javase/specs/jls/se13/html/jls-8.html#jls-8.1.6
			public  readonly    NonTerminal ClassBody                   = new NonTerminal (nameof (ClassBody), FlattenChildNodes);
			public  readonly    NonTerminal ClassBodyDeclaration        = new NonTerminal (nameof (ClassBodyDeclaration), FlattenChildNodes);
			public  readonly    NonTerminal InstanceInitializer         = new NonTerminal (nameof (InstanceInitializer), FlattenChildNodes);
			public  readonly    NonTerminal StaticInitializer           = new NonTerminal (nameof (StaticInitializer), FlattenChildNodes);
			public  readonly    NonTerminal ConstructorDeclaration      = new NonTerminal (nameof (ConstructorDeclaration), FlattenChildNodes);
			public  readonly    NonTerminal FieldDeclaration            = new NonTerminal (nameof (FieldDeclaration), FlattenChildNodes);
			public  readonly    NonTerminal MethodDeclaration           = new NonTerminal (nameof (MethodDeclaration), FlattenChildNodes);
		}
	}
}
