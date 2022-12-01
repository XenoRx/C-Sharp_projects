// Задание # 2
Console.WriteLine("Введите два числа");
int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{
	System.Console.WriteLine(numberA + " больше чем " + numberB);
}
if (numberB > numberA)
{
	System.Console.WriteLine(numberB + " больше чем " + numberA);
}
if (numberA == numberB)
{
	System.Console.WriteLine("а и b равны");
}
/*========================================================================================================*/
// Задание # 4
int numberA2 = int.Parse(Console.ReadLine());
int numberB2 = int.Parse(Console.ReadLine());
int numberC2 = int.Parse(Console.ReadLine());

if (numberA2 > numberB2 && numberA2 > numberC2)
{
	System.Console.WriteLine("max number: " + numberA2);
}
if (numberB2 > numberA2 && numberB2 > numberC2)
{
	System.Console.WriteLine("max number: " + numberB2);
}
if (numberC2 > numberA2 && numberC2 > numberB2)
{
	System.Console.WriteLine("max number: " + numberC2);
}
if (numberC2 == numberA2 && numberC2 == numberB2)
{
	System.Console.WriteLine("числа равны");
}

/*=========================================================================================================*/
// Задание # 6
Console.WriteLine("Введите число чтобы узнать четное ли оно или не чётное");
int number1 = int.Parse(Console.ReadLine());

if (number1 % 2 == 0)
{
	System.Console.WriteLine("Number is even");
}
else
{
	System.Console.WriteLine("Number is odd");
}

/*=========================================================================================================*/
// Задание # 8
int a = int.Parse(Console.ReadLine());
for (int i = 2; i <= a; i++)
{
	System.Console.WriteLine(i++);
}