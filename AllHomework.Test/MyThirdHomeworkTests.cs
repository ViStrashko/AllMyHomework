using NUnit.Framework;
using System;

namespace AllHomework.Test
{
	[TestFixture]
	public class MyThirdHomeworkTests
	{
		[TestCase(2, 3, 8)]
		[TestCase(-2, 3, -8)]
		[TestCase(2.5, 2, 6.25)]
		[TestCase(-2.5, 2, 6.25)]

		[TestCase(2, -3, 0.125)]
		[TestCase(-2, -3, -0.125)]
		[TestCase(2.5, -2, 0.16)]
		[TestCase(-2.5, -2, 0.16)]

		[TestCase(2, 0, 1)]
		[TestCase(-2, 0, 1)]
		[TestCase(2.5, 0, 1)]
		[TestCase(-2.5, 0, 1)]
		public void GetNumberOfDegreeTest(double valueA, double valueB, double expected)
		{
			double actual = MyThirdHomework.GetNumberOfDegree(valueA, valueB);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(2, 1.5)]
		[TestCase(-2, -1.5)]
		[TestCase(2.5, 1.5)]
		[TestCase(-2.5, -1.5)]
		[TestCase(0, 1.5)]
		[TestCase(0, -1.5)]
		public void GetNumberOfDegreeTest_WhenValueBIsNotFractional_ShuoldThrowException(double valueA, double valueB)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetNumberOfDegree(valueA, valueB));
		}
		[TestCase(0, 5)]
		[TestCase(0, 0)]
		[TestCase(0, -5)]
		public void GetNumberOfDegreeTest_WhenValueAIsNotEqualToZero_ShuoldThrowException(double valueA, double valueB)
		{
			Assert.Throws<DivideByZeroException>(() => MyThirdHomework.GetNumberOfDegree(valueA, valueB));
		}


		[TestCase(1, 0)]
		[TestCase(9, 2)]
		[TestCase(10, 3)]
		[TestCase(15.5, 3)]
		public void GetQuantityNumbersSmallerSquareTest(double valueA, double expected)
		{
			double actual = MyThirdHomework.GetQuantityNumbersSmallerSquare(valueA);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0)]
		[TestCase(-1)]
		[TestCase(-1.5)]
		public void GetQuantityNumbersSmallerSquareTest_WhenValueAIsPositiveInteger_ShuoldThrowException(double valueA)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetQuantityNumbersSmallerSquare(valueA));
		}


		[TestCase(5, 1)]
		[TestCase(8, 4)]
		[TestCase(-5, 1)]
		[TestCase(-8, 4)]
		public void GetLargestDivisorOfNumberTest(double valueA, int expected)
		{
			int actual = MyThirdHomework.GetLargestDivisorOfNumber(valueA);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0)]
		[TestCase(5.5)]
		[TestCase(-1.5)]
		public void GetLargestDivisorOfNumberTest_WhenValueAIsIntegerAndNotEqualToZero_ShuoldThrowException(double valueA)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetLargestDivisorOfNumber(valueA));
		}


		[TestCase(0, 15, 21)]
		[TestCase(0, -15, -21)]
		[TestCase(8, -18, -14)]
		public void GetSumNumbersDivisibleBySevenTest(double valueA, double valueB, int expected)
		{
			int actual = MyThirdHomework.GetSumNumbersDivisibleBySeven(valueA, valueB);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(1.5, 8.5)]
		[TestCase(-1.5, -8.5)]
		public void GetSumNumbersDivisibleBySevenTest_WhenValueAAndValueBIsNotFractional_ShuoldThrowException(double valueA, double valueB)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetSumNumbersDivisibleBySeven(valueA, valueB));
		}


		[TestCase(1, 1)]
		[TestCase(2, 1)]
		[TestCase(3, 2)]
		[TestCase(7, 13)]
		public void GetNumberFibonacciSeriesTest(double valueN, int expected)
		{
			int actual = MyThirdHomework.GetNumberFibonacciSeries(valueN);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0)]
		[TestCase(1.5)]
		[TestCase(-1)]
		public void GetNumberFibonacciSeriesTest_WhenValueNIsNotFractionalAndIsGreaterThanZero_ShuoldThrowException(double valueN)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetNumberFibonacciSeries(valueN));
		}


		[TestCase(25, 30, 5)]
		[TestCase(-45, -15, 15)]
		public void GetGreatestCommonDivisorNumbersTest(double valueA, double valueB, int expected)
		{
			int actual = MyThirdHomework.GetGreatestCommonDivisorNumbers(valueA, valueB);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0, 0)]
		[TestCase(5.5, 20.5)]
		[TestCase(-5.5, -20.5)]
		public void GetGreatestCommonDivisorNumbersTest_WhenValueAAndValueBIsNotEqualZeroAndInteger_ShuoldThrowException(double valueA, double valueB)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetGreatestCommonDivisorNumbers(valueA, valueB));
		}


		[TestCase(8, 2)]
		[TestCase(15, 2.4609375)]
		public void GetNumberMethodOfHalfDivisionTest(double number, double expected)
		{
			double actual = MyThirdHomework.GetNumberMethodOfHalfDivision(number);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0)]
		[TestCase(9.8)]
		[TestCase(-8)]
		public void GetNumberMethodOfHalfDivisionTest_WhenNumberIsGreaterThanZeroAndInteger_ShuoldThrowException(double number)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetNumberMethodOfHalfDivision(number));
		}


		[TestCase(10, 1)]
		[TestCase(124407865, 3)]
		[TestCase(-3504087132, 5)]
		[TestCase(0, 0)]
		public void GetNumberOfOddDigitsTest(double number, long expected)
		{
			long actual = MyThirdHomework.GetNumberOfOddDigits(number);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(5.5)]
		[TestCase(-5.5)]
		public void GetNumberOfOddDigitsTest_WhenNumberIsInteger_ShuoldThrowException(double number)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetNumberOfOddDigits(number));
		}


		[TestCase(0, "0")]
		[TestCase(12345, "54321")]
		[TestCase(-12345, "-54321")]
		public void GetMirrorNumberTest(double number, string expected)
		{
			string actual = MyThirdHomework.GetMirrorNumber(number);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(5.5)]
		[TestCase(-5.5)]
		public void GetMirrorNumberTest_WhenNumberIsInteger_ShuoldThrowException(double number)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetMirrorNumber(number));
		}


		[TestCase(5038, 10, true)]
		[TestCase(5038, -3, true)]
		[TestCase(51358, 5, true)]
		[TestCase(51358, 53, true)]
		[TestCase(-51358, -563, true)]
		public void GetAlignmentOfDigitsOfNumbersTest(double number1, double number2, bool expected)
		{
			bool actual = MyThirdHomework.GetAlignmentOfDigitsOfNumbers(number1, number2);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0, 0)]
		[TestCase(50, 0)]
		[TestCase(0, -50)]
		[TestCase(5.5, 15.8)]
		public void GetAlignmentOfDigitsOfNumbersTest_WhenNumber1AndNumber2IsIntegerAndIsNotEquelZero_ShuoldThrowException(double number1, double number2)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetAlignmentOfDigitsOfNumbers(number1, number2));
		}


		[TestCase(-100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900 })]
		[TestCase(300, new int[] { 300, 600, 900 })]
		public void GetNumbersAreMultiplesATest(double valueA, int[] expected)
		{
			int[] actual = MyThirdHomework.GetNumbersAreMultiplesA(valueA);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0)]
		[TestCase(100.5)]
		[TestCase(-50.5)]
		public void GetNumbersAreMultiplesATest_WhenValueAIsIntegerAndIsNotEquelZero_ShuoldThrowException(double valueA)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetNumbersAreMultiplesA(valueA));
		}

		[TestCase(8, new int[] { 2, 4, 6, 8 })]
		[TestCase(25, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24 })]
		public void GetNumbersSumOfEvenDigitsGreaterTest(double valueN, int[] expected)
		{
			int[] actual = MyThirdHomework.GetNumbersSumOfEvenDigitsGreater(valueN);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0)]
		[TestCase(100.5)]
		[TestCase(-14)]
		[TestCase(-50.5)]
		public void GetNumbersAreMultiplesATest_WhenValueNIsIntegerAndIsNotEquelZero_ShuoldThrowException(double valueN)
		{
			Assert.Throws<ArgumentException>(() => MyThirdHomework.GetNumbersSumOfEvenDigitsGreater(valueN));
		}
	}
}
