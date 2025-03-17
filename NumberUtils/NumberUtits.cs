using System;

namespace NumberTricks
{

    public class NumberUtilts
    {
        private int n, num;
        public NumberUtilts(int n, int num)
        {
            this.n = n;
            this.num = num;
        }

        public double NRoothBabylon(int n, int num)
        {
            double ans = num;
            double end = 0;
            double doKolko = 0.000001;
            double mnogo = double.MaxValue; ;
            while (mnogo > doKolko)
            {
                double prev = ans;
                ans = ((n - 1) * ans + num / Math.Pow(ans, n - 1)) / n;
                mnogo = Math.Abs(ans - prev);
            }

            return ans;
        }
        public static void SieveOfEratosthenes(int m)
        {
            bool[] prime = new bool[m + 1];
            for (int i=0; i <= m; i++)
            {
                prime[i] = true;
            }
            for (int p = 2; p * p <= m; p++)
            {
                if (prime[p] == true)
                {
                    for (int i = p * p; i <= m; i += p)
                    {
                        prime[i] = false;
                    }
                }
            }
            for (int i = 2; i <= m; i++)
            {
                if (prime[i] == true)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}