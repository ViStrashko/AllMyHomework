using System;
namespace AllHomework
{
	static class MySecondHomework
	{
		public static int GetSumOrDifferenceOrProductOfNumber(int valueA, int valueB)
		{
			int result = 0;
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
		public static void GetQuarterCoordinatesPoint(int coordinateX, int coordinateY)
		{
			if (coordinateX > 0 && coordinateY > 0) { Console.WriteLine($"Точка с координатами X,Y принадлежит четверти '1'"); }
			else if (coordinateX < 0 && coordinateY > 0) { Console.WriteLine($"Точка с координатами X,Y принадлежит четверти '2'"); }
			else if (coordinateX < 0 && coordinateY < 0) { Console.WriteLine($"Точка с координатами X,Y принадлежит четверти '3'"); }
			else if (coordinateX > 0 && coordinateY < 0) { Console.WriteLine($"Точка с координатами X,Y принадлежит четверти '4'"); }
		}
		public static void GetTwodigitNumberInWords(int number)
		{
			if (number > 10 && number < 20)
			{
				switch (number)
				{
					case 11: Console.WriteLine("одинадцать"); break;
					case 12: Console.WriteLine("двенадцать"); break;
					case 13: Console.WriteLine("тринадцать"); break;
					case 14: Console.WriteLine("четырнадцать"); break;
					case 15: Console.WriteLine("пятнадцать"); break;
					case 16: Console.WriteLine("шеснадцать"); break;
					case 17: Console.WriteLine("семнадцать"); break;
					case 18: Console.WriteLine("восемьнадцать"); break;
					case 19: Console.WriteLine("девятнадцать"); break;
				}
				Console.ReadKey();
				return;
			}
			switch (number / 10)
			{
				case 1: Console.WriteLine("деcять"); break;
				case 2: Console.Write("двадцать "); break;
				case 3: Console.Write("тридцать "); break;
				case 4: Console.Write("сорок "); break;
				case 5: Console.Write("пятьдесят "); break;
				case 6: Console.Write("шестьдесят "); break;
				case 7: Console.Write("семьдесят "); break;
				case 8: Console.Write("восемьдесят "); break;
				case 9: Console.Write("девяносто "); break;
				default: break;
			}
			if (number % 10 >= 1)
			{
				switch (number % 10)
				{
					case 1: Console.Write("один"); break;
					case 2: Console.Write("два"); break;
					case 3: Console.Write("три"); break;
					case 4: Console.Write("четыре"); break;
					case 5: Console.Write("пять"); break;
					case 6: Console.Write("шесть"); break;
					case 7: Console.Write("семь"); break;
					case 8: Console.Write("восемь"); break;
					case 9: Console.Write("девять"); break;
					default: break;
				}
			}
		}
	}
}
