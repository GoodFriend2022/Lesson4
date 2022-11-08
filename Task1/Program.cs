// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int NumberPower(int number, int power)
{
    if (power == 1) return number;
    return number * NumberPower(number, power - 1);
}

int number = Prompt("Введите число, которое хотите возвести в степень");
int power = Prompt("Введите степень, в которую хотите возвести число");
System.Console.WriteLine($"{number} в степени {power} равно => {NumberPower(number, power)}");





