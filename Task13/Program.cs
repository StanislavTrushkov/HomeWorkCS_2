//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
using System;
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string AnyNum = Convert.ToString(num);
if (AnyNum.Length > 2)
{
  Console.WriteLine("Третья цифра равна = " + AnyNum[2]);
}
else
{
  Console.WriteLine("Третьей цифры нет");
}
    Console.ReadKey();
}