using NUnit.Framework;
using System;

namespace AllHomework.Test
{
	[TestFixture]
	public class MyFirstHomeworkTests
	{
		[TestCase(1, 2, 9)]
		[TestCase(-1, -2, 1)]
		[TestCase(1, -2, -3)]
		[TestCase(-1, 2, -0.33333333333333331)]
		[TestCase(0, 2, 2)]
		[TestCase(0, -2, -2)]
		[TestCase(1, 0, -5)]
		[TestCase(-1, 0, -5)]
		[TestCase(1.5, 2.5, 13.75)]
		[TestCase(-1.5, -2.5, 1.25)]
		[TestCase(1.5, -2.5, -3.4375)]
		[TestCase(-1.5, 2.5, -0.3125)]
		[TestCase(0, 2.5, 2.5)]
		[TestCase(0, -2.5, -2.5)]
		[TestCase(1.5, 0, -5)]
		[TestCase(-1.5, 0, -5)]
		[TestCase(1, 2.5, 7.5)]
		[TestCase(1, -2.5, -3.2142857142857144)]
		[TestCase(-1, 2.5, 0.35714285714285715)]
		[TestCase(-1, -2.5, -0.83333333333333337)]
		[TestCase(1.5, 2, 23)]
		[TestCase(-1.5, 2, -1)]
		[TestCase(1.5, -2, -3.2857142857142856)]
		[TestCase(-1.5, -2, 7)]
		public void GetResultOfTheEquationTest(double valueA, double valueB, double expected)
		{
			double actual = MyFirstHomework.GetResultOfTheEquation(valueA, valueB);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(5, 5)]
		[TestCase(7.1, 7.1)]
		[TestCase(0, 0)]
		[TestCase(-5, -5)]
		[TestCase(-7.1, -7.1)]
		public void GetResultOfTheEquationTest_WhenValueAIsNotEqualVaueB_ShuoldThrowException(double valueA, double valueB)
		{
			Assert.Throws<Exception>(() => MyFirstHomework.GetResultOfTheEquation(valueA, valueB));
		}


		[TestCase(5, 5, 5, 0)]
		[TestCase(-5, 5, 5, 0)]
		[TestCase(5, -5, 5, 2)]
		[TestCase(5, 5, -5, -2)]
		[TestCase(-5, -5, 5, -2)]
		[TestCase(-5, 5, -5, 2)]
		[TestCase(5, -5, -5, 0)]
		[TestCase(-5, -5, -5, 0)]
		[TestCase(5.5, 5.5, 5.5, 0)]
		[TestCase(-5.5, 5.5, 5.5, 0)]
		[TestCase(5.5, -5.5, 5.5, 2)]
		[TestCase(5.5, 5.5, -5.5, -2)]
		[TestCase(-5.5, -5.5, 5.5, -2)]
		[TestCase(-5.5, 5.5, -5.5, 2)]
		[TestCase(5.5, -5.5, -5.5, 0)]
		[TestCase(-5.5, -5.5, -5.5, 0)]
		[TestCase(5, 0, 5, 1)]
		[TestCase(5, 5, 0, -1)]
		[TestCase(5, 0, 0, 0)]
		[TestCase(-5, 0, -5, 1)]
		[TestCase(-5, -5, 0, -1)]
		[TestCase(-5, 0, 0, 0)]
		[TestCase(5.5, 0, 5.5, 1)]
		[TestCase(5.5, 5.5, 0, -1)]
		[TestCase(5.5, 0, 0, 0)]
		[TestCase(-5.5, 0, -5.5, 1)]
		[TestCase(-5.5, -5.5, 0, -1)]
		[TestCase(-5.5, 0, 0, 0)]
		public void GetVariableOfTheEquationTest(double valueA, double valueB, double valueC, double expected)
		{
			double actual = MyFirstHomework.GetVariableOfTheEquation(valueA, valueB, valueC);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(0, 5, 5)]
		[TestCase(0, 0, 5)]
		[TestCase(0, 5, 0)]
		[TestCase(0, -5, -5)]
		[TestCase(0, 0, -5)]
		[TestCase(0, -5, 0)]
		[TestCase(0, 5.5, 5.5)]
		[TestCase(0, 0, 5.5)]
		[TestCase(0, 5.5, 0)]
		[TestCase(0, -5.5, -5.5)]
		[TestCase(0, 0, -5.5)]
		[TestCase(0, -5.5, 0)]
		public void GetVariableOfTheEquationTest_WhenValueAIsNotZero_ShuoldThrowException(double valueA, double valueB, double valueC)
		{
			Assert.Throws<Exception>(() => MyFirstHomework.GetVariableOfTheEquation(valueA, valueB, valueC));
		}


