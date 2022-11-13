// Напишите программу, которая принимает
//  на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

int res = (num1 / 10) % 10;
Console.WriteLine(Math.Abs(res));
