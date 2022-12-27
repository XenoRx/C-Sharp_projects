/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
// try
// {
// 	int m = ReadInt("Введите m: ");
// 	int n = ReadInt("Введите n: ");
// 	double[,] array2d = Create2dArrayDouble(m, n);
// 	Print2dArray(array2d);
// }
// catch (Exception e)
// {
// 	System.Console.WriteLine(e.Message);
// }

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив: (Без цикла)
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

// try
// {
// 	int m = ReadInt("Введите m: ");
// 	int n = ReadInt("Введите n: ");
// 	int[,] array = Create2dArrayInt2(m, n);
// }
// catch (Exception e)
// {

// 	System.Console.WriteLine(e.Message);
// }

/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

try
{
	int m = ReadInt("Введите m: ");
	int n = ReadInt("Введите n: ");
	int[,] array = Create2dArrayInt3(m, n);
}
catch (Exception e)
{

	System.Console.WriteLine(e.Message);
}



//=======================================================================================================//
double[,] Create2dArrayDouble(int m, int n) // для первого задания
{
	double[,] array = new double[m, n];
	Random random = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = Convert.ToDouble(random.Next(-10, 10) / 2.0);
		}
	}
	return array;
}

int[,] Create2dArrayInt3(int m, int n) // для третьего задания
{
	int[,] array = new int[m, n];
	Random random = new Random();
	int[] sum = new int[n];
	int counter = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(0, 10);
			sum[j] += array[i, j];
		}
	}
	System.Console.Write("Сумма столбцов: ");
	PrintArray(sum);
	foreach (double item in sum)
	{
		counter++;
		System.Console.WriteLine(counter + ": Столбец: Среднее арифметическое: " + item / n);
	}
	Print2dArray(array);
	return array;
}

int[,] Create2dArrayInt2(int m, int n) // для второго задания
{
	int[,] array = new int[m, n];
	Random random = new Random();
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(0, 10);
		}
	}
	Print2dArray(array);
	Console.WriteLine("Введите индексы: ");
	int index = int.Parse((Console.ReadLine()));
	int jindex = int.Parse((Console.ReadLine()));
	if (index > m && jindex > n)
		Console.WriteLine("Такого числа в массиве нет.");
	else
	{
		object result = array.GetValue(jindex, index);
		Console.WriteLine("Результат: " + result);
	}
	return array;
}

int ReadInt(string title) // метод ввода с консоли + проверка что введены числа.
{
	System.Console.Write(title);
	bool isParsed = int.TryParse(System.Console.ReadLine(), out int number);
	if (isParsed)
	{
		return number;
	}
	throw new Exception("Введены некорректные символы!\nНужно вводить числа.");
}

void Print2dArray(int[,] arr) // для первой задачи тут будет тип double
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			System.Console.Write(arr[i, j] + " | ");
		}
		System.Console.WriteLine();
	}
}

void PrintArray(int[] arr)
{
	System.Console.WriteLine(string.Join(", ", arr));
}