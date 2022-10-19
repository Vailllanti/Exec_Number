using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1判斷某數值是不是質數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入需要判別是否為質數的整數: ");
			string input = Console.ReadLine();
			bool isDouble = double.TryParse(input, out double result);
			int limit = (int)result;

			if (isDouble == false)
			{
				Console.WriteLine("抱歉，您好像輸入的不是數字");
				return;
			}
			
			if (result != limit)
			{
				Console.WriteLine("您輸入的數字不是整數");
				return ;
			}
			
			if (result <= 1 )
			{
				Console.WriteLine("請輸入大於1的整數");
				return ;
			}

			if (result % 2 == 0 || result/2 == 1)
			{
				Console.WriteLine($"{result}不為質數");
				return;
			}

			double sqrt = Math.Sqrt(result);

			for (int i = 3; i < sqrt; i += 2 )
			{
				if (result % i == 0)
				{
					Console.WriteLine($"{result}不為質數");
					return;
				}
			}
			Console.WriteLine($"{result}為質數");

		}
	}
}
