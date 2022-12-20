/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

System.Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
Random randNum = new Random();

void FillArray() // функция заполнения массива рандомными трехзначными числами
{
	for (int i = 0; i < size; i++)
	{
		arr[i] = randNum.Next(100, 900);
		// arr[0] = 345; проверка
		// arr[1] = 897; проверка
		// arr[2] = 568; проверка
		// arr[3] = 234; проверка
	}
	PrintArray(arr);
	PrintEvenArr(arr);
}
void PrintArray(int[] array) // функция вывода массива
{
	Console.Write("[");
	for (var i = 0; i < array.Length - 1; i++)
	{
		Console.Write($"{array[i]}, ");
	}
	Console.Write(array[array.Length - 1]);
	Console.Write("]");
}
void PrintEvenArr(int[] arr) // функция проверки является ли число чётным и вывод колличества четных символов
{
	int even = 0;
	for (int i = 0; i < size; i++)
	{
		if (arr[i] % 2 == 0)
		{
			even++;
		}
	}
	System.Console.Write("\nЧетных элементов: " + even);
}
FillArray();

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

System.Console.Write("Задайте длинну массива: ");
int size2 = int.Parse(Console.ReadLine());
int[] arr2 = new int[size2];
Random randNumbers = new Random();
void GenerateArr() // генерируем массив чисел
{
	for (int i = 0; i < size2; i++)
	{
		arr2[i] = randNumbers.Next(-20, 20);
		// arr[0] = -4; // проверка
		// arr[1] = -6;
		// arr[2] = 89;
		// arr[3] = 6;
	}
	PrintArray(arr2);
}
int GetSumNumbers(int[] arr) //считаем и выводим сумму положительных чисел в массиве стоящих на нечетных индексах
{
	int odd = 0;
	for (int i = 0; i < size2; i++)
	{
		if (i % 2 == 1)
		{
			odd += arr2[i];
		}
	}
	System.Console.WriteLine("\nСумма элементов в массиве на нечетных позициях: " + odd);
	return odd;
}
GenerateArr();
GetSumNumbers(arr2);

/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] array = new int[5] { 3, 7, 22, 2, 78 };
int min = array[0];
int max = array[0];
int Max()
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > max)
		{
			max = array[i];
		}
	}
	System.Console.WriteLine("\nМаксимальное значение в массиве : " + max);
	return max;
}
int Min()
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] < min)
		{
			min = array[i];
		}
	}
	System.Console.WriteLine("Минимальное значение в массиве : " + min);
	return min;
}
void Avg()
{
	Max();
	Min();
	int avg = max - min;
	System.Console.WriteLine("Разница между min и max: " + avg);
}
PrintArray(array);
Avg();