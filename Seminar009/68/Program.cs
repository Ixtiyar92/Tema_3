﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int a = int.Parse(ReadLine());
Write("Введите N: ");
int b = int.Parse(ReadLine());

WriteLine($"Функция Аккермана = {AkkermanFunction(a, b)}");

int AkkermanFunction(int m, int n){
    if (m == 0)
    return n + 1;
    if (n == 0)
    return AkkermanFunction(m - 1, 1);
    return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}