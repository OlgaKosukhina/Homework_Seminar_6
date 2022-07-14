/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] GetArray(int massiveLength)
{
    int[] array = new int[massiveLength];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Insert massive element: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int GetCountOfPositive(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Input massive length: ");
int massiveLength = int.Parse(Console.ReadLine());
int[] arr = GetArray(massiveLength);
int result = GetCountOfPositive(arr);
Console.WriteLine($"Amount of positive numbers: {result}");