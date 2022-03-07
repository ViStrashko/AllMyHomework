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
		public static void GetArrayReverse(int[] numbers)
		{
			int[] tmp = new int[numbers.Length];
			Array.Copy(numbers, tmp, numbers.Length);
			Console.Write("Реверс массива: ");
			for (int i = numbers.Length-1; i >= 0; i--)
			{
				Console.Write(tmp[i]+" ");
			}
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
			Console.Write("\nКоличество нечетных элементов массива: ");
			return numberOddElements;
		}
	}
}
