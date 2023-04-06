string[] arrayStart = new string[5] {"123", "23", "hello", "world", "res"};
string[] arrayResult = new string[array1.Length];

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

