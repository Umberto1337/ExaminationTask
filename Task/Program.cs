﻿string[] ReadInputArray()
{
    Console.WriteLine("Введите элементы массива строк, разделяя их пробелом:");
    string input = Console.ReadLine();

    string[] inputArray = input.Split(' ');

    return inputArray;
}

string[] FilterStrings(string[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            resultArray[index] = inputArray[i];
            index++;
        }
    }

    return resultArray;
}

void PrintResultArray(string[] resultArray)
{
    Console.WriteLine("Результат вывода - массив строк меньше или равно 3 символам:");
    foreach (string str in resultArray)
    {
        Console.WriteLine(str);
    }
}

string[] inputArr = ReadInputArray();
string[] resultArr = FilterStrings(inputArr);
PrintResultArray(resultArr);
