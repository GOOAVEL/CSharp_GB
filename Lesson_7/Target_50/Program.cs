/* Задача 50.
 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4    
17 -> такого числа в массиве нет */

// условие задачи не совсем корректно, если 17 принимается как общий подчет начиная с нуля, тогда понятно, 
// в любом случае сделал 2 метода для поиска элемента или некоректного индекса.

int Promt(string enterText)
{
    Console.Write(enterText);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int countArray, int countEl, int start, int end)
{
    int[,] twoDArray = new int[countArray, countEl];

    for (int i = 0; i < twoDArray.GetLength(0); i++)
        for (int j = 0; j < twoDArray.GetLength(1); j++)
            twoDArray[i, j] = new Random().Next(start, end + 1);

    return twoDArray;
}

void Show2DArray(int[,] twoDArray)
{
    for (int i = 0; i < twoDArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoDArray.GetLength(1); j++)
            Console.Write($"[{twoDArray[i, j]}]");

        Console.WriteLine();
    }
    Console.WriteLine();
}

// first option
string FindItemByIndexFor2DArray(int[,] twoDArray, int index)
{
    for (int i = 0, n = 0; i < twoDArray.GetLength(0); i++)
        for (int j = 0; j < twoDArray.GetLength(1); j++, n++)
            if (n == index) return $"{twoDArray[i, j]}";

    return "There’s no such number in the array!";
}

// second option
string FindItemByVulueFor2DArray(int[,] twoDArray, int value)
{
    for (int i = 0; i < twoDArray.GetLength(0); i++)
        for (int j = 0; j < twoDArray.GetLength(1); j++)
            if (twoDArray[i, j] == value) return $"{twoDArray[i, j]}";

    return "There’s no such number in the array!";
}


int a = Promt("Enter the position element for searth of 2D array: ");
int b = Promt("Enter the element for searth of 2D array: ");
int[,] twoDArray = Generate2DArray(3, 4, 1, 10);

Show2DArray(twoDArray);

Console.WriteLine(FindItemByIndexFor2DArray(twoDArray, a));  // find position (if the array was one)
Console.WriteLine(FindItemByVulueFor2DArray(twoDArray, b)); // find element