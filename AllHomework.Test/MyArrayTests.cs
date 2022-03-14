using NUnit.Framework;
using System;

namespace AllHomework.Test
{
	[TestFixture]
	public class MyArrayTests
	{
		[TestCase(new int[] { -1, 2, -8, 5, -4, 0, 3, 8, 0, -7 }, -8)]
		[TestCase(new int[] { -9, 2, -1, 5, -4, 0, 3, 8, 0, -7 }, -9)]
		[TestCase(new int[] { -1, 2, -1, 5, -4, 0, 3, 8, 0, -7 }, -7)]
		[TestCase(new int[] { -1, 2 }, -1)]
		[TestCase(new int[] { 2 }, 2)]
		[TestCase(new int[] { 5, 5, 5 }, 5)]
		public void GetMinimumElementOfTheArrayTest(int[] numbers, int expected)
		{
			int actual = MyArray.GetMinimumElementOfTheArray(numbers);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(new int[] { })]
		public void GetMinimumElementOfTheArrayTest_WhenNumbersLengthIsNotEqualZero_ShuoldThrowException(int[] numbers)
		{
			Assert.Throws<ArgumentException>(() => MyArray.GetMinimumElementOfTheArray(numbers));
		}


		[TestCase(new int[] { -1, 2, -8, 5, -4, 0, 3, 8, 0, -7 }, 8)]
		[TestCase(new int[] { 9, 2, -1, 5, -4, 0, 3, 8, 0, -7 }, 9)]
		[TestCase(new int[] { -1, 2, -1, 5, -4, 0, 3, 8, 0, 17 }, 17)]
		[TestCase(new int[] { -1, 2 }, 2)]
		[TestCase(new int[] { 2 }, 2)]
		[TestCase(new int[] { 5, 5, 5 }, 5)]
		public void GetMaximumElementOfTheArrayTest(int[] numbers, int expected)
		{
			int actual = MyArray.GetMaximumElementOfTheArray(numbers);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(new int[] { })]
		public void GetMaximumElementOfTheArrayTest_WhenNumbersLengthIsNotEqualZero_ShuoldThrowException(int[] numbers)
		{
			Assert.Throws<ArgumentException>(() => MyArray.GetMaximumElementOfTheArray(numbers));
		}


		[TestCase(new int[] { -1, 2, -8, 5, -4, 0, 3, 8, 0, -7 }, 2)]
		[TestCase(new int[] { -9, 2, -1, 5, -4, 0, 3, 8, 0, -7 }, 0)]
		[TestCase(new int[] { -1, 2, -1, 5, -4, 0, 3, 8, 0, -7 }, 9)]
		[TestCase(new int[] { -1, 2 }, 0)]
		[TestCase(new int[] { 2 }, 0)]
		[TestCase(new int[] { 5, 5, 5 }, 0)]
		public void GetIndexMinimumElementOfTheArrayTest(int[] numbers, int expected)
		{
			int actual = MyArray.GetIndexMinimumElementOfTheArray(numbers);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(new int[] { })]
		public void GetIndexMinimumElementOfTheArrayTest_WhenNumbersLengthIsNotEqualZero_ShuoldThrowException(int[] numbers)
		{
			Assert.Throws<ArgumentException>(() => MyArray.GetIndexMinimumElementOfTheArray(numbers));
		}


		[TestCase(new int[] { -1, 2, -8, 5, -4, 0, 3, 8, 0, -7 }, 7)]
		[TestCase(new int[] { 9, 2, -1, 5, -4, 0, 3, 8, 0, -7 }, 0)]
		[TestCase(new int[] { -1, 2, -1, 5, -4, 0, 3, 8, 0, 17 }, 9)]
		[TestCase(new int[] { -1, 2 }, 1)]
		[TestCase(new int[] { 2 }, 0)]
		[TestCase(new int[] { 5, 5, 5 }, 0)]
		public void GetIndexMaximumElementOfTheArrayTest(int[] numbers, int expected)
		{
			int actual = MyArray.GetIndexMaximumElementOfTheArray(numbers);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(new int[] { })]
		public void GetIndexMaximumElementOfTheArrayTest_WhenNumbersLengthIsNotEqualZero_ShuoldThrowException(int[] numbers)
		{
			Assert.Throws<ArgumentException>(() => MyArray.GetIndexMaximumElementOfTheArray(numbers));
		}


