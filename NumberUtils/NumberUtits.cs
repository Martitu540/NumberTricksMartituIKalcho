using System;

namespace NumberTricks
{

public class NumberTricks
    {
		
	public NumberTricks()
	{
		
    }
        public static double FastPow(double a, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            double halfPowered = FastPow(a, n / 2);
            double subTotal = halfPowered * halfPowered;
            return n % 2 == 0 ? subTotal : subTotal * a;
        }

    } 

}