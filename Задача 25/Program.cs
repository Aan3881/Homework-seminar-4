//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int A(int num, int num2)
{
    int arr = num;
    for (int i = 1; i < num2; i++)
    {
        arr = arr * num;
    }
    return arr;
}
if (number2 > 0)
{
    int result = A(number, number2);
    Console.WriteLine($"{number}|{number2}|{result}");
}
