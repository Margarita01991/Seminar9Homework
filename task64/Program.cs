/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
void PrintNumber(int numberN, int numberM)
{
    if (numberM > numberN)
    {
        PrintNumber(numberN + 1, numberM);
        Console.Write(numberN + " ");
    }
    else if (numberN == numberM)
    {
        Console.Write(numberN + " ");
        return;
    }
    else
    {
        Console.WriteLine("Введено отрицательное число");
    }
}
Console.WriteLine("Введите положительное число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = 1;
PrintNumber(numberN, numberM);
