using System;
using ParserAlgebraicExpressions.arifmeticalNode;
using ParserAlgebraicExpressions.expressions.factory;
using ParserAlgebraicExpressions.helpers;

namespace ParserAlgebraicExpressions.expressions.nonTerminal
{
    public class ExpressionOperation : ExpressionBase //non terminal
    {
        public static ExpressionBase Plus
        {
            get { return ExpressionFactory.GetOperation('+'); }
        }

        public static ExpressionBase Minus
        {
            get { return ExpressionFactory.GetOperation('-'); }
        }

        public static ExpressionBase Multiply
        {
            get { return ExpressionFactory.GetOperation('*'); }
        }

        public static ExpressionBase Divide
        {
            get { return ExpressionFactory.GetOperation('/'); }
        }

        private readonly char _operationSymbol;

        public ExpressionOperation(char opeartionSymbol)
        {
            _operationSymbol = opeartionSymbol;
        }

        protected override void InterpretOverride(Context context)
        {
            var text = context.Text;
            var index = text.LastIndexOf(_operationSymbol);
            if (index == -1)
            {
                return;
            }
            string part1, part2;
            Helper.Split(text, index, out part1, out part2);
            var expressionTotal = new ExpressionTotal();
            var context1 = new Context(part1);
            var context2 = new Context(part2);
            expressionTotal.Interpret(context1);
            expressionTotal.Interpret(context2);
            if (!context1.HasResult && !context2.HasResult)
            {
                throw new Exception("Invalid expression");
            }
            context.ResultNode = new ArithmeticalOperation(_operationSymbol, context1.ResultNodeForced, context2.ResultNodeForced);
        }
    }
}
