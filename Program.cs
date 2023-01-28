/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.

Примеры:
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
["Russia", "Denmark", "Kazan"] → []
*/

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] originArray = {
        "LA",
        "Moscow",
        "NY",
        "Samara",
        "SPb"
};

string[] newArray = new string[originArray.Length];

void ThreeDigitSymbol(string[] originArray, string[] newArray)
{
    int count = 0;
    for (int i = 0; i < originArray.Length; i++)
    {
    if(originArray[i].Length <= 3)
        {
        newArray[count] = originArray[i];
        count++;
        }
    }
}

ThreeDigitSymbol(originArray, newArray);

PrintArray(newArray);