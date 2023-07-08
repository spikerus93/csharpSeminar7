// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите любое число от 100 до 1000: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers(int number)
{
    if (number <= 0) return 0;
    return SumOfNumbers(number / 10) + (number % 10);
}

SumOfNumbers(number);
Console.Write(SumOfNumbers(number));