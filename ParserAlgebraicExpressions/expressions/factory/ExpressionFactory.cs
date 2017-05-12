using System.Collections.Generic;
using ParserAlgebraicExpressions.expressions.nonTerminal;

namespace ParserAlgebraicExpressions.expressions.factory
{
    class ExpressionFactory // flyweight pattern
    {
        private static readonly Dictionary<char, ExpressionBase> Expressions = new Dictionary<char, ExpressionBase>();

        public static ExpressionBase GetOperation(char operationSymbol)
        {
            ExpressionBase expr;
            if (!Expressions.TryGetValue(operationSymbol, out expr))
            {
                expr = Expressions[operationSymbol] = new ExpressionOperation(operationSymbol);
            }
            return expr;
        }
    }
}
