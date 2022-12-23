/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

System.Console.Write("Введите размер массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] numbers = new int[elementsCount];
AboveZeroSum(numbers);

void AboveZeroSum(int[] arr)
{
	int count = 0;
	for (int i = 0; i < numbers.Length; i++)
	{
		System.Console.Write("Введите число под индексом: " + i + ": ");
		numbers[i] = int.Parse(Console.ReadLine());
		if (numbers[i] > 0)
		{
			count++;
		}
	}
	System.Console.WriteLine("\nЭлементов выше нуля: " + count);
}

/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

FindPoint();
void FindPoint()
{
	double x, y;
	double b1 = EnterNumber("Введите точку b1: ");
	double k1 = EnterNumber("Введите точку k1: ");
	double b2 = EnterNumber("Введите точку b2: ");
	double k2 = EnterNumber("Введите точку k2: ");
	x = (b1 - b2) / (k2 - k1);
	y = (k2 * b1 - k1 * b2) / (k2 - k1);
	if (k1 == k2)
	{
		System.Console.WriteLine("Прямые не пересекаются.");
	}
	else
	{
		System.Console.WriteLine("Точка пересечения прямых == " + x + y);
	}
}
double EnterNumber(string text)
{
	bool isParsed = false;
	double number = 0;
	while (!isParsed)
	{
		Console.Write(text);
		isParsed = double.TryParse(Console.ReadLine(), out number);
	}
	return number;
}