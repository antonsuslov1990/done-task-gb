string[] arrayInput = new string[5] {"123", "23", "hello", "world", "res"};
string[] arrayOutput = new string[arrayInput.Length];
void newArray(string[] arrayInput, string[] arrayOutput)
{
    int count = 0;
    for (int i = 0; i < arrayInput.Length; i++)
    {
    if(arrayInput[i].Length <= 3)
        {
        arrayOutput[count] = arrayInput[i];
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
newArray(arrayInput, arrayOutput);
PrintArray(arrayOutput);