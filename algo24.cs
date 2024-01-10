using System;

public class IntSqRoot 
{
	public static long IntRac(long n, long guess)  
	{
		long x = guess;
		long prevX;
		int count = 0;

		do {
			prevX = x;
			x = (x + n / x) / 2;
			count++;
		} while (Math.Abs(x - prevX) >= 1);

		return count;
	}
}
