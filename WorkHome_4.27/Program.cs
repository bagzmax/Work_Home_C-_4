// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int GetSum(int N)
{
    int sum = 0;
        for (; N!= 0; N /= 10)
    {
        sum += N % 10;
    }
    return sum;
}

Console.Write("Ведите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num}: " + GetSum(num));