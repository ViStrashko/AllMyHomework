using System;
namespace AllHomework
{
	static class MyFirstHomework
	{
		public static double GetResultOfTheEquation(double valueA, double valueB)
		{
			if (valueA == valueB)
			{
				throw new Exception("The valueA value must not be equal to the ValueB value, enter different valueA and ValueB values");
			}
			double resultCalculations;
			resultCalculations = ((5 * valueA) + (valueB * valueB)) / (valueB - valueA);
			return resultCalculations;
		}
		public static double GetVariableOfTheEquation(double valueA, double valueB, double valueC)
		{
			if (valueA == 0)
			{
				throw new Exception("The ValueA value should not be zero, enter a different ValueA value");
			}
			double valueX;
			valueX = (valueC - valueB) / valueA;
			return valueX;
		}
		public static void GetEquationOfTheLine(double coordinateX1, double coordinateX2, double coordinateY1, double coordinateY2)
		{
			if (coordinateX1 == coordinateX2)
			{
				throw new Exception("The coordinateX1 value must not be equal to the coordinateX2 value, enter different coordinateX1 and coordinateX2 values");
			}
			double valueA = (coordinateY2 - coordinateY1) / (coordinateX2 - coordinateX1);
			double valueB = coordinateY1 - valueA * coordinateX1;
			Console.WriteLine($"Уравнение прямой: Y={valueA}*X+{valueB}");
		}

//Methods with two conclusions

		public static void GetDividingNumbersEndRemainderOfTheDivision(double valueA, double valueB, out double rezultDividing, out double remainsDividing)
		{
			if (valueB == 0)
			{
				throw new Exception("The ValueB value should not be zero, enter a different ValueB value");
			}
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
