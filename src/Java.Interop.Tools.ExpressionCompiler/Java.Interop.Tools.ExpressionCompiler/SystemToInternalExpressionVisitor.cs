extern alias SystemSleLib;

using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

using SysSle = SystemSleLib::System.Linq.Expressions;

namespace Java.Interop.Tools.ExpressionCompiler;

class SystemToInternalExpressionVisitor : SysSle.ExpressionVisitor
{
	public static LambdaExpression FromSystem (SysSle.LambdaExpression node)
	{
		throw new NotSupportedException ();
	}

	/// <summary>
	/// Dispatches the expression to one of the more specialized visit methods in this class.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	[return: NotNullIfNotNull("node")]
	public override SysSle.Expression? Visit (
			SysSle.Expression? node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="BinaryExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitBinary (
			SysSle.BinaryExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="BlockExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitBlock (
			SysSle.BlockExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="ConditionalExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitConditional (
			SysSle.ConditionalExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the <see cref="ConstantExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitConstant (
			SysSle.ConstantExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the <see cref="DebugInfoExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override  SysSle.Expression VisitDebugInfo (
			SysSle.DebugInfoExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the <see cref="DefaultExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitDefault (
			SysSle.DefaultExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the extension expression.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	/// <remarks>
	/// This can be overridden to visit or rewrite specific extension nodes.
	/// If it is not overridden, this method will call <see cref="Expression.VisitChildren"/>,
	/// which gives the node a chance to walk its children. By default,
	/// <see cref="Expression.VisitChildren"/> will try to reduce the node.
	/// </remarks>
	protected override SysSle.Expression VisitExtension (
			SysSle.Expression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="GotoExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitGoto (
			SysSle.GotoExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="InvocationExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitInvocation (
			SysSle.InvocationExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the <see cref="LabelTarget"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	[return: NotNullIfNotNull("node")]
	protected override SysSle.LabelTarget? VisitLabelTarget (
			SysSle.LabelTarget? node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="LabelExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitLabel (
			SysSle.LabelExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="Expression{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the delegate.</typeparam>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitLambda<T>(SysSle.Expression<T> node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="LoopExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitLoop (
			SysSle.LoopExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="MemberExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitMember (
			SysSle.MemberExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="IndexExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitIndex (
			SysSle.IndexExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="MethodCallExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitMethodCall (
			SysSle.MethodCallExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="NewArrayExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitNewArray (
			SysSle.NewArrayExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="NewExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitNew (
			SysSle.NewExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the <see cref="ParameterExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitParameter (
			SysSle.ParameterExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="RuntimeVariablesExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitRuntimeVariables (
			SysSle.RuntimeVariablesExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="SwitchCase"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.SwitchCase VisitSwitchCase (
			SysSle.SwitchCase node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="SwitchExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitSwitch (
			SysSle.SwitchExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="CatchBlock"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.CatchBlock VisitCatchBlock (
			SysSle.CatchBlock node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="TryExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitTry (
			SysSle.TryExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="TypeBinaryExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitTypeBinary (
			SysSle.TypeBinaryExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="UnaryExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitUnary (
			SysSle.UnaryExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="MemberInitExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitMemberInit (
			SysSle.MemberInitExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="ListInitExpression"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitListInit (
			SysSle.ListInitExpression node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="ElementInit"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected virtual SysSle.ElementInit VisitElementInit (
			SysSle.ElementInit node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="MemberBinding"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.MemberBinding VisitMemberBinding (
			SysSle.MemberBinding node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="MemberAssignment"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.MemberAssignment VisitMemberAssignment (
			SysSle.MemberAssignment node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="MemberMemberBinding"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.MemberMemberBinding VisitMemberMemberBinding (
			SysSle.MemberMemberBinding node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="MemberListBinding"/>.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.MemberListBinding VisitMemberListBinding (
			SysSle.MemberListBinding node)
	{
		return node;
	}

	/// <summary>
	/// Visits the children of the <see cref="DynamicExpression" />.
	/// </summary>
	/// <param name="node">The expression to visit.</param>
	/// <returns>The modified expression, if it or any subexpression was modified;
	/// otherwise, returns the original expression.</returns>
	protected override SysSle.Expression VisitDynamic (
			SysSle.DynamicExpression node)
	{
		return node;
	}
}
