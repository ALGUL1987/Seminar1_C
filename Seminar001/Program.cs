/* Напишите программу, которая на вход принимает число и выдает его квадрат*/
/* тип_данных имя_переменной = значение */


/* Введите число, для которого мы ищем квадрат */

Console.WriteLine("Введите число, для которого мы ищем квадрат: ");

int number = Convert.ToInt32(Console.ReadLine()); // number=5 */ Convert преобразует данные в требуемый параметр */
int result = number * number; // result = number * number //

Console.WriteLine("Квадрат от числа: " + number + " равен " + result);