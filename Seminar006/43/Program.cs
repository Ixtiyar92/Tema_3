﻿// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите B1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите K1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите B2: ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите K2: ");
double k2 = double.Parse(Console.ReadLine());

Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
{
    double[] result = new double[2];
    result[0] = (inB2 - inB1) / (inK1 - inK2);
    result[1] = inK1 * result[0] + inB1;
    return result;
}
