using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4百元買百雞
{
	internal class Program
	{
		//想用一百元買剛好一百隻雞, 公雞 5 元, 母雞 3 元, 小雞三隻 1 元
		//公雞(Cock), 母雞(Hen), 小雞(Chicken)
		static void Main(string[] args)
		{
			//設買公雞x組，母雞y組，小雞z組
			//5x+3y+z=100 x+y+3Z=100 => 2x+y=Z =>7x+4y=100
			double cockMax = 100/7;
			double hen ;
			double chicken ;
			const int goalNumber = 100;

			Console.WriteLine("百元買百雞，您可選擇: ");
			for (int i = 0; i < cockMax; i += 2)
			{
				hen = (goalNumber - 7 * i)/4;
				if (hen == Math.Ceiling(hen))
				{
					chicken = 2*i + hen;
					if (i+hen+3*chicken == 100)
					{
						Console.WriteLine($"公雞買{i}隻，母雞買{hen}隻，小雞買{3 * chicken}隻");
					}
				}
			}
	

		}
	}
}
