// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void Main()
{
    Console.WriteLine("Введите элементы массива через пробел:");
    string? input = Console.ReadLine();
    if (input != null && input.Length > 0)
    {
        string[] array = input.Split(' ');
        PrintArray(array);
        System.Console.Write(" -> ");
        PrintArray(NewArray(array));
    }
    else
       System.Console.WriteLine("Вы ничего не ввели. Запустите программу снова и повторите ввод."); 
    
}

string[] NewArray(string[] array)
{
    string[] newArray = new string[Count(array)];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if(array[i].Length <=3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

int Count(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for(int i = 0;  i < array.Length; i++)
    {
        if(array[i].Length <=3)
        {
            newArray[i] = array[i];
            count++;
        }
    }
    return count;
}

void PrintArray(string[] array)
{
    if(array.Length < 1)
        System.Console.Write("[]");
    else
        System.Console.Write("['" + string.Join("', '", array)+ "']");
}

Main();
