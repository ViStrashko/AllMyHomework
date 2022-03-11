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

			string equation = MyFirstHomework.GetEquationOfTheLine (1, -2.5, 15, 0);
			Console.WriteLine(equation);

			double rezult1 = MySecondHomework.GetSumOrDifferenceOrProductOfNumbers(-7.4, 0);
			Console.WriteLine(rezult1);

			string quarters = MySecondHomework.GetQuarterCoordinatesPoint(0, 0);
			Console.WriteLine(quarters);

			string numberInWords = MySecondHomework.GetTwodigitNumberInWords(25);
			Console.WriteLine(numberInWords);

			string ascendingNumbers = MySecondHomework.GetAscendingNumbers(10.8, 0, -5);
			Console.WriteLine(ascendingNumbers);

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

			long[] reversNumber = MyThirdHomework.GetMirrorNumber(-11155577788555);

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
			Console.WriteLine(numbers1);

//Arrays in methods

			int[] randomArray = MyArray.GetRandomArray(10);
			int[] arrayConsecutiveNumbers = MyArray.GetArrayOfConsecutiveNumbers(21);
			int[] array = new int[] { -1, 2, -8, 5, -4, 5, 3, 8, 4, -7 };
			int[] copyArray = MyArray.CopyArray(array);
			                           
			int minValueArray = MyArray.GetMinimumElementOfTheArray(copyArray);
			Console.WriteLine(minValueArray);

			int maxValueArray = MyArray.GetMaximumElementOfTheArray(copyArray);
			Console.WriteLine(maxValueArray);

			int indexMinimumValueArray = MyArray.GetIndexMinimumElementOfTheArray(copyArray);
			Console.WriteLine(indexMinimumValueArray);

			int indexMaximumValueArray = MyArray.GetIndexMaximumElementOfTheArray(copyArray);
			Console.WriteLine(indexMaximumValueArray);

			int sumElementsOddIndex = MyArray.GetSumOfElementsOddIndexOfTheArray(copyArray);
			Console.WriteLine(sumElementsOddIndex);

			int[] arrayReverse = MyArray.GetArrayReverse(copyArray);

			int numberOfOddElements = MyArray.GetNumberOfOddArrayElements(copyArray);
			Console.WriteLine(numberOfOddElements);

			int[] arrayChange = MyArray.SwapTheHalvesOfTheArray(copyArray);

			int[] bubbleSort = MyArray.SortArrayByBubbleMethod(copyArray);

			int[] selectionSort = MyArray.SortArraySelectionMethod(copyArray);

			int[] numbersAreMultiplesA = MyArray.GetNumbersAreMultiplesA(-150);

			int[] numbersSumOfEvenDigitsGreater = MyArray.GetNumbersSumOfEvenDigitsGreater(50);

			double[] solutionOfTheEquation = MyArray.GetSolutionOfTheEquation(-2.1, 5.5, 3.1);

			double[] ascendingNumbers2 = MyArray.GetAscendingNumbers(-7.8, 1.5, -4);

			MyArray.CheckTheOperationOfTheMethod(numbersSumOfEvenDigitsGreater);

//Two-dimensional arrays

			int[,] randArray = TwoDimensionalArrays.GetRandomArray(5, 5);
			int[,] array2 = new int[,] { { -1, -8, 5, -2, 3 }, { 2, 0, 10, -3, 4 }, { 1, 1, 3, -2, -5 }, { -2, 3, 8, -7, 4 }, { -5, 1, 9, 4, -2 } };
			int[,] copy = TwoDimensionalArrays.CopyArray(array2);

			int minValueArray2 = TwoDimensionalArrays.GetMinimumElementOfTheArray(copy);
			Console.WriteLine(minValueArray2);

			int maxValueArray2 = TwoDimensionalArrays.GetMaximumElementOfTheArray(copy);
			Console.WriteLine(maxValueArray2);

			int minIndexI;
			int minIndexJ;
			TwoDimensionalArrays.GetIndexMinimumElementOfTheArray(copy, out minIndexI, out minIndexJ);
			Console.WriteLine(minIndexI);
			Console.WriteLine(minIndexJ);

			int maxIndexI;
			int maxIndexJ;
			TwoDimensionalArrays.GetIndexMaximumElementOfTheArray(copy, out maxIndexI, out maxIndexJ);
			Console.WriteLine(maxIndexI);
			Console.WriteLine(maxIndexJ);

			//int numberOfElements = TwoDimensionalArrays.GetNumberOfArrayElements(copy);

			TwoDimensionalArrays.CheckTheOperationOfTheMethod(copy);
			Console.ReadLine();
		}
	}
}
