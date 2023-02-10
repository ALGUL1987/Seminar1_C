/*
Напишите программу, которая принимает на вход 2 числа и проверяет, 
является ли первое чилсо квадратом второго
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

Console.WriteLine("Введите первое число: ");
int firtsValue = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите второе число: ");
int secondValue = Convert.ToInt32(Console.ReadLine()); 

//точка с запятой не ставится рядом с фигурными скобками
if (firtsValue == Math.Pow(secondValue, 2)) // Math.Pow(число, степень) Math.Pow(3,2)=9
{
    Console.WriteLine("Число " + firtsValue + " является квадратом от " + secondValue);
}
else // Число не является квадратом
{
    Console.WriteLine("Число " + firtsValue + " не является квадратом от " + secondValue);
}
/*
Console.WriteLine("1" + "1") - строчка (string)
Console.WriteLine(1 + 1) числа
*/