// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



Console.Clear();
Console.WriteLine("Введите количество чисел N:");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = CreateAndFillIntArray(num);

Console.WriteLine($"Количество положительных чисел {CountPositiveElementsInIntArray(array)}");

// Methods

static int[] CreateAndFillIntArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

static int CountPositiveElementsInIntArray(int[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            counter++;
    }
    return counter;
}