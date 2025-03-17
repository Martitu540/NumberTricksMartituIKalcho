namespace NumberTricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberTricks.FastPow(2,11));

            NumberTricks num = new NumberTricks();
            num.PrintPascalsTriangle(10);
        }
    }
}
