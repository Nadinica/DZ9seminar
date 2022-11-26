//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

Console.WriteLine("Задайте значение M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= 4 || n > 10) Console.WriteLine("Ошибка, прошрамма не предназначена для вычисления таких больших значений. Уменьшите значение М");
else
{
    int Akkerman(int n, int m)
    {

        if (n == 0) return (m + 1);
        else if (n != 0 && m == 0) return Akkerman(n - 1, 1);
        else if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));

        return Akkerman(m, n);
    }
    Console.WriteLine(Akkerman(m, n));
}
