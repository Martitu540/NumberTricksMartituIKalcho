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
            while(mnogo> doKolko)
			{
				double prev = ans;
				ans = ((n-1) * ans+ num/Math.Pow(ans, n-1))/n;
                mnogo = Math.Abs(ans - prev);
            }

			return ans;
        }
} 

}