﻿//#define ARRAYS_1
//#define ARRAYS_2
#define JAGGED_ARRAYS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
#if ARRAYS_1
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = { 3, 5, 8, 13, 21 };
			int[] arr = new int[n];
			Random rand = new Random(0);    //0 - Seed value
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);//0 ... IntMax
										//Next(int upperLimit);	//Возвращает случайное число до 'upperLimit'.
										//Next(int lowerLimit, int upperLimit);	//Возвращает слкчайное число в диапазоне от 'lowerLimit' до 'upperLimit'.
			}
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();

			foreach (int i in arr)//Range-based for
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
#endif

#if ARRAYS_2
			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());

			int[,] i_arr_2 = new int[rows, cols];

			Console.WriteLine(i_arr_2.Rank);

			//Random rand = new Random(0);
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			//////////////////////////////////////

			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					for (int k = i; k < i_arr_2.GetLength(0); k++)
					{
						for (int l = k == i ? j + 1 : 0; l < i_arr_2.GetLength(1); l++)
						{
							if (i_arr_2[k, l] < i_arr_2[i, j])
							{
								//(i_arr_2[k, l], i_arr_2[i, j]) = (i_arr_2[i, j], i_arr_2[k, l]);
								int buffer = i_arr_2[i, j];
								i_arr_2[i, j] = i_arr_2[k, l];
								i_arr_2[k, l] = buffer;
							}
						}
					}
				}
			}

			//////////////////////////////////////
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			foreach (int i in i_arr_2)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
#endif

#if JAGGED_ARRAYS
			//for (int a = 0, b = 1, c = a + b; a < 1000; a = b, b = c, c = a + b)
			//	Console.Write(a + "\t");
			//Console.WriteLine();

			int[][] arr_jagged = new int[][]
				{
					new int[]{ 34, 610,55, 89 },
					new int[]{ 144, 1, 1,233, 377,  987 },
					new int[]{ 3, 5, 8, 13, 21 },
					new int[]{ 0,  2 },
				};
			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					for (int k = i; k < arr_jagged.Length; k++)
					{
						for (int l = k == i ? j + 1 : 0; l < arr_jagged[k].Length; l++)
						{
							if (arr_jagged[k][l] < arr_jagged[i][j])
							{
								//(i_arr_2[k, l], i_arr_2[i, j]) = (i_arr_2[i, j], i_arr_2[k, l]);
								int buffer = arr_jagged[i][j];
								arr_jagged[i][j] = arr_jagged[k][l];
								arr_jagged[k][l] = buffer;
							}
						}
					}
				}
			}

			for (int i = 0; i < arr_jagged.Length; i++)
			{
				for (int j = 0; j < arr_jagged[i].Length; j++)
				{
					Console.Write(arr_jagged[i][j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif

		}
	}
}
