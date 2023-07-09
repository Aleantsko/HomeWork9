// See https://aka.ms/new-console-template for more information
int EnterNumber(string text)
{
    System.Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;
    else if (N == 0) return (M * (M + 1)) / 2;
    else if (M == N) return M;
    else if (M < N) return N + SumNumbers(M, N - 1);
    else return N + SumNumbers(M, N + 1);
}

int Accerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Accerman(m - 1, 1);
    if (m > 0 && n > 0) return Accerman(m - 1, Accerman(m, n - 1));
    return 0;
}


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M = EnterNumber("Введите число M:");
// int N = EnterNumber("Введите число N:");
// System.Console.WriteLine(SumNumbers(M, N));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int M = EnterNumber("Введите число M:");
int N = EnterNumber("Введите число N:");
int answer = Accerman(M, N);
System.Console.WriteLine("Ответ = " + answer);