namespace NumberTricks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            NumberUtilts numberUtilts = new NumberUtilts(n, num);
            Console.WriteLine(numberUtilts.NRoothBabylon(n, num));


            Console.WriteLine("SieveOfEratosthenes: ");
            int m = int.Parse(Console.ReadLine());
            NumberUtilts.SieveOfEratosthenes(m);
        }
    }
}
