// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int[] userInputMoreNum(string EnterText)
{
    Console.Write(EnterText);
    string[] inputStr = Console.ReadLine().Split(" ");

    int[] arrayInt32 = new int[inputStr.Length];

    for (int i = 0; i < arrayInt32.Length; i++)
        arrayInt32[i] = Convert.ToInt32(inputStr[i]);

    return arrayInt32;
}

double[,] GetGenerate2DArrayDouble(int countArray, int countEl, int end)
{
    double[,] twoDArray = new double[countArray, countEl];

    for (int i = 0; i < twoDArray.GetLength(0); i++)
        for (int j = 0; j < twoDArray.GetLength(1); j++)
            twoDArray[i, j] = Math.Round(new Random().NextDouble() * end, 1);

    return twoDArray;
}

void Show2DArray(double[,] twoDArray)
{
    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
            Console.Write($"[{twoDArray[i, j]}]");

        Console.WriteLine();
    }
}

int[] userInput = userInputMoreNum("Enter two numbers by separating them with a space: ");
double[,] twoDArray = GetGenerate2DArrayDouble(userInput[0], userInput[1], 10);

Show2DArray(twoDArray);
