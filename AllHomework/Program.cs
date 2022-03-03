using System;
using AllHomework;

namespace AllHomework
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int rezult=MyFirstHomework.GetResultOfTheEquation (7, 4);
			Console.WriteLine(rezult);
			int valueX = MyFirstHomework.GetVariableOfTheEquation (7, 5, 40);
			Console.WriteLine(valueX);
			MyFirstHomework.GetEquationOfTheLine (1, 5, 10, 2);
			Console.ReadKey();
		}
	}
}
