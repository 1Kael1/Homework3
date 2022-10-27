// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

bool Paly(int num1)
{
    int digit1 = num1 / 10000;
    int digit2 = num1 % 10;
    int digit3 = num1 / 1000 % 10 ;
    int digit4 = num1 / 10 % 10;

  return digit3 == digit4 && digit1 == digit2;
}

Console.WriteLine(Paly(num) ? $"{num} является палиндромом" : $"{num} не является палиндромом");