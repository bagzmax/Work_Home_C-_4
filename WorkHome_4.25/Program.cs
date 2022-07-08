﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Exponentiation(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}

Console.Write("Ведите число A: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Ведите число B: ");
int numB = int.Parse(Console.ReadLine()!);

int expo = Exponentiation(numA, numB);
Console.WriteLine("Результат = " + expo);