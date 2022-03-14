using System;
namespace AllHomework
{
	public static class MyThirdHomework
	{
		public static double GetNumberOfDegree(double valueA, double valueBB)
		{
			if (valueBB % 1 != 0)
			{
				throw new ArgumentException("The valueBB value must be an integer, enter an integer");
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
				throw new DivideByZeroException("If the valueA value is zero to any degree, the expression does not make sense, enter another valueA value");
			}
			else if (valueB < 0 && valueA!=0)
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
				throw new ArgumentException("If the valueA value is zero or fractional, the expression does not matter, enter another valueA value");
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
		public static int GetSumNumbersDivisibleBySeven(double valueAA, double valueBB)
		{
			if (valueAA % 1 != 0 || valueBB % 1 != 0)
			{
				throw new ArgumentException("Enter the integers valueAA and valueBB");
			}
			int valueA = Convert.ToInt32(valueAA);
			int valueB = Convert.ToInt32(valueBB);
			int sum = 0;
			int tmp1 = 0;
			int tmp2 = 0;
			if (valueA <= valueB) { tmp1 = valueA; tmp2 = valueB; }
			else if (valueA >= valueB) { tmp1 = valueB; tmp2 = valueA; }
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
				throw new ArgumentException("The value of the valueNN number must be an integer and positive");
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
			return tmp;
		}
		public static int GetGreatestCommonDivisorNumbers(double valueAA, double valueBB)
		{
			if (valueAA % 1 != 0 || valueBB % 1 != 0 || valueAA == 0 || valueBB == 0)
			{
				throw new ArgumentException("The values of valueAA and valueBB must be integers and not equal to zero");
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
				throw new ArgumentException("The value of the number1 number must be an integer and positive");
			}
			int number = Convert.ToInt32(number1);
			double tmp = 0;
			double e = 0.01;
			double leftNumber = 0;
			double rightNumber;
			if (Math.Pow(number, 1.0 / 3.0) % 1 == 0)
			{
				tmp = Math.Pow(number, 1.0 / 3.0);
			}
			else
			{
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
			}
			return tmp;
		}
		public static long GetNumberOfOddDigits(double number1)
		{
			if (number1 % 1 != 0)
			{
				throw new ArgumentException("The value of number1 must be an integer");
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
		public static string GetMirrorNumber(double number1)
		{
			if (number1 % 1 != 0)
			{
				throw new ArgumentException("The value of number1 must be an integer");
			}
			long number = Convert.ToInt64(number1);
			string revers;
			long reversNumber;
			long numberMath;
			revers = "";
			reversNumber = 0;
			numberMath = 0;
			if (number == 0)
			{
				revers = Convert.ToString(reversNumber);
			}
			else if (number > 0)
			{
				while (number != 0)
				{
					reversNumber = reversNumber * 10;
					reversNumber = reversNumber + number % 10;
					number = number / 10;
				}
				revers = Convert.ToString(reversNumber);
			}
			else if (number < 0)
			{
				numberMath = Math.Abs(number);
				while (numberMath != 0)
				{
					reversNumber = reversNumber * 10;
					reversNumber = reversNumber + numberMath % 10;
					numberMath = numberMath / 10;
				}
				revers = "-" + Convert.ToString(reversNumber);
			}
			return revers;
		}
		public static bool GetAlignmentOfDigitsOfNumbers(double number12, double number22)
		{
			if (number12 % 1 != 0 || number22 % 1 != 0)
			{
				throw new ArgumentException("If the values of number12 and number22 are zero, the task does not make sense, the numbers number12 and number22 must be integers");
			}
			int tmp;
			int number1 = Convert.ToInt32(number12);
			int number2 = Convert.ToInt32(number22);
			bool isEqualNumner = false;
			if (number1 == number2)
			{
				isEqualNumner = true;
			}
			if (number1 == 0)
			{
				for (int i = number2; i != 0; i /= 10)
				{
					if (i % 10 == 0)
					{
						isEqualNumner = true;
					}
				}
			}
			if (number2 == 0)
			{
				for (int i = number1; i != 0; i /= 10)
				{
					if (i % 10 == 0)
					{
						isEqualNumner = true;
					}
				}
			}
			while (number1 != 0)
			{
				tmp = number1 % 10;
				for (int i = number2; i != 0; i /= 10)
				{
					if (tmp == i % 10)
					{
						isEqualNumner = true;
					}
				}
				number1 /= 10;
			}
			return isEqualNumner;
		}

//Methods with two conclusions

		public static int[] GetNumbersAreMultiplesA(double valueAA)
		{
			if (valueAA == 0 || valueAA % 1 != 0)
			{
				throw new ArgumentException("The valueA value must not be zero and must be an integer, enter another valueA value");
			}
			int targetIndex;
			int valueA = Convert.ToInt32(valueAA);
			int[] temp = new int[1000 / Math.Abs(valueA)];
			int i = Math.Abs(valueA);
			for (int j = 0; i <= 1000; j++)
			{
				temp[j] = i;
				i += Math.Abs(valueA);
			}
			targetIndex = 0;
			for (int z = 0; z < temp.Length; z++)
			{
				if (temp[z] != 0)
				{
					temp[targetIndex++] = temp[z];
				}
			}
			Array.Resize(ref temp, targetIndex);
			return temp;
		}
		public static int[] GetNumbersSumOfEvenDigitsGreater(double valueNN)
		{
			if (valueNN <= 0 || valueNN % 1 != 0)
			{
				throw new ArgumentException("If the value of valueNN number is zero, the task does not make sense, the value of valueNN number must be an integer and positive");
			}
			int valueN = Convert.ToInt32(valueNN);
			int[] sourceArray = new int[valueN / 2];
			int tmp;
			int sumEvenNumber;
			int sumOddNumber;
			int targetIndex;
			int x;
			x = 0;
			for (int i = 1; i <= valueN; i++)
			{
				if (i % 2 == 0 && i < 10)
				{
					sourceArray[x++] = i;
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
						sourceArray[x++] = i;
					}
				}
			}
			targetIndex = 0;
			for (int i = 0; i < sourceArray.Length; i++)
			{
				if (sourceArray[i] != 0)
				{
					sourceArray[targetIndex++] = sourceArray[i];
				}
			}
			Array.Resize(ref sourceArray, targetIndex);
			return sourceArray;
		}
	}
}
