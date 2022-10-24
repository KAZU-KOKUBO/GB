    Console.Clear();
    Console.Write("Введите натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    desNum(n);

void desNum(int n)
{
    if (n == 0)
    {
        return;
    }
    Console.Write($"{n} ");
    n--;
    desNum(n);
}

