// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

string[] CreateArray()
{
    string[] arr = new string[4];
    arr[0] = "text";
    arr[1] = ":)";
    arr[2] = "123";
    arr[3] = "12345";
    return arr;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    //Console.WriteLine($"{i}: {array[i]}");

    Console.WriteLine();
}

string[] GetShortStrings(string[] sourceArray)
{
    int countOfShortStrings = 0;
    for (int i = 0; i < sourceArray.Length; i++)
        if (sourceArray[i].Length <= 3)
            countOfShortStrings++;
    string[] newArray = new string[countOfShortStrings];
    int j = 0;
    for (int i = 0; i < sourceArray.Length; i++)
        if (sourceArray[i].Length <= 3)
        {
            newArray[j] = sourceArray[i];
            j++;
        }
    return newArray;
}

string[] sourceArray = CreateArray();
string[] resultArray = GetShortStrings(sourceArray);
ShowArray(resultArray);