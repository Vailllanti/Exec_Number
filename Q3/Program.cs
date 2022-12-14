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
			int inputNumber;
			string sqrt;
			const int commonDifference = 11;
			const int hundred = 100;

			for (int i = 1; i <= 9; i++)
			{
				for (int k = 1; k <= 9; k++)
				{
					inputNumber = (i * hundred  + k) *commonDifference;
					sqrt = Convert.ToString( Math.Sqrt(inputNumber));
					if ( int.TryParse(sqrt,out int s) == true)
					{
						Console.WriteLine($"答案是{inputNumber}");
						return;
					}
				}
			}
		}
	}
}
