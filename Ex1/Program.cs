// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int newnumber = 0;
int num = number;

if (number < 100000 && number > 9999)
{
    while (num > 0)
    {
        newnumber = newnumber * 10 + num % 10;
        num = num / 10;
    }
    //Console.WriteLine(newnumber);
    if (number == newnumber)
        {
        Console.WriteLine("Палиндром");
        }
    else
        {
        Console.WriteLine("Не палиндром");
        }
}
else
    Console.WriteLine("Ввели не пятизначное число");


