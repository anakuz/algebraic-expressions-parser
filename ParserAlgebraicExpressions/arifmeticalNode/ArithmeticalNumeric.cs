namespace ParserAlgebraicExpressions.arifmeticalNode
{
    public class ArithmeticalNumeric : ArithmeticalNode // terminal
    {
        private readonly double _x;

        public ArithmeticalNumeric(double x)
        {
            _x = x;
        }

        public override double Eval
        {
            get
            {
                return _x;
            }
        }
    }
}
