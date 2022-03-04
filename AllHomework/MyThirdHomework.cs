using System;
namespace AllHomework
{
	static class MyThirdHomework
	{
		public static double GetNumberOfDegree(double valueA, double valueB)
		{
			int i = 0;
			double tmp=0;
			double rezult = 1;
			while (i < Math.Abs(valueB))
			{
				rezult = rezult * valueA;
				i++;
			}
			if (valueB > 0)
			{
				tmp=rezult;
			}
			else if (valueB < 0 && valueA != 0)
			{
				tmp = (1 / rezult);
			}
			else if (valueB == 0)
			{
				tmp = 1;
			}
			return tmp;
		}
		public static double GetQuantityNumbersSmallerSquare(double valueA)
		{
			int i = 0;
			while (i * i < valueA)
			{
				i++;
			}
			return (i-1);
		}
		public static void GetLargestDivisorOfNumber(int valueA)
		{
			for (int i = Math.Abs(valueA); i > 0; i--)
			{
				if (valueA % i == 0 && i != valueA && i != Math.Abs(valueA))
				{
					Console.WriteLine($"Наибольший делитель числа {valueA}: {i}");
					break;
				}
			}
		}
		public static int GetSumNumbersDivisibleBy7(int valueA, int valueB)
		{
			int sum = 0;
			int tmp1 = 0;
			int tmp2 = 0;
			if (valueA < valueB) { tmp1 = valueA; tmp2 = valueB; }
			else if (valueA > valueB) { tmp1 = valueB; tmp2 = valueA; }
			for (int i = tmp1; i <= tmp2; i++)
			{
				if (i % 7 == 0)
				{
					sum = sum + i;
				}
			}
			return sum;
		}
		public static int GetNumberFibonacciSeries(int valueN)
		{
			int numberFibonacci1 = 1;
			int numberFibonacci2 = 1;
			int sum = 0;
			int tmp = 0;
			int i = 3;
			while (valueN >= i)
			{
				sum = numberFibonacci1 + numberFibonacci2;
				numberFibonacci1 = numberFibonacci2;
				numberFibonacci2 = sum;
				i++;
			}
			if (valueN == 1)
			{
				tmp=numberFibonacci1;
			}
			else if (valueN == 2)
			{
				tmp=numberFibonacci2;
			}
			else if (valueN >= 3)
			{
				tmp=sum;
			}
			return sum;
		}
		public static int GetGreatestCommonDivisorNumbers(int valueA, int valueB)
		{
			int tmp1;
			int tmp2;
			tmp1 = Math.Abs(valueA);
			tmp2 = Math.Abs(valueB);
			while (tmp1 != 0 && tmp2 != 0)
			{
				if (tmp1 > tmp2)
				{
					tmp1 -= tmp2;
				}
				else
				{
					tmp2 -= tmp1;
				}
			}
			return tmp1;
		}
		static double F(double n)
		{
			return n * n * n;
		}
		public static double GetNumberMethodOfHalfDivision(int number)
		{
			double tmp = 0;
			double e = 0.01;
			double leftNumber = 0;
			double rightNumber;
			rightNumber = number;
			while ((F(leftNumber + e) <= number && F(rightNumber - e) >= number))
			{
				tmp = (leftNumber + rightNumber) / 2;
				if (F(tmp) > number)
				{
					rightNumber = tmp;
				}
				else
				{
					leftNumber = tmp;
				}
			}
			return tmp;
		}
		public static long GetNumberOfOddDigits(long number)
		{
			long tmp1;
			long tmp2;
			long countNumber = 0;
			tmp2 = Math.Abs(number);
			while (tmp2 >= 1)
			{
				tmp1 = tmp2 % 10;
				if (tmp1 % 2 == 1)
				{
					countNumber++;
				}
				tmp2 = tmp2 / 10;
			}
			return countNumber;
		}
		public static void GetMirrorNumber(long number)
		{
			long tmp1;
			long tmp2;
			tmp2 = Math.Abs(number);
			if (number < 0)
			{
				Console.Write("-");
			}
			while (tmp2 >= 1)
			{
				tmp1 = tmp2 % 10;
				Console.Write(tmp1);
				tmp2 = tmp2 / 10;
			}
		}
		public static bool GetAlignmentOfDigitsOfNumbers(int number1, int number2)
		{
			int tmp1;
			int tmp2;
			int tmp3;
			int secondNumber;
			bool isEqualNumner = false;;
			tmp3 = Math.Abs(number1);
			while (tmp3 >= 1)
			{
				tmp1 = tmp3 % 10;
				secondNumber = Math.Abs(number2);
				while (secondNumber >= 1)
				{
					tmp2 = secondNumber % 10;
					if (tmp1 == tmp2)
					{
						isEqualNumner = true;
					}
					secondNumber = secondNumber / 10;
				}
				tmp3 = tmp3 / 10;
			}
				return isEqualNumner;
		}
	}
}
