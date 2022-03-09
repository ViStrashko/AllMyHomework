﻿using System;
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
		public static void CheckTheOperationOfTheMethod(int[] numbers)
		{
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(tmp[i] + " ");
			}
		}
		public static int GetMinimumElementOfTheArray(int[] numbers)
		{
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
			int min;
			int index;
			min = tmp[0];
			index = 0;
			for (int i = 1; i < numbers.Length; i++)
			{
				if (tmp[i] < min)
				{
					index = i;
				}
			}
			Console.Write("Индекс минимального числа массива: ");
			return index;
		}
		public static int GetIndexMaximumElementOfTheArray(int[] numbers)
		{
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
			int max;
			int index;
			max = tmp[0];
			index = 0;
			for (int i = 1; i < numbers.Length; i++)
			{
				if (tmp[i] > max)
				{
					index = i;
				}
			}
			Console.Write("Индекс максимального числа массива: ");
			return index;
		}
		public static int GetSumOfElementsOddIndexOfTheArray(int[] numbers)
		{
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
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
	}
}
