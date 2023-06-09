﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine();
Print(12, 1);

void Print(int n, int i)
{
    Console.Write($"{i} ");
    if (i < n)
    {
        Print(n, i + 1);
    }
}

Console.WriteLine();
Console.WriteLine();

//______________________________________________________________________________________

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = 1;
int N = 15;

SummOfNumbers(M, N, 0);

void SummOfNumbers(int M, int N, int Sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {Sum}");
        return;
    }
    Sum = Sum + (M++);
    SummOfNumbers(M, N, Sum);
}

Console.WriteLine();

//______________________________________________________________________________________

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 2;
int n = 3;

int Akermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akermann(m - 1, 1);
    if (m > 0 && n > 0) return Akermann(m - 1, Akermann(m, n - 1));
    return Akermann(m, n);
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {Akermann(m, n)}");

Console.WriteLine();