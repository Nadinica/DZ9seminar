// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
//промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5-> "5, 4, 3, 2, 1"
// N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"


string NumbersRec(int N, int b)
{
    if (N >= b) return $"{N} " + NumbersRec(N - 1, b);
    else return string.Empty;
}
Console.Write("Задайте значение N ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumbersRec(N, 1));
