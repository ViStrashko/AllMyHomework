using System;
using AllHomework;

namespace AllHomework
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			double rezult = MyFirstHomework.GetResultOfTheEquation(-7, 4);
			Console.WriteLine(rezult);

			double valueX = MyFirstHomework.GetVariableOfTheEquation (7.1, -5.1, 40.1);
			Console.WriteLine(valueX);

			string equation = MyFirstHomework.GetEquationOfTheLine (7.5, -2, 0, 4.1);
			Console.WriteLine(equation);

			double rezult1 = MySecondHomework.GetSumOrDifferenceOrProductOfNumbers(-7.4, 0);
			Console.WriteLine(rezult1);

			string quarters = MySecondHomework.GetQuarterCoordinatesPoint(0, 0);
			Console.WriteLine(quarters);

			string numberInWords = MySecondHomework.GetTwodigitNumberInWords(25);
			Console.WriteLine(numberInWords);

			double number = MyThirdHomework.GetNumberOfDegree(-2.5, -3);
			Console.WriteLine(number);

			double numberOfNumbers = MyThirdHomework.GetQuantityNumbersSmallerSquare(17.5);
			Console.WriteLine(numberOfNumbers);

			int divisorOfNumber = MyThirdHomework.GetLargestDivisorOfNumber(-55);
			Console.WriteLine(divisorOfNumber);
			       
			int sum = MyThirdHomework.GetSumNumbersDivisibleBySeven(0, -10);
			Console.WriteLine(sum);

			int numberFibonacci = MyThirdHomework.GetNumberFibonacciSeries(10);
			Console.WriteLine(numberFibonacci);

			int commonDivisor = MyThirdHomework.GetGreatestCommonDivisorNumbers(-8, -32);
			Console.WriteLine(commonDivisor);

			double number1 = MyThirdHomework.GetNumberMethodOfHalfDivision(10);
			Console.WriteLine(number1);

			long oddNumbers = MyThirdHomework.GetNumberOfOddDigits(-710518555);
			Console.WriteLine(oddNumbers);

			string reversNumber = MyThirdHomework.GetMirrorNumber(-111555);
			Console.WriteLine(reversNumber);

			bool pitting = MyThirdHomework.GetAlignmentOfDigitsOfNumbers(-1234, -4217);
			Console.WriteLine(pitting);

//Methods with two conclusions

			int rezultDividing;
			int remainsDividing;
			MyFirstHomework.GetDividingNumbersEndRemainderOfTheDivision(9, 2, out rezultDividing, out remainsDividing);
			Console.WriteLine(rezultDividing);
			Console.WriteLine(remainsDividing);

			string stringA = "Hello";
			string stringB = "Goodbye";
			MyFirstHomework.GetReplacingContent(ref stringA, ref stringB);
			Console.WriteLine(stringA);
			Console.WriteLine(stringB);

			double[] ascendingNumbers = MySecondHomework.GetAscendingNumbers(10.8, 0, -5);

			double[] solutionOfTheEquation;
			string rezultOfTheEquation;
			MySecondHomework.GetSolutionOfTheEquation(-2.1, 5.5, -3.1, out solutionOfTheEquation, out rezultOfTheEquation);
			Console.WriteLine(rezultOfTheEquation);

			int[] numbersAreMultiplesA = MyThirdHomework.GetNumbersAreMultiplesA(-150);

			int[] numbersSumOfEvenDigitsGreater = MyThirdHomework.GetNumbersSumOfEvenDigitsGreater(50);

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

			MyArray.CheckTheOperationOfTheMethod(arrayChange);

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

			int countOfElements = TwoDimensionalArrays.CountElementsHigherThanNeibor(copy);
			Console.WriteLine(countOfElements);

			int[,] reflectTheArray = TwoDimensionalArrays.ReflectTheArrayRelativeToItsMainDiagonal(copy);

			TwoDimensionalArrays.CheckTheOperationOfTheMethod(reflectTheArray);
			Console.ReadLine();
		}
	}
}
