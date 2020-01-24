using System;
using System.Linq;

using NUnit.Framework;

using Java.Interop.Tools.JavaSource;
using Xamarin.Android.Tools.ApiXmlAdjuster;

namespace Java.Interop.Tools.JavaSource.Tests
{
	[TestFixture]
	public class JavaSE13ParserTests
	{
		[Test]
		public void TryParse_EmptySource ()
		{
			var parser  = new JavaSE13Parser ();
			var package = parser.TryParse ("");
			Assert.IsNotNull (package);
			Assert.AreEqual (null, package.Name);
			Assert.AreEqual (0, package.Types.Count);
		}

		[Test]
		public void TryParse_Demo ()
		{
			var parser  = new JavaSE13Parser ();
			var package = parser.TryParse (@"
package example;

import java.lang.String;
import java.lang.Integer;
");
			Assert.IsNotNull (package);
			Assert.AreEqual ("example", package.Name);
			Assert.AreEqual (0, package.Types.Count);

			Assert.AreEqual (2, package.Imports.Count, $"Found {package.Imports.Count} imports!");
			Assert.AreEqual ("java.lang.String", package.Imports [0]);
			Assert.AreEqual ("java.lang.Integer", package.Imports [1]);
		}
	}
}
