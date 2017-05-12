using ParserAlgebraicExpressions.arifmeticalNode;

namespace ParserAlgebraicExpressions.expressions.terminal
{
    public class ExpressionNumeric : ExpressionBase // terminal
    {
        public static ExpressionBase Instance
        {
            get { return new ExpressionNumeric(); }
        }

        protected override void InterpretOverride(Context context)
        {
            double res;
            if (double.TryParse(context.Text, out res))
            {
                context.ResultNode = new ArithmeticalNumeric(res);
            }
        }
    }
}
