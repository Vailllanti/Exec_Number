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
			Console.Write("請輸入第一個數字");
			string input1 = Console.ReadLine();
			Console.Write("請輸入第二個數字");
			string input2 = Console.ReadLine();

			bool isDouble1 = double.TryParse(input1, out double result1);
			bool isDouble2 = double.TryParse(input2, out double result2);

			if (isDouble1 || isDouble2 == false)
			{
				Console.WriteLine("抱歉，您好像輸入的不是數字");
				return;
			}

			if (result1 <= 1 || result2 <= 1)
			{
				Console.WriteLine("請輸入大於1的整數");
				return;
			}

		}
	}
}
