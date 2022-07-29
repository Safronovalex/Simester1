
string[] CreateNewArray(string[] inputArray)
{
    int counter = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3) counter++;
    }
    string[] outputArray = new string[counter];
    return outputArray;
}

string[] FillAray(string[] inputArray, string[] outputArray)
{
    int index = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            outputArray[index] = inputArray[i];
            index++;
        }
    }
    return outputArray;
}

string PrintArray(string[] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        result += ($"{array[i]} ");
    }
    return result;
}


string[] array = { "hello", "2", "world", ":-(" };
string[] createdArray = CreateNewArray(array);
FillAray(array, createdArray);
string input = PrintArray(array);
Console.WriteLine($"input:    {input}");
string output = PrintArray(createdArray);
Console.WriteLine($"output:   {output}");