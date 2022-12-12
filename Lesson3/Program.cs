using Lesson3;
using Point;
//СЕМИНАР-3
/* Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y). */



/* Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21 */

/* double EnterNumber(string text)
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

double x1 = EnterNumber("Введите x1: ");
double y1 = EnterNumber("Введите y1: ");
double x2 = EnterNumber("Введите x2: ");
double y2 = EnterNumber("Введите y2: ");

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine(result); */


/* Задача No22. Работа в группах
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4 */

/* System.Console.WriteLine("Введите число до которого пойдет цикл");
int length = int.Parse(Console.ReadLine());
for (int i = 0; i < length; i++)
{
	// System.Console.Write(i * i + " ");
	System.Console.WriteLine(Math.Pow(i, 2));
} */
// ДОМАШКА-3

/* Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 14212 -> нет
12821 -> да
23432 -> да  */
/* void palindrom()
{
	System.Console.WriteLine("Введите пятизначное число: ");
	int number = int.Parse(Console.ReadLine());
	int num1 = number / 10000 % 10;
	int num2 = number / 1000 % 10;
	int rev1 = number / 10 % 10;
	int rev2 = number % 10;
	int nul = number / 10000;

	if (nul < 1 || nul > 9)
	{
		Console.WriteLine(number + " -> " + "Не пятизначное число!");
	}
	else if (num1 == rev2 && num2 == rev1)
	{
		Console.WriteLine(number + " -> Это полиндром");
	}
	else
	{
		Console.WriteLine(number + " -> Это не полиндром");
	}
}
for (int i = 0; i < 3; i++)
{
	palindrom();
} */

/* Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* double EnterNumber(string text)
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

double x1 = EnterNumber("Введите x1: ");
double y1 = EnterNumber("Введите y1: ");
double z1 = EnterNumber("Введите z1: ");
double x2 = EnterNumber("Введите x2: ");
double y2 = EnterNumber("Введите y2: ");
double z2 = EnterNumber("Введите z2: ");

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine(result); */

/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* void from1toN()
{
	System.Console.WriteLine("Введите число: ");
	int size = int.Parse(Console.ReadLine());
	for (int i = 0; i <= size; i++)
	{
		System.Console.WriteLine(Math.Pow(i, 3));
	}
}
for (int i = 0; i < 2; i++)
{
	from1toN();
} */