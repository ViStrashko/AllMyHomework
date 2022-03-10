using System;
namespace AllHomework
{
	static class MyArray
	{
		public static int[] GetRandomArray(uint length)
		{
			int[] myArray = new int[length];
			Random random = new Random();
			for (int i = 0; i < myArray.Length; i++)
			{
				myArray[i] = random.Next(-20, 21);
			}
			return myArray;
		}
		public static int[] GetArrayOfConsecutiveNumbers(int number)
		{
			int tmp;
			tmp = 0;
			int[] numbers = new int[number];
			for (int i = 0; i < number; i++)
			{
				tmp += 1;
				numbers[i] = tmp;
			}
			return numbers;
		}
		public static int[] CopyArray(int[] numbers)
		{
			int[] copyArray = new int[numbers.Length];
			Array.Copy(numbers, copyArray, numbers.Length);
			return copyArray;
		}
		public static void CheckTheOperationOfTheMethod(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(tmp[i] + " ");
			}
		}
		public static int GetMinimumElementOfTheArray(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int min;
			min = tmp[0];
			for (int i = 1; i < numbers.Length; i++)
			{
				if (tmp[i] < min)
				{
					min = tmp[i];
				}
			}
			Console.Write("\nМинимальное число массива: ");
			return min;
		}
		public static int GetMaximumElementOfTheArray(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int max;
			max = tmp[0];
			for (int i = 1; i < numbers.Length; i++)
			{
				if (tmp[i] > max)
				{
					max = tmp[i];
				}
			}
			Console.Write("Максимальное число массива: ");
			return max;
		}
		public static int GetIndexMinimumElementOfTheArray(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int min;
			int index;
			min = tmp[0];
			index = 0;
			for (int i = 1; i < numbers.Length; i++)
			{
				if (tmp[i] < min)
				{
					min = tmp[i];
					index = i;
				}
			}
			Console.Write("Индекс минимального числа массива: ");
			return index;
		}
		public static int GetIndexMaximumElementOfTheArray(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int max;
			int index;
			max = tmp[0];
			index = 0;
			for (int i = 1; i < numbers.Length; i++)
			{
				if (tmp[i] > max)
				{
					max = tmp[i];
					index = i;
				}
			}
			Console.Write("Индекс максимального числа массива: ");
			return index;
		}
		public static int GetSumOfElementsOddIndexOfTheArray(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int sumElementsOddIndex;
			sumElementsOddIndex = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (i%2!=0)
				{
					sumElementsOddIndex += tmp[i];
				}
			}
			Console.Write("Cумма элементов массива с нечетным индексом: ");
			return sumElementsOddIndex;
		}
		public static int[] GetArrayReverse(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int[] tmp1 = new int[numbers.Length];
			int j = 0;
			for (int i = numbers.Length-1; i >= 0; i--)
			{
				tmp1[j++] = tmp[i];
			}
			return tmp1;
		}
		public static int GetNumberOfOddArrayElements(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int numberOddElements;
			numberOddElements = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (tmp[i] % 2 != 0)
				{
					numberOddElements++;
				}
			}
			Console.Write("Количество нечетных элементов массива: ");
			return numberOddElements;
		}
		public static int[] SwapTheHalvesOfTheArray(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int[] tmp1 = new int[numbers.Length];
			int j = 0;
			if (numbers.Length % 2 == 0)
			{
				for (int i = numbers.Length / 2; i < numbers.Length; i++)
				{
					tmp1[j++] = tmp[i];
				}
				for (int i = 0; i < numbers.Length / 2; i++)
				{
					tmp1[j++] = tmp[i];
				}
			}
			else
			{
				for (int i = (numbers.Length / 2)+1; i < numbers.Length; i++)
				{
					tmp1[j++] = tmp[i];
				}
				tmp1[j++] = tmp[numbers.Length / 2];
				for (int i = 0; i < numbers.Length / 2; i++)
				{
					tmp1[j++] = tmp[i];
				}
			}
			return tmp1;
		}
			public static int[] SortArrayByBubbleMethod(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int tmp1;
			for (int i = 0; i < numbers.Length; i++)
			{
				for (int j = i+1; j < numbers.Length; j++)
				{
					if (tmp[i] > tmp[j])
					{
						tmp1 = tmp[i];
						tmp[i] = tmp[j];
						tmp[j] = tmp1;
					}
				}
			}
			return tmp;
		}
		public static int[] SortArraySelectionMethod(int[] numbers)
		{
			int[] tmp = CopyArray(numbers);
			int tmp1;
			for (int i = 0; i < numbers.Length - 1; i++)
			{
				int max = i;
				for (int j = i + 1; j < numbers.Length; j++)
				{
					if (tmp[j] > tmp[max])
					{
						max = j;
					}
				}
				if (max!=i)
				{
					tmp1 = tmp[i];
					tmp[i] = tmp[max];
					tmp[max] = tmp1;
				}
			}
			return tmp;
		}

//Methods in the array HW3

		public static int[] GetNumbersAreMultiplesA(double valueAA)
		{
			if (valueAA == 0 || valueAA % 1 != 0)
			{
				throw new Exception("The valueA value must not be zero and must be an integer, enter another valueA value");
			}
			int valueA = Convert.ToInt32(valueAA);
			int[] temp = new int[1000/Math.Abs(valueA)];
			int i = Math.Abs(valueA);
				for (int j = 0; i < 1000; j++)
				{
				    temp[j] = i;
				    i += Math.Abs(valueA);
				}
			return temp;
		}
		public static int[] GetNumbersSumOfEvenDigitsGreater(double valueNN)
		{
			if (valueNN <= 0 || valueNN % 1 != 0)
			{
				throw new Exception("If the value of the valueNN number is zero, the task does not make sense, the valueNN number must be an integer");
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
					sourceArray[x++]=i;
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
		public static double[] GetSolutionOfTheEquation(double valueA, double valueB, double valueC)
		{
			if (valueA == 0 || valueB == 0)
			{
				throw new Exception("The ValueA value end ValueB value should not be zero, enter a different ValueA value end ValueB value");
			}
			double x1;
			double x2;
			double discriminant;
			int targetIndex;
			x1 = 0;
			x2 = 0;
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
				Console.WriteLine($"Решение уравнения: Корней нет");
			}
			double[] result = new double[] { x1, x2 };
			targetIndex = 0;
			for (int i = 0; i < result.Length; i++)
			{
				if (result[i] != 0)
				{
					result[targetIndex++] = result[i];
				}
			}
			Array.Resize(ref result, targetIndex);
			return result;
		}
		public static double[] GetAscendingNumbers(double valueA, double valueB, double valueC)
		{
			double[] result = new double []{ valueA, valueB, valueC };
			double tmp;
			for (int i = 0; i < 3; i++)
			{
				for (int j = i + 1; j < 3; j++)
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
	}
}
