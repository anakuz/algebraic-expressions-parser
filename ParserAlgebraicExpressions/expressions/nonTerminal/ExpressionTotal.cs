using System;
using System.Collections.Generic;
using ParserAlgebraicExpressions.arifmeticalNode;
using ParserAlgebraicExpressions.expressions.terminal;

namespace ParserAlgebraicExpressions.expressions.nonTerminal
{
    public class ExpressionTotal : ExpressionBase // non terminal
    {
        private IEnumerable<ExpressionBase> Expressions
        {
            get
            {
                yield return ExpressionNumeric.Instance;
                yield return ExpressionOperation.Plus;
                yield return ExpressionOperation.Minus;
                yield return ExpressionOperation.Multiply;
                yield return ExpressionOperation.Divide;
            }
        }

        protected override void InterpretOverride(Context context)
        {
            foreach (var expression in Expressions)
            {
                expression.Interpret(context);
                if (context.HasResult)
                {
                    return;
                }
            }
            throw new Exception("Invalid expression");
        }
    }

    public class Parser
    {
        private Parser()
        {
            
        }

        private static readonly Parser InstanceField = new Parser();

        public static Parser Instance { get { return InstanceField; } }

        public ArithmeticalNode Parse(string text)
        {
            ArithmeticalNode node;
            new ExpressionTotal().Interpret(text, out node);
            return node;
        }
    }


}