		[TestCase(1, 2, 3, 4, "Уравнение прямой: Y=1*X+2")]
		[TestCase(-1, -2, -3, -4, "Уравнение прямой: Y=1*X+-2")]
		[TestCase(1.5, 2.5, 3.5, 4.5, "Уравнение прямой: Y=1*X+2")]
		[TestCase(-1.5, -2.5, -3.5, -4.5, "Уравнение прямой: Y=1*X+-2")]
		[TestCase(0, 2, 3, 4, "Уравнение прямой: Y=0,5*X+3")]
		[TestCase(1, 2, 0, 0, "Уравнение прямой: Y=0*X+0")]
		[TestCase(1, 0, 0, 0, "Уравнение прямой: Y=0*X+0")]
		[TestCase(0, 2.5, 3.5, 4.5, "Уравнение прямой: Y=0,4*X+3,5")]
		[TestCase(1.5, 2.5, 0, 0, "Уравнение прямой: Y=0*X+0")]
		[TestCase(1.5, 0, 0, 0, "Уравнение прямой: Y=0*X+0")]
		public void GetEquationOfTheLineTest(double coordinateX1, double coordinateX2, double coordinateY1, double coordinateY2, string expected)
		{
			string actual = MyFirstHomework.GetEquationOfTheLine(coordinateX1, coordinateX2, coordinateY1, coordinateY2);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(1, 1, 1, 1)]
		[TestCase(1, 1, 3, 4)]
		[TestCase(-2, -2, -2, -2)]
		[TestCase(-2, -2, -3, -4)]
		[TestCase(1.5, 1.5, 1.5, 1.5)]
		[TestCase(1.5, 1.5, 3.5, 4.5)]
		[TestCase(-2.5, -2.5, -2.5, -2.5)]
		[TestCase(-2.5, -2.5, -3.5, -4.5)]
		[TestCase(0, 0, 3, 4)]
		[TestCase(0, 0, 0, 4)]
		[TestCase(0, 0, 0, 0)]
		[TestCase(0, 0, 3.5, 4.5)]
		[TestCase(0, 0, 0, 4.5)]
		public void GetEquationOfTheLineTest_WhenCoordinateX1IsNotEqualCoordinateX2_ShuoldThrowException(double coordinateX1, double coordinateX2, double coordinateY1, double coordinateY2)
		{
			Assert.Throws<Exception>(() => MyFirstHomework.GetEquationOfTheLine(coordinateX1, coordinateX2, coordinateY1, coordinateY2));
		}


		[TestCase(9, 2, 4, 1)]
		[TestCase(-9, -2, 4, -1)]
		[TestCase(-9, 2, -4, -1)]
		[TestCase(9, -2, -4, 1)]
		[TestCase(0, 2, 0, 0)]
		[TestCase(0, -2, 0, 0)]
		public void GetDividingNumbersEndRemainderOfTheDivisionTest(int valueA, int valueB, int expectedRezultDividing, int expectedRemainsDividing)
		{
			int actualRezultDividing;
			int actualRemainsDividing;
			MyFirstHomework.GetDividingNumbersEndRemainderOfTheDivision(valueA, valueB, out actualRezultDividing, out actualRemainsDividing);
			Assert.AreEqual(expectedRezultDividing, actualRezultDividing);
			Assert.AreEqual(expectedRemainsDividing, actualRemainsDividing);
		}
		[TestCase(9, 0)]
		[TestCase(0, 0)]
		[TestCase(-9, 0)]
		public void GetDividingNumbersEndRemainderOfTheDivisionTest_ValueBIsNotZero_ShuoldThrowException(int valueA, int valueB)
		{
			int rezultDividing;
			int remainsDividing;
			Assert.Throws<Exception>(() => MyFirstHomework.GetDividingNumbersEndRemainderOfTheDivision(valueA, valueB, out rezultDividing, out remainsDividing));
		}


		[TestCase("Hello", "Goodbye", "Goodbye", "Hello")]
		[TestCase("555", "777", "777", "555")]
		public void GetReplacingContentTest(string stringA, string stringB, string expectedstringA, string expectedstringB)
		{
			MyFirstHomework.GetReplacingContent(ref stringA, ref stringB);
			Assert.AreEqual(expectedstringA, stringA);
			Assert.AreEqual(expectedstringB, stringB);
		}
	}
}
