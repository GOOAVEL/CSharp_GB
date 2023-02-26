/*Задача 29:
  Напишите программу, которая задаёт массив из 8 элементов
  и выводит их на экран.*/

System.Console.WriteLine("Enter 8 elements for our array: ");
string[] numbers = { "First", "Second", "Third", "Fourth", "Fifth",
                                             "Sixth", "Seventh", "Eighth"};
int[] array = CreateToArray(8);

int[] CreateToArray(int count)
{
    int[] array = new int[count];

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{numbers[i]} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

foreach (var item in array)
{
    System.Console.Write($"[{item}] ");
}

