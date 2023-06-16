/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
*/

Console.Write("Input number of day ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("its holiday");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("this is no day of week");
  }
  else Console.WriteLine("its not a holiday");
}
CheckingTheDayOfTheWeek(dayNumber);