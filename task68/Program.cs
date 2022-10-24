Console.Clear();

int minNum = 0;
minNum = AskForInput("наименьшее");
int maxNum = AskForInput("наибольшее");
int nod = minNum;

Console.WriteLine($"\n-> {PrintNOD(minNum, maxNum, nod)}");

int AskForInput(string str)
{
    while (true)
    {
        Console.Write($"\nВведите {str} натуральное число:");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            if (num > 0 && num > minNum)
            {
                return num;
            }
            else Console.WriteLine($"Некорректно указано {str} натуральное число!\n");
        }
        else Console.WriteLine($"Некорректно указано {str} натуральное число!\n");
    }
}

int PrintNOD(int minNum, int maxNum, int nod)
{
    return maxNum % nod == 0 && minNum % nod == 0 ? nod : PrintNOD(minNum, maxNum, nod - 1);
}