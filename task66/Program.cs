    Console.Clear();
    Console.Write("Задайте значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Задайте значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(sumNaturalNum(m, n));

  int sumNaturalNum(int m, int n, int sum = 0)
{
    if (m == n + 1)
    {
        return sum;
    }
    sum = sum + m;
    m++;
    return sumNaturalNum(m, n, sum);
}