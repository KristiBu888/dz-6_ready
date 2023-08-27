// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Мои попытки не увенчались успехом:


// System.Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// int num = number[0];
// int result = 0;
// for (int i = 0; i < length; i++)
// {
//     if (i > 0)
//     {
//         result = result + 1;
//     }
// }
// Console.WriteLine(result);


// System.Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// int num = number[0];
// int result = 0;
// if (num > 0 && num < number.Length)
// {
//     result = result + 1;
//     num++;
// }
// Console.WriteLine(result);


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] arr = { number };
// int result = 0;
// int count = arr.Length;
// for (int i = 0; i < count; i++)
// {
//     if (arr[i] > 0)
//     {
//         result = result++;
//     }
//     Console.WriteLine(result);
// }


Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов > 0: {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");