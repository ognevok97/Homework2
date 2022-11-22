/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int num = new int();
Console.WriteLine("Введи трехзначное число и я покажу вторую цифру этого числа");
    num = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(num);
Console.WriteLine("вторая цифра этого числа -"+stringNumber[1]);