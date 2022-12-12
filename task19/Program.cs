// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
// 14212 -> нет 
// 23432 -> да 
// 12821 -> да 

int userNumber = new int();
Console.WriteLine("введите число");
userNumber = Convert.ToInt32(Console.ReadLine());
if (((userNumber/10000 == userNumber%10) && ((userNumber/1000)%10 == (userNumber%100)/10)))
{
    Console.WriteLine("палиндром");
}
  else
    Console.WriteLine("не палиндром");

