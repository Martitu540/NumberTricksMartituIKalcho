﻿using System;

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
			return ans;}
        }

}