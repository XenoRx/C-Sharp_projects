//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трехзначное число");
int triNumber = int.Parse(Console.ReadLine());
System.Console.WriteLine("Вывод: ");
int firstDigit = triNumber / 10;
int lastDigit = triNumber % 10;
System.Console.WriteLine(firstDigit % 10);

//Задача 13:Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать string[]
//645 -> 5       78 -> третьей цифры нет       32679 -> 6
System.Console.WriteLine("Введите число");
int triNumber2 = int.Parse(Console.ReadLine());
if (triNumber2 < 99)
{
	System.Console.WriteLine("Третьей цифры нет");
}
else
{
	while (triNumber2 > 1000)
	{
		triNumber2 = triNumber2 / 10;
	}
	System.Console.WriteLine("третье число: " + triNumber2 % 10);
}

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите номер дня недели");
int triger = int.Parse(Console.ReadLine());
if (triger == 6 | triger == 7)
{
	System.Console.WriteLine("Это выходной день");
	return;
}
if (triger > 7 | triger < 1)
{
	System.Console.WriteLine("В неделе всего 7 дней, введите числа от 1 до 7");
}
else
{
	System.Console.WriteLine("Это будний день");
}