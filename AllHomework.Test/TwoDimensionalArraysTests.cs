using NUnit.Framework;
using System;

namespace AllHomework.Test
{
	[TestFixture]
	public class TwoDimensionalArraysTests
	{
		[TestCase(Enums.TDAMockType.twoByTwo, 1)]
		[TestCase(Enums.TDAMockType.threeByThree, -11)]
		[TestCase(Enums.TDAMockType.fourByFour, -55)]
		[TestCase(Enums.TDAMockType.oneElement, 5)]
		public void GetMinimumElementOfTheArrayTest(Enums.TDAMockType type, int expected)
		{
		    int[,] array = TwoDimensionalArraysMock.GetMock(type); 
			int actual = TwoDimensionalArrays.GetMinimumElementOfTheArray(array);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(Enums.TDAMockType.empty)]
		public void GetMinimumElementOfTheArrayTest_WhenArrayLengthIsNotEqualZero_ShuoldThrowException(Enums.TDAMockType type)
		{
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			Assert.Throws<ArgumentException>(() => TwoDimensionalArrays.GetMinimumElementOfTheArray(array));
		}


		[TestCase(Enums.TDAMockType.twoByTwo, 21)]
		[TestCase(Enums.TDAMockType.threeByThree, 20)]
		[TestCase(Enums.TDAMockType.fourByFour, 15)]
		[TestCase(Enums.TDAMockType.oneElement, 5)]
		public void GetMaximumElementOfTheArrayTest(Enums.TDAMockType type, int expected)
		{
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			int actual = TwoDimensionalArrays.GetMaximumElementOfTheArray(array);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(Enums.TDAMockType.empty)]
		public void GetMaximumElementOfTheArrayTest_WhenArrayLengthIsNotEqualZero_ShuoldThrowException(Enums.TDAMockType type)
		{
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			Assert.Throws<ArgumentException>(() => TwoDimensionalArrays.GetMaximumElementOfTheArray(array));
		}


		[TestCase(Enums.TDAMockType.twoByTwo, 1, 0)]
		[TestCase(Enums.TDAMockType.threeByThree, 1, 2)]
		[TestCase(Enums.TDAMockType.fourByFour, 3, 1)]
		[TestCase(Enums.TDAMockType.oneElement, 0, 0)]
		public void GetIndexMinimumElementOfTheArrayTest(Enums.TDAMockType type, int expectedIndexI, int expectedIndexJ)
		{
			int actualIndexI;
			int actualIndexJ;
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			TwoDimensionalArrays.GetIndexMinimumElementOfTheArray(array, out actualIndexI, out actualIndexJ);
			Assert.AreEqual(expectedIndexI, actualIndexI);
			Assert.AreEqual(expectedIndexJ, actualIndexJ);
		}
		[TestCase(Enums.TDAMockType.empty)]
		public void GetIndexMinimumElementOfTheArrayTest_WhenArrayLengthIsNotEqualZero_ShuoldThrowException(Enums.TDAMockType type)
		{
			int actualIndexI;
			int actualIndexJ;
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			Assert.Throws<ArgumentException>(() => TwoDimensionalArrays.GetIndexMinimumElementOfTheArray(array, out actualIndexI, out actualIndexJ));
		}


		[TestCase(Enums.TDAMockType.twoByTwo, 1, 1)]
		[TestCase(Enums.TDAMockType.threeByThree, 2, 2)]
		[TestCase(Enums.TDAMockType.fourByFour, 1, 2)]
		[TestCase(Enums.TDAMockType.oneElement, 0, 0)]
		public void GetIndexMaximumElementOfTheArrayTest(Enums.TDAMockType type, int expectedIndexI, int expectedIndexJ)
		{
			int actualIndexI;
			int actualIndexJ;
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			TwoDimensionalArrays.GetIndexMaximumElementOfTheArray(array, out actualIndexI, out actualIndexJ);
			Assert.AreEqual(expectedIndexI, actualIndexI);
			Assert.AreEqual(expectedIndexJ, actualIndexJ);
		}
		[TestCase(Enums.TDAMockType.empty)]
		public void GetIndexMaximumElementOfTheArrayTest_WhenArrayLengthIsNotEqualZero_ShuoldThrowException(Enums.TDAMockType type)
		{
			int actualIndexI;
			int actualIndexJ;
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			Assert.Throws<ArgumentException>(() => TwoDimensionalArrays.GetIndexMaximumElementOfTheArray(array, out actualIndexI, out actualIndexJ));
		}


		[TestCase(Enums.TDAMockType.twoByTwo, 1)]
		[TestCase(Enums.TDAMockType.threeByThree, 3)]
		[TestCase(Enums.TDAMockType.fourByFour, 6)]
		[TestCase(Enums.TDAMockType.oneElement, 1)]
		[TestCase(Enums.TDAMockType.empty, 0)]
		public void CountElementsHigherThanNeiborTest(Enums.TDAMockType type, int expected)
		{
			int[,] array = TwoDimensionalArraysMock.GetMock(type);
			int actual = TwoDimensionalArrays.CountElementsHigherThanNeibor(array);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(Enums.TDAMockType.twoByTwo, Enums.TDAMockType.twoByTwoReverse)]
		[TestCase(Enums.TDAMockType.threeByThree, Enums.TDAMockType.threeByThreeReverse)]
		[TestCase(Enums.TDAMockType.fourByFour, Enums.TDAMockType.fourByFourReverse)]
		[TestCase(Enums.TDAMockType.oneElement, Enums.TDAMockType.oneElementReverse)]
		[TestCase(Enums.TDAMockType.empty, Enums.TDAMockType.empty)]
		public void ReflectTheArrayRelativeToItsMainDiagonalTest(Enums.TDAMockType actualType, Enums.TDAMockType expectedType)
		{
			int[,] array = TwoDimensionalArraysMock.GetMock(actualType);
			int[,] expected = TwoDimensionalArraysMock.GetMock(expectedType);
			int[,] actual = TwoDimensionalArrays.ReflectTheArrayRelativeToItsMainDiagonal(array);
			Assert.AreEqual(expected, actual);
		}
	}
}
