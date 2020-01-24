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
		// §15 Expressions: https://docs.oracle.com/javase/specs/jls/se13/html/jls-15.html
		public class ExpressionsBnfTerms {
			internal void CreateRules (JavaSE13Grammar grammar)
			{
				Expression.Rule = LambdaExpresssion
					| AssignmentExpression;

#if false
				PrimaryNoNewArray = new NonTerminal (nameof (PrimaryNoNewArray)) {
					Rule = LexicalTerms.Literal
						| ClassLiteral
						| grammar.ToTerm ("this")
						| NameTerms.TypeName + grammar.ToTerm (".") + grammar.ToTerm ("this")
						| grammar.ToTerm ("(") + Expression
				}
				Primary = new NonTerminal (nameof (Primary)) {
					Rule = PrimaryNoNewArray | ArrayCreationExpression,
				};
#endif
			}

			// §15.2 Forms of Expressions: https://docs.oracle.com/javase/specs/jls/se13/html/jls-15.html#jls-15.2
			public readonly NonTerminal Expression                  = new NonTerminal (nameof (Expression), FlattenChildNodes);
			public readonly NonTerminal LambdaExpresssion           = new NonTerminal (nameof (LambdaExpresssion), FlattenChildNodes);
			public readonly NonTerminal AssignmentExpression        = new NonTerminal (nameof (AssignmentExpression), FlattenChildNodes);
		}
	}
}
