//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
using System;
{
    Console.Write("Введите трёхзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string stringNumber = Convert.ToString(num);
    Console.WriteLine("Вторая цифра числа = "+stringNumber[1]);
}