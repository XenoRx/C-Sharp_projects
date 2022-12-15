/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать метод Math.Pow
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

/* int MyPow(int base1, int power1) 1 Вариант
{
	// int result = 1;
	if (power1 > 0)
	{
		int result = 1;
		for (int i = 0; i < power1; i++)
		{
			result *= base1; // result = result * base1;
		}
		return result;
	}
	if (power1 < 0)
	{
		int result = 0;
		for (int i = 0; i < power1; i++)
		{
			result /= result;
		}
		return result;
	}
	return 1;
} */
int MyPow(int base1, int power1)
{
	int res = 1;
	for (int i = 0; i < Math.Abs(power1); i++)
	{
		res *= base1;
	}
	if (power1 >= 0)
	{
		return res;
	}
	else
	{
		return 1 / res;
	}
}
System.Console.WriteLine("1 вывод: " + MyPow(3, 5) + " <- положительная степень");
System.Console.WriteLine("2 вывод: " + MyPow(2, 4) + " <- положительная степень");
System.Console.WriteLine("3 вывод: " + MyPow(7, 0) + " <- нулевая степень");
System.Console.WriteLine("4 вывод: " + MyPow(510, -7) + " <- отрицательная степень");

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void Sum()
{
	System.Console.Write("Введите число: ");
	int number = int.Parse(Console.ReadLine());
	int sum = 0;
	while (number > 0)
	{
		sum += number % 10;
		number = number / 10;
	}
	System.Console.WriteLine("Вывод: " + sum);
}
for (int i = 0; i < 3; i++)
{
	Sum();
}

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void ArrFromConsole()
{
	System.Console.Write("Задайте размер массива: "); // 8
	int size = int.Parse(Console.ReadLine());
	int[] array = new int[size];
	int counter = 1;
	for (int i = 0; i < size; i++)
	{
		System.Console.WriteLine("Введите элемент массива № " + counter);
		counter = counter + 1;
		array[i] = int.Parse(Console.ReadLine());
	}
	PrintArray(array);
}
void PrintArray(int[] array)
{
	Console.Write("[");
	for (var i = 0; i < array.Length - 1; i++)
	{
		Console.Write($"{array[i]},");
	}
	Console.Write(array[array.Length - 1]);
	Console.Write("]");
}

ArrFromConsole();