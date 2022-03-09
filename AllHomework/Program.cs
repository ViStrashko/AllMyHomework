﻿using System;
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

			MySecondHomework.GetAscendingNumbers(10.8, 0, -5);

			double number = MyThirdHomework.GetNumberOfDegree(-2.5, -3);
			Console.WriteLine(number);

			double numberOfNumbers = MyThirdHomework.GetQuantityNumbersSmallerSquare(17.5);
			Console.WriteLine(numberOfNumbers);

			int divisorOfNumber = MyThirdHomework.GetLargestDivisorOfNumber(-55);
			Console.WriteLine(divisorOfNumber);
			       
			int sum = MyThirdHomework.GetSumNumbersDivisibleBy7(0, -10);
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

//Methods with two conclusions

			double rezultDividing;
			double remainsDividing;
			MyFirstHomework.GetDividingNumbersEndRemainderOfTheDivision(9, 2, out rezultDividing, out remainsDividing);
			Console.WriteLine(rezultDividing);
			Console.WriteLine(remainsDividing);

			string stringA = "Hello";
			string stringB = "Goodbye";
			MyFirstHomework.GetReplacingContent(ref stringA, ref stringB);
			Console.WriteLine(stringA);
			Console.WriteLine(stringB);

			double x1;
			double x2;
			MySecondHomework.GetSolutionOfTheEquation(-5.5, 0.1, 12, out x1, out x2);
			Console.WriteLine(x1);
			Console.WriteLine(x2);

			double numbersAreMultiples;
			MyThirdHomework.GetNumbersAreMultiplesA(-150.5, out numbersAreMultiples);

			int numbers1;
			MyThirdHomework.GetNumbersSumOfEvenDigitsGreater(50, out numbers1);

//Arrays in methods

			int[] randomArray = MyArray.GetRandomArray(10);
			int[] arrayConsecutiveNumbers = MyArray.GetArrayOfConsecutiveNumbers(21);
			int[] array = new int[] { -1, 2, -8, 5, -4, 5, 3, 8, 4, -7 };
			                           
			int minValueArray = MyArray.GetMinimumElementOfTheArray(randomArray);
			Console.WriteLine(minValueArray);

			int maxValueArray = MyArray.GetMaximumElementOfTheArray(randomArray);
			Console.WriteLine(maxValueArray);

			int indexMinimumValueArray = MyArray.GetIndexMinimumElementOfTheArray(randomArray);
			Console.WriteLine(indexMinimumValueArray);

			int indexMaximumValueArray = MyArray.GetIndexMaximumElementOfTheArray(randomArray);
			Console.WriteLine(indexMaximumValueArray);

			int sumElementsOddIndex = MyArray.GetSumOfElementsOddIndexOfTheArray(array);
			Console.WriteLine(sumElementsOddIndex);

			int[] arrayReverse = MyArray.GetArrayReverse(arrayConsecutiveNumbers);

			int numberOddElements = MyArray.GetNumberOfOddArrayElements(array);
			Console.WriteLine(numberOddElements);

			int[] arrayChange = MyArray.SwapTheHalvesOfTheArray(arrayConsecutiveNumbers);

			int[] bubbleSort = MyArray.SortArrayByBubbleMethod(array);

			int[] selectionSort = MyArray.SortArraySelectionMethod(array);

			MyArray.CheckTheOperationOfTheMethod(selectionSort);
			Console.ReadLine();
		}
	}
}
