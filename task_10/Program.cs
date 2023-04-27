// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number;

Console.WriteLine("Введите число ");

number = Convert.ToInt32(Console.ReadLine());

int digit = (number%100)/10;

Console.WriteLine(digit);
