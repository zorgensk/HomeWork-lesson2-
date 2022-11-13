// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 < 100)
{
Console.WriteLine("третьей цифры нет");
}
else
{
while(num1 > 1000)
{
 num1 =  num1 / 10;
}
num1 = num1 % 10;
 Console.WriteLine($"{num1} третья цифра");
}
