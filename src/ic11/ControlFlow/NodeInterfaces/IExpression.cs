using ic11.ControlFlow.Context;
using ic11.ControlFlow.Nodes;
using System.Globalization;

namespace ic11.ControlFlow.NodeInterfaces;
public interface IExpression
{
    Variable? Variable { get; set; }
    decimal? CtKnownValue { get; }
    string Render() => GetRenderString(this);

    private static string GetRenderString(IExpression expression)
    {
        // Check for builtin constants first
        if (expression is UserDefinedValueAccess userAccess && userAccess.BuiltinConstantName is not null)
            return userAccess.BuiltinConstantName;

        if (expression.CtKnownValue.HasValue)
            return expression.CtKnownValue.Value.ToString(CultureInfo.InvariantCulture);

        return expression.Variable?.Register ?? throw new Exception("Expression has no variable or constant value");
    }

    public int FirstIndexInTree => GetFirstExpressionIndex(this);

    private int GetFirstExpressionIndex(IExpression ex)
    {
        var index = ((Node)ex).IndexInScope;

        if (ex is IExpressionContainer ec)
        {
            foreach (var item in ec.Expressions)
                index = Math.Min(index, GetFirstExpressionIndex(item));
        }

        return index;
    }
}
