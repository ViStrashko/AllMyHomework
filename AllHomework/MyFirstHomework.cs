using System;
namespace AllHomework
{
	static class MyFirstHomework
	{
		public static double GetResultOfTheEquation(double valueA, double valueB)
		{
			double resultCalculations;
			resultCalculations = ((5 * valueA) + (valueB * valueB)) / (valueB - valueA);
			return resultCalculations;
		}
		public static double GetVariableOfTheEquation(double valueA, double valueB, double valueC)
		{
			double valueX;
			valueX = (valueC - valueB) / valueA;
			return valueX;
		}
		public static void GetEquationOfTheLine(double coordinateX1, double coordinateX2, double coordinateY1, double coordinateY2)
		{
			double valueA = (coordinateY2 - coordinateY1) / (coordinateX2 - coordinateX1);
			double valueB = coordinateY1 - valueA * coordinateX1;
			Console.WriteLine($"Уравнение прямой: Y={valueA}*X+{valueB}");
		}

//Methods with two conclusions

		public static void GetDividingNumbersEndRemainderOfTheDivision(double valueA, double valueB, out double rezultDividing, out double remainsDividing)
		{
			rezultDividing = valueA / valueB;
			remainsDividing = valueA % valueB;
		}
		public static void GetReplacingContent(ref string stringA, ref string stringB)
		{
			stringA = "Goodbye";
			stringB = "Hello";
		}
	}
}
