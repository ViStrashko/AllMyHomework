using System;
namespace AllHomework
{
	public static class MySecondHomework
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
		public static string GetQuarterCoordinatesPoint(double coordinateX, double coordinateY)
		{
			string tmp = "";
			if (coordinateX > 0 && coordinateY > 0)
			{
				tmp = "Точка с координатами X,Y принадлежит четверти: 1";
			}
			else if (coordinateX < 0 && coordinateY > 0)
			{
				tmp = "Точка с координатами X,Y принадлежит четверти: 2";
			}
			else if (coordinateX < 0 && coordinateY < 0)
			{
				tmp = "Точка с координатами X,Y принадлежит четверти: 3";
			}
			else if (coordinateX > 0 && coordinateY < 0)
			{
				tmp = "Точка с координатами X,Y принадлежит четверти: 4";
			}
			else if (coordinateX == 0 && coordinateY != 0)
			{
				tmp = "Точка с координатами X,Y принадлежит четверти: лежит на оси OY";
			}
			else if (coordinateY == 0 && coordinateX != 0)
			{
				tmp = "Точка с координатами X,Y принадлежит четверти: лежит на оси OX";
			}
			else if (coordinateX == 0 && coordinateY == 0)
			{
				tmp = "Точка с координатами X,Y принадлежит четверти: является началом координат";
			}
			return tmp;
		}
		static string GetNumbersFromElevenToNineteen(int number)
		{
			string tmp = "";
			switch (number)
			{
				case 11:
					tmp = "одинадцать";
				    break;
				case 12:
					tmp = "двенадцать";
				    break;
				case 13:
					tmp = "тринадцать";
				    break;
				case 14:
					tmp = "четырнадцать";
				    break;
				case 15:
					tmp = "пятнадцать";
				    break;
				case 16:
					tmp = "шеснадцать";
				    break;
				case 17:
					tmp = "семнадцать";
				    break;
				case 18:
					tmp = "восемьнадцать";
				    break;
				case 19:
					tmp = "девятнадцать";
				    break;
			}
			return tmp;
		}
		static string GetNumbersFromTwentyToNinetyNine(int number)
		{
			string tmp = "";
			switch (number / 10)
			{
				case 1:
					tmp = "десять";
				    break;
				case 2:
					tmp = "двадцать ";
				    break;
				case 3:
					tmp = "тридцать ";
				    break;
				case 4:
					tmp = "сорок ";
				    break;
				case 5:
					tmp = "пятьдесят ";
				    break;
				case 6:
					tmp = "шестьдесят ";
				    break;
				case 7:
					tmp = "семьдесят ";
				    break;
				case 8:
					tmp = "восемьдесят ";
				    break;
				case 9:
					tmp = "девяносто ";
				    break;
			}
			return tmp;
		}
		static string GetNumbersFromOneToNine(int number)
		{
			string tmp = "";
			if (number % 10 >= 1)
			{
				switch (number % 10)
				{
					case 1:
						tmp = "один";
					    break;
					case 2:
						tmp = "два";
					    break;
					case 3:
						tmp = "три";
					    break;
					case 4:
						tmp = "четыре";
					    break;
					case 5:
						tmp = "пять";
					    break;
					case 6:
						tmp = "шесть";
					    break;
					case 7:
						tmp = "семь";
					    break;
					case 8:
						tmp = "восемь";
					    break;
					case 9:
						tmp = "девять";
					    break;
				}
			}
			return tmp;
		}
		public static string GetTwodigitNumberInWords(double number1)
		{
			if (number1 <= 9 || number1 >=100 || number1%1!=0)
			{
				throw new ArgumentException("The input number1 must be two-digit, positive and integer");
			}
			int number = Convert.ToInt32(number1);
			string tmp;

			if (number > 10 && number < 20)
			{
				tmp = GetNumbersFromElevenToNineteen(number);
			}
			else
			{
				tmp = GetNumbersFromTwentyToNinetyNine(number) + GetNumbersFromOneToNine(number);
			}
			return tmp;
		}

//Methods with two conclusions

		public static double[] GetAscendingNumbers(double valueA, double valueB, double valueC)
		{
			double[] result = new double[] { valueA, valueB, valueC };
			double tmp;
			for (int i = 0; i < result.Length; i++)
			{
				for (int j = i + 1; j < result.Length; j++)
				{
					if (result[i] > result[j])
					{
						tmp = result[i];
						result[i] = result[j];
						result[j] = tmp;
					}
				}
			}
			return result;
		}
		public static void GetSolutionOfTheEquation(double valueA, double valueB, double valueC, out double[] result, out string rezult)
		{
			if (valueA == 0 || valueB == 0)
			{
				throw new DivideByZeroException("The ValueA value end ValueB value should not be zero, enter a different ValueA value end ValueB value");
			}
			double x1;
			double x2;
			double discriminant;
			int targetIndex;
			x1 = 0;
			x2 = 0;
			rezult = "";
			discriminant = valueB * valueB - (4 * valueA * valueC);
			if (discriminant > 0)
			{
				x1 = ((-valueB - Math.Sqrt(discriminant)) / (2 * valueA));
				x2 = ((-valueB + Math.Sqrt(discriminant)) / (2 * valueA));
			}
			else if (discriminant == 0)
			{
				x1 = (-valueB) / (2 * valueA);
			}
			else if (discriminant < 0)
			{
				rezult = "Решение уравнения: Корней нет";
			}
			result = new double[] { x1, x2 };
			targetIndex = 0;
			for (int i = 0; i < result.Length; i++)
			{
				if (result[i] != 0)
				{
					result[targetIndex++] = result[i];
				}
			}
			Array.Resize(ref result, targetIndex);
		}
	}
}
