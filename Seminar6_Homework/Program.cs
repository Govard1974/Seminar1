// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*

Console.Write("Введите числа, разделенные пробелами: "); 
string input = Console.ReadLine();
string[] numberStrings = input.Split(' ');

int positiveNumberCount = 0;

for (int i = 0; i < numberStrings.Length; i++)
{
    int number = Convert.ToInt32(numberStrings[i]);

    if (number >= 0)
    {
        positiveNumberCount++;
    }
}

Console.WriteLine($"Количество положительных чисел: {positiveNumberCount}");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = 0, y = 0;

if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают, имеют бесконечное количество точек пересечения.");
else if (k1 == k2)
    Console.WriteLine("Прямые параллельны, нет точки пересечения.");
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}

Console.WriteLine($"Точка пересечения: ({x}; {y})");

*/

// Задача дополнительная. Написать программу, преобразующую число 
// из десятеричной системы исчисления в двоичную

/*

string DecimalToBinary(int decimalNumber)
{
    if (decimalNumber == 0)
    return "0";

    string binary = "";
    for (; decimalNumber > 0; decimalNumber /= 2)
    {
        int remainder = decimalNumber % 2;
        binary = remainder + binary;
    }

    return binary;
}

Console.Write(" Введите десятичное число:  ");
int decimalNumber = Convert.ToInt32(Console.ReadLine());

string binaryNumber = DecimalToBinary(decimalNumber);
Console.WriteLine($"Двоичное представление: {binaryNumber}");

*/

