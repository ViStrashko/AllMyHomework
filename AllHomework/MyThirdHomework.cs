using System;
namespace AllHomework
{
	static class MyThirdHomework
	{
		public static double GetNumberOfDegree(double valueA, double valueBB)
		{
			if (valueBB % 1 != 0)
			{
				throw new Exception("The valueBB value must be an integer, enter an integer");
			}
			int valueB = Convert.ToInt32(valueBB);
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
			if (valueA == 0)
			{
				throw new Exception("If the valueA value is zero to the minus degree, the expression does not make sense, enter another valueA value");
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
			if (valueA < 0)
			{
				throw new Exception("The valueA value must be greater than zero");
			}
			int i = 1;
			while (i * i < valueA)
			{
				i++;
			}
			return (i-1);
		}
		public static int GetLargestDivisorOfNumber(double valueAA)
		{
			if (valueAA == 0 || valueAA% 1 != 0)
			{
				throw new Exception("If the valueA value is zero or fractional, the expression does not matter, enter another valueA value");
			}
			int valueA = Convert.ToInt32(valueAA);
			int i = Math.Abs(valueA);
			for (; i > 0; i--)
			{
				if (valueA % i == 0 && i != valueA && i != Math.Abs(valueA))
				{
					break;
				}
			}
			return i;
		}
		public static int GetSumNumbersDivisibleBy7(double valueAA, double valueBB)
		{
			if (valueAA % 1 != 0 || valueBB % 1 != 0)
			{
				throw new Exception("Enter the integers valueAA and valueBB");
			}
			int valueA = Convert.ToInt32(valueAA);
			int valueB = Convert.ToInt32(valueBB);
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
		public static int GetNumberFibonacciSeries(double valueNN)
		{
			if (valueNN <= 0 || valueNN % 1 != 0)
			{
				throw new Exception("The value of the valueNN number must be an integer and positive");
			}
			int valueN = Convert.ToInt32(valueNN);
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
		public static int GetGreatestCommonDivisorNumbers(int valueAA, int valueBB)
		{
			if (valueAA % 1 != 0 || valueBB % 1 != 0 || valueAA == 0 || valueBB == 0)
			{
				throw new Exception("The values of valueAA and valueBB must be integers and not equal to zero");
			}
			int valueA = Convert.ToInt32(valueAA);
			int valueB = Convert.ToInt32(valueBB);
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
		public static double GetNumberMethodOfHalfDivision(double number1)
		{
			if (number1 <= 0 || number1 % 1 != 0)
			{
				throw new Exception("The value of the number1 number must be an integer and positive");
			}
			int number = Convert.ToInt32(number1);
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
		public static long GetNumberOfOddDigits(double number1)
		{
			if (number1 % 1 != 0)
			{
				throw new Exception("The value of number1 must be an integer");
			}
			long number = Convert.ToInt64(number1);
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
		public static long[] GetMirrorNumber(double number1)
		{
			if (number1 % 1 != 0)
			{
				throw new Exception("The value of number1 must be an integer");
			}
			int lenght;
			long tmp;
			long number = Convert.ToInt64(number1);
			lenght = 0;
			tmp = Math.Abs(number);
			while (tmp !=0)
			{
				tmp = tmp / 10;
				lenght++;
			}
			tmp = Math.Abs(number);
			long[] revers = new long[lenght];
			for (int i = 0; i < lenght; i++)
			{
				revers[i] = tmp % 10;
				tmp = tmp / 10;
			}
			return revers;
		}
		public static bool GetAlignmentOfDigitsOfNumbers(double number12, double number22)
		{
			if (number12 == 0 || number22 == 0 || number12 % 1 != 0 || number22 % 1 != 0)
			{
				throw new Exception("If the values of number12 and number22 are zero, the task does not make sense, the numbers number12 and number22 must be integers");
			}
			int number1 = Convert.ToInt32(number12);
			int number2 = Convert.ToInt32(number22);
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

//Methods with two conclusions

		public static void GetNumbersAreMultiplesA(double valueA, out double i)
		{
			if (valueA == 0)
			{
				throw new Exception("The ValueA value should not be zero, enter a different ValueA value");
			}
			i = Math.Abs(valueA);
			while (i < 1000)
			{
				Console.WriteLine(i);
				i += Math.Abs(valueA);
			}
		}
		public static void GetNumbersSumOfEvenDigitsGreater(double valueNN, out int i)
		{
			if (valueNN <= 0 || valueNN % 1 != 0)
			{
				throw new Exception("If the value of the valueNN number is zero, the task does not make sense, the valueNN number must be an integer");
			}
			int valueN = Convert.ToInt32(valueNN);
			int tmp;
			int sumEvenNumber;
			int sumOddNumber;
			i = 1;
			for ( ; i <= valueN; i++)
			{
				if (i % 2 == 0 && i < 10)
				{
					Console.Write((i)+" ");
				}
				else if (i >= 10)
				{
					sumEvenNumber = 0;
					sumOddNumber = 0;
					int j = i;
					while (j >= 1)
					{
						tmp = j % 10;
						if (tmp % 2 == 0)
						{
							sumEvenNumber += tmp;
						}
						else
						{
							sumOddNumber += tmp;
						}
						j = j / 10;
					}
					if (sumEvenNumber >= sumOddNumber)
					{
						Console.Write((i) + " ");
					}
				}
			}
		}
	}
}
