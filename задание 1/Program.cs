// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine();
string[] list = elements.Split(" ", StringSplitOptions.RemoveEmptyEntries);
Console.WriteLine($"Исходный массив строк [{String.Join(", ", list)}]");
string[] newlist = GetRandomArrayFromString(list);
Console.WriteLine($"Полученный массив строк [{String.Join(", ", newlist)}]");


// функция создания массива строк, путем рандомного выбора элементов из имеющегося массива
string[] GetRandomArrayFromString(string[] stringArray)
{
    string[] array = new string[stringArray.Length-1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = stringArray[new Random().Next(0, stringArray.Length)]; 
    }
    return array;
}
