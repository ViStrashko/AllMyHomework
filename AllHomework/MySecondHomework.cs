using System;
namespace AllHomework
{
	static class MySecondHomework
	{
		public static double GetSumOrDifferenceOrProductOfNumbers(double valueA, double valueB)
		{
			double result = 0;
			if (valueA > valueB)
			{
				result = valueA + valueB;
			}
			else if (valueA == valueB)
			{
				result = valueA * valueB;
			}
			else if (valueA < valueB)
			{
				result = valueA - valueB;
			}
			return result;
		}
		public static void GetQuarterCoordinatesPoint(double coordinateX, double coordinateY)
		{
			if (coordinateX > 0 && coordinateY > 0)
			{
				Console.WriteLine($"Точка с координатами X,Y принадлежит четверти: {1}");
			}
			else if (coordinateX < 0 && coordinateY > 0)
			{
				Console.WriteLine($"Точка с координатами X,Y принадлежит четверти: {2}");
			}
			else if (coordinateX < 0 && coordinateY < 0)
			{
				Console.WriteLine($"Точка с координатами X,Y принадлежит четверти: {3}");
			}
			else if (coordinateX > 0 && coordinateY < 0)
			{
				Console.WriteLine($"Точка с координатами X,Y принадлежит четверти: {4}");
			}
			else if (coordinateX == 0 && coordinateY != 0)
			{
				Console.WriteLine($"Точка с координатами X,Y принадлежит четверти: лежит на оси OY");
			}
			else if (coordinateY == 0 && coordinateX != 0)
			{
				Console.WriteLine($"Точка с координатами X,Y принадлежит четверти: лежит на оси OX");
			}
			else if (coordinateX == 0 && coordinateY == 0)
			{
				Console.WriteLine($"Точка с координатами X,Y принадлежит четверти: является началом координат");
			}
		}
		static int GetNumbersFromElevenToNineteen(int number)
		{
			switch (number)
			{
				case 11:
					Console.WriteLine("одинадцать");
				    break;
				case 12:
					Console.WriteLine("двенадцать");
				    break;
				case 13:
					Console.WriteLine("тринадцать");
				    break;
				case 14:
					Console.WriteLine("четырнадцать");
				    break;
				case 15:
					Console.WriteLine("пятнадцать");
				    break;
				case 16:
					Console.WriteLine("шеснадцать");
				    break;
				case 17:
					Console.WriteLine("семнадцать");
				    break;
				case 18:
					Console.WriteLine("восемьнадцать");
				    break;
				case 19:
					Console.WriteLine("девятнадцать");
				    break;
			}
			return number;
		}
		static int GetNumbersFromTwentyToNinetyNine(int number)
		{
			switch (number / 10)
			{
				case 1:
					Console.WriteLine("деcять");
				    break;
				case 2:
					Console.Write("двадцать ");
				    break;
				case 3:
					Console.Write("тридцать ");
				    break;
				case 4:
					Console.Write("сорок ");
				    break;
				case 5:
					Console.Write("пятьдесят ");
				    break;
				case 6:
					Console.Write("шестьдесят ");
				    break;
				case 7:
					Console.Write("семьдесят ");
				    break;
				case 8:
					Console.Write("восемьдесят ");
				    break;
				case 9:
					Console.Write("девяносто ");
				    break;
			}
			return number;
		}
		static int GetNumbersFromOneToNine(int number)
		{
			if (number % 10 >= 1)
			{
				switch (number % 10)
				{
					case 1:
						Console.WriteLine("один");
					    break;
					case 2:
						Console.WriteLine("два");
					    break;
					case 3:
						Console.WriteLine("три");
					    break;
					case 4:
						Console.WriteLine("четыре");
					    break;
					case 5:
						Console.WriteLine("пять");
					    break;
					case 6:
						Console.WriteLine("шесть");
					    break;
					case 7:
						Console.WriteLine("семь");
					    break;
					case 8:
						Console.WriteLine("восемь");
					    break;
					case 9:
						Console.WriteLine("девять");
					    break;
				}
			}
			return number;
		}
		public static void GetTwodigitNumberInWords(double number1)
		{
			if (number1 <= 9 || number1 >=100 || number1%1!=0)
			{
				throw new Exception("The input number1 must be two-digit, positive and integer");
			}
			int number = Convert.ToInt32(number1);
			if (number > 10 && number < 20)
			{
				GetNumbersFromElevenToNineteen(number);
			}
			else
			{
				GetNumbersFromTwentyToNinetyNine(number);
				GetNumbersFromOneToNine(number);
			}
		}
		public static void GetAscendingNumbers(double valueA, double valueB, double valueC)
		{
			if (valueA == valueB || valueA == valueC || valueB == valueC)
			{
				throw new Exception("The values of valueA, ValueB and ValueC should not be equal to each other, enter different values");
			}
			if (valueA < valueB && valueB < valueC)
			{
				Console.WriteLine($"{valueA}, {valueB}, {valueC}");
			}
			else if (valueA < valueC && valueC < valueB)
			{
				Console.WriteLine($"{valueA}, {valueC}, {valueB}");
			}
			else if (valueB < valueA && valueA < valueC)
			{
				Console.WriteLine($"{valueB}, {valueA}, {valueC}");
			}
			else if (valueB < valueC && valueC < valueA)
			{
				Console.WriteLine($"{valueB}, {valueC}, {valueA}");
			}
			else if (valueC < valueA && valueA < valueB)
			{
				Console.WriteLine($"{valueC}, {valueA}, {valueB}");
			}
			else if (valueC < valueB && valueB < valueA)
			{
				Console.WriteLine($"{valueC}, {valueB}, {valueA}");
			}
		}

//Methods with two conclusions

		public static void GetSolutionOfTheEquation(double valueA, double valueB, double valueC, out double x1, out double x2)
		{
			if (valueA == 0 || valueB == 0)
			{
				throw new Exception("The ValueA value end ValueB value should not be zero, enter a different ValueA value end ValueB value");
			}
			x1 = 0;
			x2 = 0;
			double discriminant;
			discriminant = valueB * valueB - (4 * valueA * valueC);
			if (discriminant > 0)
			{
				x1 = ((-valueB - Math.Sqrt(discriminant)) / (2 * valueA));
				x2 = ((-valueB + Math.Sqrt(discriminant)) / (2 * valueA));
			}
			else if (discriminant == 0)
			{
				x1=(-valueB) / (2 * valueA);
			}
			else if (discriminant < 0)
			{
				Console.WriteLine($"Решение уравнения: Корней нет");
			}
		}
	}
}
