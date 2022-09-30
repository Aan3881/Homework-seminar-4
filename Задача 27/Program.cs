// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Arr(int num)
{
    int num2 = 0;

    while (num > 0)
    {
        num2 = num2 + num % 10;
        num = num / 10;
    }
    return num2;
}
int result = Arr(number);
Console.WriteLine($"{result}");