		[TestCase(new int[] { -1, 2, -8, 5, -4, 0, 3, 8, 0, -7 }, 8)]
		[TestCase(new int[] { 9, 2, -1, 5, -4, 0, 3, 8, 0, 7 }, 22)]
		[TestCase(new int[] { -1, 2, -1, 5, -4, 0, 3, 8, 0, 17 }, 32)]
		[TestCase(new int[] { -1, 2 }, 2)]
		[TestCase(new int[] { 2 }, 0)]
		[TestCase(new int[] { 5, 5, 5 }, 5)]
		[TestCase(new int[] { }, 0)]
		public void GetSumOfElementsOddIndexOfTheArrayTest(int[] numbers, int expected)
		{
			int actual = MyArray.GetSumOfElementsOddIndexOfTheArray(numbers);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(new int[] { -1, 2, -3, 4, -5 }, new int[] { -5, 4, -3, 2, -1 })]
		[TestCase(new int[] { 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5 })]
		[TestCase(new int[] { -1, 2 }, new int[] { 2, -1 })]
		[TestCase(new int[] { 2 }, new int[] { 2 })]
		[TestCase(new int[] { }, new int[] { })]
		public void GetArrayReverseTest(int[] numbers, int[] expected)
		{
			int[] actual = MyArray.GetArrayReverse(numbers);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(new int[] { -1, 2, -8, 5, -4, 0, 3, 8, 0, -7 }, 4)]
		[TestCase(new int[] { 9, 2, -1, 5, 9, 0 }, 4)]
		[TestCase(new int[] { -1, 2, -1, 5 }, 3)]
		[TestCase(new int[] { -1, 2 }, 1)]
		[TestCase(new int[] { 2 }, 0)]
		[TestCase(new int[] { 5, 5, 5 }, 3)]
		[TestCase(new int[] { }, 0)]
		public void GetNumberOfOddArrayElementsTest(int[] numbers, int expected)
		{
			int actual = MyArray.GetNumberOfOddArrayElements(numbers);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(new int[] { -1, 2, -3, 4, -5 }, new int[] { 4, -5, -3, -1, 2 })]
		[TestCase(new int[] { 1, 1, 5, 5 }, new int[] { 5, 5, 1, 1 })]
		[TestCase(new int[] { -1, 2 }, new int[] { 2, -1 })]
		[TestCase(new int[] { 2 }, new int[] { 2 })]
		[TestCase(new int[] { }, new int[] { })]
		public void SwapTheHalvesOfTheArrayTest(int[] numbers, int[] expected)
		{
			int[] actual = MyArray.SwapTheHalvesOfTheArray(numbers);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(new int[] { -1, 2, -3, 4, -5 }, new int[] { -5, -3, -1, 2, 4 })]
		[TestCase(new int[] { 5, 1, 5, 1 }, new int[] { 1, 1, 5, 5 })]
		[TestCase(new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 })]
		[TestCase(new int[] { 3, -2 }, new int[] { -2, 3 })]
		[TestCase(new int[] { 2 }, new int[] { 2 })]
		[TestCase(new int[] { }, new int[] { })]
		public void SortArrayByBubbleMethodTest(int[] numbers, int[] expected)
		{
			int[] actual = MyArray.SortArrayByBubbleMethod(numbers);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(new int[] { -1, 2, -3, 4, -5 }, new int[] { 4, 2, -1, -3, -5 })]
		[TestCase(new int[] { 5, 1, 5, 1 }, new int[] { 5, 5, 1, 1 })]
		[TestCase(new int[] { 5, 5, 5 }, new int[] { 5, 5, 5 })]
		[TestCase(new int[] { -2, 3 }, new int[] { 3, -2 })]
		[TestCase(new int[] { 2 }, new int[] { 2 })]
		[TestCase(new int[] { }, new int[] { })]
		public void SortArraySelectionMethodTest(int[] numbers, int[] expected)
		{
			int[] actual = MyArray.SortArraySelectionMethod(numbers);
			Assert.AreEqual(expected, actual);
		}
	}
}
