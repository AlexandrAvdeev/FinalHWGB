
string[] first = new string[6] {"Finan Control", "Work", "On The Main Block", "GB","IS", "Ok"};
string[] final = new string[first.Length];
void FindShorterThree(string[] first, string[] final)
{
    int count = 0;
    for (int i = 0; i < first.Length; i++)
    {
    if(first[i].Length <= 3)
        {
        final[count] = first[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FindShorterThree(first, final);
PrintArray(final);