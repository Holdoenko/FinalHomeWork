/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

Console.Clear();

string[] array = new string[] { "5", "Hello", "987", ":)))", "$$" };
PrintArray(array);
DiffArray(array);
Console.WriteLine("--------------------");
PrintArray(array);

void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.WriteLine();
}

void DiffArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        string element = newArray[i];
        if (element.Length <= 3)
        {
            newArray[i] = element;
        }
        else
            newArray[i] = string.Empty;
    }
}

