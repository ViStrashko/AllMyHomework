using System;
namespace AllHomework
{
	static class MyFirstHomework
	{
		public static int GetResultOfTheEquation(int valueA, int valueB)
		{
			int resultCalculations;
			resultCalculations = ((5 * valueA) + (valueB * valueB)) / (valueB - valueA);
			return resultCalculations;
		}
		public static double GetVariableOfTheEquation(double valueA, double valueB, double valueC)
		{
			double valueX;
			valueX = (valueC - valueB) / valueA;
			return valueX;
		}
		public static void GetEquationOfTheLine(int coordinateX1, int coordinateX2, int coordinateY1, int coordinateY2)
		{
			int valueA = (coordinateY2 - coordinateY1) / (coordinateX2 - coordinateX1);
			int valueB = coordinateY1 - valueA * coordinateX1;
			Console.WriteLine($"Уравнение прямой: Y={valueA}*X+{valueB}");
		}
	}
}
