// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNum(int m, int n){
    //Console.Write($"{num}, ");
    if(n == m) {
        return m;
    }
    return n + SumNum(m, n - 1);
}

Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int sum = SumNum(m,n);
Console.WriteLine($"Сумма от {m} до {n}: {sum}");