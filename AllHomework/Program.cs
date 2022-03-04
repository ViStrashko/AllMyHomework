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

			int rezult1 = MySecondHomework.GetSumOrDifferenceOrProductOfNumbers(7, 4);
			Console.WriteLine(rezult1);

			MySecondHomework.GetQuarterCoordinatesPoint(-1, 8);

			MySecondHomework.GetTwodigitNumberInWords(55);

			int number = MyThirdHomework.GetNumberOfDegree(5, 3);
			Console.WriteLine(number);

			int numbers = MyThirdHomework.GetQuantityNumbersSmallerSquare(5);
			Console.WriteLine(numbers);

			MyThirdHomework.GetLargestDivisorOfNumber(55);

			int sum = MyThirdHomework.GetSumNumbersDivisibleBy7(15, 1);
			Console.WriteLine(sum);

			int numberFibonacci = MyThirdHomework.GetNumberFibonacciSeries(9);
			Console.WriteLine(numberFibonacci);

			int commonDivisor = MyThirdHomework.GetGreatestCommonDivisorNumbers(8, 32);
			Console.WriteLine(commonDivisor);

			double number1 = MyThirdHomework.GetNumberMethodOfHalfDivision(10);
			Console.WriteLine(number1);

			long oddNumbers = MyThirdHomework.GetNumberOfOddDigits(1051651648555);
			Console.WriteLine(oddNumbers);

			MyThirdHomework.GetMirrorNumber(123456789);

			bool pitting = MyThirdHomework.GetAlignmentOfDigitsOfNumbers(1111, 555);
			Console.WriteLine(pitting);
			Console.ReadKey();
		}
	}
}
