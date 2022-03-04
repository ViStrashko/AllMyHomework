using System;
namespace AllHomework
{
	static class MyThirdHomework
	{
		public static int GetNumberOfDegree(int valueA, int valueB)
		{
			int result = 1;
			for (int i = 0; i < valueB; i++)
			{
				result = result * valueA;
			}
			return result;
		}
		public static int GetQuantityNumbersSmallerSquare(int valueA)
		{
			int i = 0;
			while (i * i < valueA-1)
			{
				i++;
			}
			return i;
		}
		public static void GetLargestDivisorOfNumber(int valueA)
		{
			for (int i = valueA; i > 0; i--)
			{
				if (valueA % i == 0 && i != valueA)
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
			int i = 3;
			if (valueN == 1)
			{
				sum=numberFibonacci1;
			}
			else if (valueN == 2)
			{
				sum=numberFibonacci2;
			}
			else
			{
				while (valueN >= i)
				{
					sum = numberFibonacci1 + numberFibonacci2;
					numberFibonacci1 = numberFibonacci2;
					numberFibonacci2 = sum;
					i++;
				}
			}
			return sum;
		}
		public static int GetGreatestCommonDivisorNumbers(int valueA, int valueB)
		{
			while (valueA != 0 && valueB != 0)
			{
				if (valueA > valueB)
				{
					valueA -= valueB;
				}
				else
				{
					valueB -= valueA;
				}
			}
			return valueA;
		}
		static double F(double n)
		{
			return n * n * n;
		}
		public static double GetNumberMethodOfHalfDivision(double number)
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
			long tmp;
			long countNumber = 0;
			while (number >= 1)
			{
				tmp = number % 10;
				if (tmp % 2 == 1)
				{
					countNumber++;
				}
				number = number / 10;
			}
			return countNumber;
		}
		public static void GetMirrorNumber(long number)
		{
			long tmp;
			while (number >= 1)
			{
				tmp = number % 10;
				Console.Write(tmp);
				number = number / 10;
			}
		}
	}
}
