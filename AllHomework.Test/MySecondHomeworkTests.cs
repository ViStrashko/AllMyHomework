using NUnit.Framework;
using System;

namespace AllHomework.Test
{
	[TestFixture]
	public class MySecondHomeworkTests
	{
		[TestCase(2, 1, 3)]
		[TestCase(-1, -2, -3)]
		[TestCase(1, 0, 1)]
		[TestCase(0, -1, -1)]
		[TestCase(2.5, 1.5, 4)]
		[TestCase(-1.5, -2.5, -4)]
		[TestCase(1.5, 0, 1.5)]
		[TestCase(0, -1.5, -1.5)]

		[TestCase(1, 1, 1)]
		[TestCase(-1, -1, 1)]
		[TestCase(0, 0, 0)]
		[TestCase(1.5, 1.5, 2.25)]
		[TestCase(-1.5, -1.5, 2.25)]

		[TestCase(1, 2, -1)]
		[TestCase(-2, -1, -1)]
		[TestCase(-1, 0, -1)]
		[TestCase(0, 1, -1)]
		[TestCase(1.5, 2.5, -1)]
		[TestCase(-2.5, -1.5, -1)]
		[TestCase(-1.5, 0, -1.5)]
		[TestCase(0, 1.5, -1.5)]
		public void GetSumOrDifferenceOrProductOfNumbersTest(double valueA, double valueB, double expected)
		{
			double actual = MySecondHomework.GetSumOrDifferenceOrProductOfNumbers(valueA, valueB);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(1, 1, "Точка с координатами X,Y принадлежит четверти: 1")]
		[TestCase(1.5, 1.5, "Точка с координатами X,Y принадлежит четверти: 1")]

		[TestCase(-1, 1, "Точка с координатами X,Y принадлежит четверти: 2")]
		[TestCase(-1.5, 1.5, "Точка с координатами X,Y принадлежит четверти: 2")]

		[TestCase(-1, -1, "Точка с координатами X,Y принадлежит четверти: 3")]
		[TestCase(-1.5, -1.5, "Точка с координатами X,Y принадлежит четверти: 3")]

		[TestCase(1, -1, "Точка с координатами X,Y принадлежит четверти: 4")]
		[TestCase(1.5, -1.5, "Точка с координатами X,Y принадлежит четверти: 4")]

		[TestCase(0, 1, "Точка с координатами X,Y принадлежит четверти: лежит на оси OY")]
		[TestCase(0, 1.5, "Точка с координатами X,Y принадлежит четверти: лежит на оси OY")]
		[TestCase(0, -1, "Точка с координатами X,Y принадлежит четверти: лежит на оси OY")]
		[TestCase(0, -1.5, "Точка с координатами X,Y принадлежит четверти: лежит на оси OY")]

		[TestCase(1, 0, "Точка с координатами X,Y принадлежит четверти: лежит на оси OX")]
		[TestCase(1.5, 0, "Точка с координатами X,Y принадлежит четверти: лежит на оси OX")]
		[TestCase(-1, 0, "Точка с координатами X,Y принадлежит четверти: лежит на оси OX")]
		[TestCase(-1.5, 0, "Точка с координатами X,Y принадлежит четверти: лежит на оси OX")]

		[TestCase(0, 0, "Точка с координатами X,Y принадлежит четверти: является началом координат")]
		public void GetQuarterCoordinatesPointTest(double coordinateX, double coordinateY, string expected)
		{
			string actual = MySecondHomework.GetQuarterCoordinatesPoint(coordinateX, coordinateY);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(10, "десять")]
		[TestCase(55, "пятьдесят пять")]
		public void GetTwodigitNumberInWordsTest(double number1, string expected)
		{
			string actual = MySecondHomework.GetTwodigitNumberInWords(number1);
			Assert.AreEqual(expected, actual);
		}
		[TestCase(5)]
		[TestCase(100)]
		[TestCase(55.5)]
		[TestCase(0)]
		public void GetTwodigitNumberInWordsTest_WhenNumber1IsNotTwoDigitInteger_ShuoldThrowException(double number1)
		{
			Assert.Throws<Exception>(() => MySecondHomework.GetTwodigitNumberInWords(number1));
		}


		[TestCase(3, 1, 2, new double[] { 1, 2, 3 })]
		[TestCase(-1, -3, -2, new double[] { -3, -2, -1 })]
		[TestCase(3, 0, 2, new double[] { 0, 2, 3 })]
		[TestCase(-2, 0, 3, new double[] { -2, 0, 3 })]
		[TestCase(3, 0, 0, new double[] { 0, 0, 3 })]
		[TestCase(0, 0, 0, new double[] { 0, 0, 0 })]
		[TestCase(3.5, 1.5, 2.5, new double[] { 1.5, 2.5, 3.5 })]
		[TestCase(-1.5, -3.5, -2.5, new double[] { -3.5, -2.5, -1.5 })]
		[TestCase(3.5, 0, 2.5, new double[] { 0, 2.5, 3.5 })]
		[TestCase(3.5, 0, -2.5, new double[] { -2.5, 0, 3.5 })]
		public void GetAscendingNumbersTest(double valueA, double valueB, double valueC, double[] expected)
		{
			double[] actual = MySecondHomework.GetAscendingNumbers(valueA, valueB, valueC);
			Assert.AreEqual(expected, actual);
		}


		[TestCase(1.5, 4, 2, new double[] { -2, -0.66666666666666663 }, "")]
		[TestCase(2.5, -5.5, 1, new double[] { 0.2, 2 }, "")]

		[TestCase(4, 4, 1, new double[] { -0.5 }, "")]
		[TestCase(6.25, 5, 1, new double[] { -0.4 }, "")]

		[TestCase(4, 4, 12, new double[] { }, "Решение уравнения: Корней нет")]
		[TestCase(2.5, -5.5, 10, new double[] { }, "Решение уравнения: Корней нет")]
		public void GetSolutionOfTheEquationTest(double valueA, double valueB, double valueC, double[] expectedSolutionOfTheEquation, string expectedRezultOfTheEquation)
		{
			double[] actualSolutionOfTheEquation;
			string actualRezultOfTheEquation;
			MySecondHomework.GetSolutionOfTheEquation(valueA, valueB, valueC, out actualSolutionOfTheEquation, out actualRezultOfTheEquation);
			Assert.AreEqual(expectedSolutionOfTheEquation, actualSolutionOfTheEquation);
			Assert.AreEqual(expectedRezultOfTheEquation, actualRezultOfTheEquation);
		}
		[TestCase(0, 4, 2)]
		[TestCase(0, 0, 2)]
		[TestCase(0, -4, 2)]
		[TestCase(0, 0, -2)]
		[TestCase(0, 4.5, 2.5)]
		[TestCase(0, 0, 2.5)]
		[TestCase(0, -4.5, 2.5)]
		[TestCase(0, 0, -2.5)]
		[TestCase(0, 0, 0)]
		public void GetSolutionOfTheEquationTest_valueAAndValueBIsNotEqualToZero_ShuoldThrowException(double valueA, double valueB, double valueC)
		{
			double[] solutionOfTheEquation;
			string rezultOfTheEquation;
			Assert.Throws<Exception>(() => MySecondHomework.GetSolutionOfTheEquation(valueA, valueB, valueC, out solutionOfTheEquation, out rezultOfTheEquation));
		}
	}
}
