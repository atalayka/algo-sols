using System;

public class NthSeries {
	
	public static string seriesSum (int n) {
		// Happy Coding ^_^
         double increase = 1.0;
                double sum = 1.0;
                double result = 0.0;

                if (n == 0)
                {
                    return "0.00";
                }

                if (n == 1)
                {
                    return "1.00";
                }


                for (int i = 0; i < n; i++)
                {
                    result += sum / increase;

                    increase += 3.0;
                }
                return string.Format("{0:0.00}", result);
	}
}