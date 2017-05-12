using System;
using ParserAlgebraicExpressions.arifmeticalNode;

namespace ParserAlgebraicExpressions.expressions
{
    public class Context // stores the expression
    {
        private readonly string _text;

        public Context(string text)
        {
            _text = text;
        }

        public ArithmeticalNode ResultNode { get; set; }

        public string Text
        {
            get { return _text; }
        }

        public bool HasResult
        {
            get { return ResultNode != null; }
        }

        public ArithmeticalNode ResultNodeForced
        {
            get
            {
                var res = ResultNode;
                if (res == null)
                {
                    throw new Exception("There is no result!");
                }
                return res;
            }
        }
    }
}
