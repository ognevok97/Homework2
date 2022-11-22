/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введи число:");
int num = new int();
num = Convert.ToInt32(Console.ReadLine());
string numCount = Convert.ToString(num);
if (numCount.Length > 2)
{
  Console.WriteLine("третья цифра -" +numCount[2]);
}
else 
{
  Console.WriteLine("- третьей цифры нет");
}