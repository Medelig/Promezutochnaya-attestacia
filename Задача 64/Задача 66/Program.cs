//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.Write("Введите значение М ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N ");
int N = Convert.ToInt32(Console.ReadLine());
if (M<=N)
{
    int sum = Sum(M,N);
    Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
}
else
{
    Console.WriteLine("Ошибка. Проверьте введенные числа");
}
int Sum(int start, int end)
{
    if (start > end)
    {
        return 0;
    }
    else
    {
        return start + Sum(start + 1, end);
    }
}

