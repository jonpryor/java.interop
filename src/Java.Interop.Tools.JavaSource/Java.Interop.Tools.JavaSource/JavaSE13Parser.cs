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

	public class JavaSE13Parser : Parser {

		public JavaSE13Parser ()
			: base (CreateGrammar ())
		{
		}

		static JavaSE13Grammar CreateGrammar ()
		{
			return new JavaSE13Grammar () {
				LanguageFlags   = LanguageFlags.Default | LanguageFlags.CreateAst,
			};
		}

		public JavaPackage? TryLoad (string uri)
		{
			return TryLoad (uri, out var _);
		}

		public JavaPackage? TryLoad (string uri, out ParseTree? parseTree)
		{
			return TryParse (File.ReadAllText (uri), uri, out parseTree);
		}

		public JavaPackage? TryParse (string text)
		{
			return TryParse (text, null, out var _);
		}

		public JavaPackage? TryParse (string text, out ParseTree parseTree)
		{
			return TryParse (text, null, out parseTree);
		}

		public JavaPackage? TryParse (string text, string? fileName, out ParseTree parseTree)
		{
			parseTree = base.Parse (text, fileName);
			if (parseTree == null)
				return null;
			foreach (var m in parseTree.ParserMessages) {
				switch (m.Level) {
					case ErrorLevel.Error:
						Console.Error.WriteLine ($"{m.Location}: error : {m.Message}");
						break;
					case ErrorLevel.Warning:
						Console.WriteLine ($"{m.Location}: warning : {m.Message}");
						break;
					default:
						Console.WriteLine ($"{m.Location}: {m.Message}");
						break;
				}
			}
			if (parseTree.HasErrors ())
				return null;
			var parsedPackage = (JavaPackage) parseTree.Root.AstNode;
			return parsedPackage;
		}
	}
}
