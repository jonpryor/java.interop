#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Irony.Ast;
using Irony.Parsing;

namespace Java.Interop.Tools.JavaSource {

	public static class IronyHelpers {

		public static void MakeStarRule (this NonTerminal star, Grammar grammar, BnfTerm delimiter, BnfTerm of)
		{
			star.Rule = grammar.MakeStarRule (star, delimiter, of);
		}

		public static void MakeStarRule (this NonTerminal star, Grammar grammar, BnfTerm of)
		{
			star.Rule = grammar.MakeStarRule (star, of);
		}

		public static void FlattenChildNodes (AstContext context, ParseTreeNode parseNode)
		{
			parseNode.AstNode   = string.Join ("", parseNode.ChildNodes.Select (cn => cn.AstNode));
		}

		public static void UseFirstChildAstNode (AstContext context, ParseTreeNode parseNode)
		{
			foreach (var child in parseNode.ChildNodes) {
				if (child.AstNode != null) {
					parseNode.AstNode = child.AstNode;
					return;
				}
			}
		}

		public static AstNodeCreator WithCreator (Func<IList<string?>, string> creator)
		{
			AstNodeCreator c    = (AstContext context, ParseTreeNode parseNode) => {
				var childValues     = parseNode.ChildNodes.Select (cn => cn.AstNode?.ToString ())
					.ToList ();
				parseNode.AstNode   = creator (childValues);
			};
			return c;
		}
	}
}
