using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*題目：有一個數值,是四位數
				   左邊二位的數字相同
				   右邊二位的數字相同
				   這個四位數值, 剛好也是某整數的平方
				   請問這個四位數值是什麼?*/

			int thousandNumber = 1;//千分位
			int hundredNumber = 1;//百分位
			int tenNumber = 1;//十分位
			int oneNumber = 1;//個位
			int result = 0;//總數
			double sqrt = 0;//開根號
			int integer = 0;//換成整數
			bool isInt;//是否是整數


            for (int i = 1; i <= 9; i++)
			{
                thousandNumber = thousandNumber * 1000 * i;
                hundredNumber = hundredNumber * 100 * i;
                for (int k = 0; k <= 9; k++)
				{
					tenNumber = tenNumber * 10 * k;
					oneNumber = oneNumber * 1 * k;

					result = thousandNumber + hundredNumber + tenNumber + oneNumber;

					sqrt = Math.Sqrt(result);
					isInt = int.TryParse(sqrt.ToString(), out integer);

					if (isInt)
					{
                        Console.WriteLine($"這個數字就是 {result}");
                    }

                    tenNumber = 1;
                    oneNumber = 1;
                }
                thousandNumber = 1;
                hundredNumber = 1;
            }

        }
	}
}
