// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAckermann(int m, int n){
    if(m == 0) {
        return n + 1;
    } else if (n == 0){
        return FunctionAckermann (m - 1, 1);
    }
    return FunctionAckermann(m - 1, FunctionAckermann (m, n - 1));
}

Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int ack = FunctionAckermann(m,n);
Console.WriteLine($"A({m},{n}) = {ack}");

