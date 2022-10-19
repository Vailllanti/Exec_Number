using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		//有一個數值,是四位數
		//左邊二位的數字相同
		//右邊二位的數字相同
        //這個四位數值, 剛好也是某整數的平方
        //請問這個四位數值是什麼?
		static void Main(string[] args)
		{
			double inputNumber;
			double sqrt;
			double ceiling;
			for (double i = 11; i <= 99; i+=11)
			{
				for (double k = 11; k <= 99; k+=11)
				{
					inputNumber = i * 100 + k;
					sqrt = Math.Sqrt(inputNumber);
					ceiling = Math.Ceiling(sqrt);
					if (ceiling == sqrt)
					{
						Console.WriteLine($"答案是{inputNumber}");
						return;
					}
				}
			}
		}
	}
}
