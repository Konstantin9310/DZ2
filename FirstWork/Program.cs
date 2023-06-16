/*
Напишите программу, которая принимает на вход трёхзначное число и
 на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
*/

Console.Write("Input number => ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);

Console.WriteLine("second digit=> "+stringNumber[1]);
