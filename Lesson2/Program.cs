using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
	class Program
	{
	enum NumbersName
	{ zero,
	one, 
	two,
	three,
	four,
	five,
	six,
	seven,
	eight,
	nine

	}
		static void Main(string[] args)
		{

		Random random = new Random();
			
			int i = random.Next(10000, 99999);
			Console.WriteLine("The random number was " + i);
			int s = 1;
			while  (i != 0)
			{
				s = s * (i % 10);
				i = i / 10;
			}
			Console.WriteLine("The multiplaxion of its digits is " + s);
			//Console.ReadKey();

			//string stra = Console.ReadLine();
			int a = int.Parse(Console.ReadLine()); //found a bug here - input string is in incorrect format if enter 1 as a first value
			int b = int.Parse(Console.ReadLine());
			int c = int.Parse(Console.ReadLine());

			int max = a;
			if (b > max){
				max = b;
			}
			if (c > max)
			{
				max = c;
			}
			Console.WriteLine("The max value " + max);
			string num = Console.ReadLine();
			int numberOfDigits = num.Length;
			int numb = Convert.ToInt32(num);
			string[] arrS = new string[numberOfDigits];
			int index = numberOfDigits - 1;
			while (numb !=0 ){
				arrS[index] = Enum.GetName(typeof(NumbersName), (numb % 10));
				numb = numb / 10;
				index = index - 1;
			}
			Console.WriteLine("Letters:{0} ", String.Join(", ",arrS));
			Console.ReadLine();




		}
	}
}
