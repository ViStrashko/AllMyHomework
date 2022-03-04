using System;
using AllHomework;

namespace AllHomework
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double rezult=MyFirstHomework.GetResultOfTheEquation (-7.1, 4.5);
			Console.WriteLine(rezult);

			double valueX = MyFirstHomework.GetVariableOfTheEquation (7.1, -5.1, 40.1);
			Console.WriteLine(valueX);

			MyFirstHomework.GetEquationOfTheLine (1, -2.5, 15, 0);

			double rezult1 = MySecondHomework.GetSumOrDifferenceOrProductOfNumbers(-7.4, 0);
			Console.WriteLine(rezult1);

			MySecondHomework.GetQuarterCoordinatesPoint(0, 0);

			MySecondHomework.GetTwodigitNumberInWords(25);

			double number = MyThirdHomework.GetNumberOfDegree(-2.5, -3);
			Console.WriteLine(number);

			double numbers = MyThirdHomework.GetQuantityNumbersSmallerSquare(17);
			Console.WriteLine(numbers);

			MyThirdHomework.GetLargestDivisorOfNumber(-55);

			int sum = MyThirdHomework.GetSumNumbersDivisibleBy7(-15, 1);
			Console.WriteLine(sum);

			int numberFibonacci = MyThirdHomework.GetNumberFibonacciSeries(10);
			Console.WriteLine(numberFibonacci);

			int commonDivisor = MyThirdHomework.GetGreatestCommonDivisorNumbers(-8, -32);
			Console.WriteLine(commonDivisor);

			double number1 = MyThirdHomework.GetNumberMethodOfHalfDivision(10);
			Console.WriteLine(number1);

			long oddNumbers = MyThirdHomework.GetNumberOfOddDigits(-710518555);
			Console.WriteLine(oddNumbers);

			MyThirdHomework.GetMirrorNumber(-123456789);

			bool pitting = MyThirdHomework.GetAlignmentOfDigitsOfNumbers(-1234, -4217);
			Console.WriteLine(pitting);
			Console.ReadKey();
		}
	}
}
