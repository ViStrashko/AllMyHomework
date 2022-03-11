using System;
namespace AllHomework
{
	static class TwoDimensionalArrays
	{
		public static int[,] GetRandomArray(int valueA, int valueB)
		{
			int[,] myArray = new int[valueA, valueB];
			Random random = new Random();
			for (int i = 0; i < myArray.GetLength(0); i++)
			{
				for (int j = 0; j < myArray.GetLength(1); j++)
				{
					myArray[i, j] = random.Next(-10, 11);
				}
			}
			return myArray;
		}
		public static int[,] CopyArray(int[,] numbers)
		{
			int[,] copyArray = new int[numbers.GetLength(0), numbers.GetLength(1)];
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 0; j < numbers.GetLength(1); j++)
				{
					copyArray[i, j] = numbers[i, j];
				}
			}
			return copyArray;
		}
		public static void CheckTheOperationOfTheMethod(int[,] numbers)
		{
			int[,] tmp = CopyArray(numbers);
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 0; j < numbers.GetLength(1); j++)
				{
					if (numbers[i, j] >= 0 && numbers[i, j]<10)
					{
						Console.Write(" ");
					}
					Console.Write(numbers[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
		public static int GetMinimumElementOfTheArray(int[,] numbers)
		{
			int[,] tmp = CopyArray(numbers);
			int min;
			min = tmp[0, 0];
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 1; j < numbers.GetLength(1); j++)
				{
					if (tmp[i, j] < min)
					{
						min = tmp[i, j];
					}
				}
			}
			return min;
		}
		public static int GetMaximumElementOfTheArray(int[,] numbers)
		{
			int[,] tmp = CopyArray(numbers);
			int max;
			max = tmp[0, 0];
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 1; j < numbers.GetLength(1); j++)
				{
					if (tmp[i, j] > max)
					{
						max = tmp[i, j];
					}
				}
			}
			return max;
		}
		public static void GetIndexMinimumElementOfTheArray(int[,] numbers, out int indexI, out int indexJ)
		{
			int[,] tmp = CopyArray(numbers);
			int min;
			min = tmp[0,0];
			indexI = 0;
			indexJ = 0;
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 1; j < numbers.GetLength(1); j++)
				{
					if (tmp[i, j] < min)
					{
						min = tmp[i, j];
						indexI = i;
						indexJ = j;
					}
				}
			}
		}
		public static void GetIndexMaximumElementOfTheArray(int[,] numbers, out int indexI, out int indexJ)
		{
			int[,] tmp = CopyArray(numbers);
			int max;
			max = tmp[0,0];
			indexI = 0;
			indexJ = 0;
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 1; j < numbers.GetLength(1); j++)
				{
					if (tmp[i,j] > max)
					{
						max = tmp[i, j];
						indexI = i;
						indexJ = j;
					}
				}
			}
		}
		/*public static int GetNumberOfArrayElements(int[,] numbers)
		{
			int[,] tmp = CopyArray(numbers);
			int sum;
			sum = 0;
			tmp[i, -1] = 0;
			tmp[-1, j] = 0;
			tmp[i, numbers.GetLength(1)] = 0;
			tmp[numbers.GetLength(0), j] = 0;
			Array.Copy()
			for ( int i = 0; i < numbers.GetLength(0)-1; i++)
			{
				for ( int j = 0; j < numbers.GetLength(1)-1; j++)
				{
					if (tmp[i, j] > tmp[i, j+1] && tmp[i, j] > tmp[i+1, j] && tmp[i, j] > tmp[i, j-1] && tmp[i, j] > tmp[i - 1, j])
					{
						sum++;
					}
				}
			}
			Console.Write("Количество элементов массива, которые больше своих соседей одновременно: ");
			return sum;
		}
	*/}
}
