using System;

namespace ParserAlgebraicExpressions.arifmeticalNode
{
    public class ArithmeticalOperation : ArithmeticalNode //non terminal
    {
        private readonly char _arifmeticOperation;
        private readonly ArithmeticalNode _leftNode;
        private readonly ArithmeticalNode _rightNode;

        public ArithmeticalOperation(char arifmeticOperation, ArithmeticalNode leftNode, ArithmeticalNode rightNode)
        {
            _arifmeticOperation = arifmeticOperation;
            _leftNode = leftNode;
            _rightNode = rightNode;
        }

        public override double Eval // calculation
        {
            get
            {
                var res1 = _leftNode.Eval;
                var res2 = _rightNode.Eval;
                switch (_arifmeticOperation)
                {
                    case '+':
                        return res1 + res2;
                    case '-':
                        return res1 - res2;
                    case '*':
                        return res1 * res2;
                    case '/':
                        return res1 / res2;
                }
                throw new Exception("Unknown arithmetic operation!");
            }
        }
    }
}
