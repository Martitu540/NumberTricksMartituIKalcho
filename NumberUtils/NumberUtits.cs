namespace NumberTricks
{
    public class NumberTricks
    {
        public NumberTricks() { }


    public class NumberUtilts
    {
        private int n, num;
        public NumberUtilts(int n, int num)
        {
            this.n = n;
            this.num = num;

        public static double FastPow(double a, int n)
        {
            if (n == 0) return 1;
            double halfPowered = FastPow(a, n / 2);
            double subTotal = halfPowered * halfPowered;
            return n % 2 == 0 ? subTotal : subTotal * a;

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

            return ans; }
    
     public void PrintPascalsTriangle(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                int number = 1;
                Console.Write(new string(' ', (rows - i) * 2));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(number + "   ");
                    number = number * (i - j) / (j + 1);
                }
                Console.WriteLine();
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


        }
   
        public void DrawCircle(int radius)
        {
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    double distance = Math.Sqrt(x * x + y * y);


                 } 
            }
                    if (distance <= radius) 
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
        
