/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.Clear();

string[] arrStrings = { "one", "two", "three", "four", "five", "six" };
Console.WriteLine();
System.Console.Write("[");
for (int i = 0; i < arrStrings.Length; i++)
{
    System.Console.Write($"{arrStrings[i]}");
      if (i < arrStrings.Length - 1)
            System.Console.Write(", ");
}
System.Console.Write("]");
System.Console.Write(" Первые три символа первого массива: -> ");

System.Console.Write("[");
string[] newArray = new string[arrStrings.Length];
    for (int i = 0; i <= 3; i++)
    {
        newArray[i] = arrStrings[i];
        Console.Write($"{newArray[i]}");
           if (i < arrStrings.Length - 3)
            System.Console.Write(", ");
    }
System.Console.Write("]");
