using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2找出數值區間內的所有質數
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("請輸入第一個數字:");
			string input1 = Console.ReadLine();
			Console.Write("請輸入第二個數字:");
			string input2 = Console.ReadLine();

			bool isDouble1 = double.TryParse(input1, out double result1);
			bool isDouble2 = double.TryParse(input2, out double result2);

			if (isDouble1 == false || isDouble2 == false)
			{
				Console.WriteLine("抱歉，您好像輸入的不是數字");
				return;
			}

			if (result1 <= 1 || result2 <= 1)
			{
				Console.WriteLine("請輸入大於1的數字");
				return;
			}	
			
			//取最大值
			double limitMax = Math.Max(result1, result2);
			//取最小值
			double limitMin = Math.Min(result1, result2);
			
			Console.Write($"介於 {limitMin} ~ {limitMax} 的質數有:");

			//最小值直接進位
			limitMin = Math.Ceiling(limitMin);
			
			if (limitMin < 5)
			{
				Console.Write(" 2 3 5");
			}

			//將limitMin固定為奇數
			if (limitMin % 2 == 0)
			{
				limitMin++;
			}

			string anwser = string.Empty ;

			for (int i = (int)limitMin; i <= limitMax; i+= 2)
			{
				double sqrt = Math.Sqrt(i);
				anwser = $" {i}";
				for (int k = 3; k <= sqrt; k += 2 )
				{
					if (i % k == 0)
					{
						anwser = string.Empty;
						break;
					}
				}
				Console.Write($"{anwser}");
			}
			Console.WriteLine();
		}
	}
}
