// Задача 2: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number%10;
        number /= 10;
    }
    return sum;
}

int number = Prompt("Введите целое число");
System.Console.WriteLine($"Сумма цифр в введенном Вами числе равна => {SumNumbers(number)}");