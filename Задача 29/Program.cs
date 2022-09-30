// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];
GetArray(arr);
PrintArray(arr);

void GetArray(int[] array)
{
    int num = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < num; i++)
    {
        array[i] = rnd.Next(1, 100);
    }
}
void PrintArray(int[] arr)
{
    int num2 = arr.Length;
    for (int i = 0; i < num2; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}