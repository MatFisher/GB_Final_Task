string[] arrayStart = new string[5] {"123", "23", "hello", "world", "res"};
string[] arrayResult = new string[arrayStart.Length];

string[] SecondArrayWithIF(string[] arrayStart, string[] arrayResult)
{
    int temp = 0;
    for (int i = 0; i < arrayStart.Length; i++)
    {
    if(arrayStart[i].Length <= 3)
        {
        arrayResult[temp] = arrayStart[i];
        temp++;
        }
    }
    return arrayResult;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

arrayResult = SecondArrayWithIF(arrayStart, arrayResult);
PrintArray(arrayResult);