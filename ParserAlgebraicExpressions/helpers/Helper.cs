namespace ParserAlgebraicExpressions.helpers
{
    public class Helper
    {
        public static void Split(string text, int index, out string part1, out string part2)
        {
            part1 = text.Substring(0, index);
            part2 = text.Substring(index + 1);
        }
    }
}
