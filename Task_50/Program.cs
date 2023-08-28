// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int n = 5;
int m = 5;
int[,] arr = new int[n, m];
Random random = new Random();

Console.WriteLine("Исходный массив: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        arr[i, j] = random.Next(10, 99);
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}

Console.Write("Введите строку: ");
int rows = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int columns = Convert.ToInt32(Console.ReadLine()) - 1;

if (rows < 0 || rows >= n || columns < 0 || columns >= m)
{
    Console.WriteLine("Элемент не существует");
}
else
{
        Console.WriteLine($"Значение элемента массива = {arr[rows, columns]}");
}