extern alias SystemSleLib;

using System.Diagnostics.CodeAnalysis;
using System.Dynamic.Utils;
using System.Linq.Expressions;
using System.Linq.Expressions.Compiler;

using SysSle = SystemSleLib::System.Linq.Expressions;

namespace Java.Interop.Tools.ExpressionCompiler;

public class LambdaExpressionCompiler {
	/// <summary>
	/// Compiles the lambda into a method definition.
	/// </summary>
	/// <param name="method">A <see cref="Emit.MethodBuilder"/> which will be used to hold the lambda's IL.</param>
	public void CompileToMethod (SysSle.LambdaExpression self, System.Reflection.Emit.MethodBuilder method)
	{
		ArgumentNullException.ThrowIfNull (self);
		ArgumentNullException.ThrowIfNull (method);
		ContractUtils.Requires (method.IsStatic, nameof (method));
		var type = method.DeclaringType as System.Reflection.Emit.TypeBuilder;
		if (type == null) {
            throw Error.MethodBuilderDoesNotHaveTypeBuilder();
        }

        var internalExpression = SystemToInternalExpressionVisitor.FromSystem (self);
		LambdaCompiler.Compile (internalExpression, method);
	}
}
