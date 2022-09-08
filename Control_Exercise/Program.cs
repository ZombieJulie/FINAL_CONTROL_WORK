/* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

string[] firstArray = { "tha", "disk", "nk", "1567", "self", "you", "computer science", "gb", "lesson", ";)" };

int secArrLength = GetLengthSecondArray(firstArray);
string[] secondArray = FillSecondArray(firstArray, secArrLength);

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

int GetLengthSecondArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillSecondArray(string[] array, int len)
{
    string[] result = new string[len];
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[count] = array[i];
                count++;
            }
        }
    }
    return result;
}

Console.Write("[ ");
PrintArray(firstArray);
Console.Write(" ]");
GetLengthSecondArray(firstArray);
Console.WriteLine();
Console.Write("[ ");
PrintArray(secondArray);
Console.Write(" ]");