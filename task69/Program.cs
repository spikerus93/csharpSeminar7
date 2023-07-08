// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Stepen(int osnova, int mnozhitel)
{
    if (mnozhitel == 0) return 1;
    return Stepen(osnova, mnozhitel-1) * osnova;
}

Console.WriteLine(Stepen(A, B));