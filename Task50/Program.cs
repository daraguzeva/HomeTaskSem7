// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] Meth(int M, int N) // Метод, создающий и заполняющий массив
{
    int[,] array = new int[M, N];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array; //Возвращаем массив
}

bool Poss(int[,] array, int A, int B) // Метод принимает на вход массив и номера позиции
{
    bool poss = false;
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int p = 0; p < array.GetLength(1); p++)
        {
            if (k == A && p == B)
            {
                poss = true;
            }
        }
    }
    return poss; // Возвращаем значение истина/ложь
}

int Num(int[,] array, int A, int B, bool poss) // Метод принимает на вход массив, номера позиции и значение bool
{
    int num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (A == i && B == j && poss == true)
            {
                num = array[i, j];
            }
        }
    }
    return num; // Возвращаем значение ячейки
}

Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] array = Meth(M, N);

Console.Write("Введите номер строки: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int B = Convert.ToInt32(Console.ReadLine());

bool poss = Poss(array, A, B);

int num = Num(array, A, B, poss);

if (poss == true)
{
    Console.Write($"Элемент на позиции [{A},{B}] существует и равен {num}");
}
else
{
    Console.Write("Такого элемента нет");
}
Console.WriteLine();
