using System;
using ParserAlgebraicExpressions.arifmeticalNode;

namespace ParserAlgebraicExpressions.expressions
{
    public abstract class ExpressionBase // contains basic calculating methods and an abstract Interpret method
    {
        public void Interpret(Context context)
        {
            if (context.HasResult)
                throw new Exception("context already has result");
            InterpretOverride(context);
        }

        public void Interpret(string text, out ArithmeticalNode node)
        {
            var context = new Context(text);
            Interpret(context);
            node = context.ResultNodeForced;
        }

        protected abstract void InterpretOverride(Context context);
    }
}
