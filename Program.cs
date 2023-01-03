// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// Console.WriteLine("Введите число");
// double n = Convert.ToInt32(Console.ReadLine());

// string PrintNumber(double start, double end)
// {
//     if (start == end)
//     {
//         return start.ToString();
//     }
//     return (start + " " + PrintNumber(start-1, end));
// }
// Console.WriteLine(PrintNumber(n, 1));

//-------------------------------------------------------------------------------------------------------------------------

// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// //M = 1; N = 15 -> 120
// //M = 4; N = 8 -> 30

// Console.WriteLine("Введите число M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumNumber(int start, int end)
// {
//     int sum = 0;
//     if (start == end)
//     {
//         sum = start;
//     }

//     if (start < end)
//     {
//         sum = start + SumNumber(start + 1, end);
//     }
//     return sum;
// }

// Console.WriteLine(SumNumber(m, n));

//---------------------------------------------------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunc(int m, int n)
{
    if (m == 0) return (n + 1);

    if (m > 0 && n == 0) return (AkkermanFunc(m - 1, 1));

    if (m > 0 && n > 0) return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));

    return AkkermanFunc(m, n);
}
Console.WriteLine($"Функция Аккермана для чисел ({m},{n}) = {AkkermanFunc(m, n)}");