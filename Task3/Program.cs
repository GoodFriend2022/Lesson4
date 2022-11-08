// Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами. Оформите заполнение массива и вывод 
// в виде функции (пригодится в следующих задачах).  Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный 
// порог случайных значений”, “Введите максимальный порог случайных значений”)

int Prompt(string message)
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArray(int[] array, int min, int max)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    System.Console.Write(array[0]);
    for (int i = 1; i < length; i++)
    {
        System.Console.Write($", {array[i]}");
    }
}

int amountNumbers = Prompt("Введите длину массива");
int minNumber = Prompt("Введите минимальное значение в массиве");
int maxNumber = Prompt("Введите максимальное значение в массиве");

int[] numbers = new int[amountNumbers];

CreateArray(numbers, minNumber, maxNumber);
PrintArray(numbers);