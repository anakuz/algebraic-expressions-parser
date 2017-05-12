using System;
using System.Collections.Generic;
using ParserAlgebraicExpressions.arifmeticalNode;
using ParserAlgebraicExpressions.expressions.nonTerminal;

namespace ParserAlgebraicExpressions
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Run();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Run()
        {
            Console.WriteLine("Set an expression (no parentheses, only +,-,*,/):");
            var text = Console.ReadLine();
            ArithmeticalNode node;
            new ExpressionTotal().Interpret(text, out node);
            var x = node.Eval;
            Console.WriteLine("Result: {0}",x);
        }
    }
}