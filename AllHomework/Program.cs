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

			double valueX = MyFirstHomework.GetVariableOfTheEquation (7.1, 5.1, 40.1);
			Console.WriteLine(valueX);

			MyFirstHomework.GetEquationOfTheLine (1, 5, 10, 2);

			int rezult1 = MySecondHomework.GetSumOrDifferenceOrProductOfNumber(7, 4);
			Console.WriteLine(rezult1);

			MySecondHomework.GetQuarterCoordinatesPoint(-1, 8);

			MySecondHomework.GetTwodigitNumberInWords(55);
			Console.ReadKey();
		}
	}
}
