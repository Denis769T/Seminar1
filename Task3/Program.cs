﻿/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
a = a % 2;
if (a == 0)
{
    Console.Write("Число является четным");
}
else
{
    Console.Write("Число не является четным");
}
