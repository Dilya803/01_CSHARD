int[,] CreatMaxtrix(int rowCount, int columsCount)
{
    int[,] maxtrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < maxtrix.GetLength(0); i++)
    {
        for (int j = 0; j < maxtrix.GetLength(1); j++)
        {
            maxtrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return maxtrix;
}

void ShowMaxtrix(int[,] maxtrix)
{
    for (int i = 0; i < maxtrix.GetLength(0); i++)
    {
        for (int j = 0; j < maxtrix.GetLength(1); j++)
        {
            Console.Write($"{maxtrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] maxtrix = CreatMaxtrix(3, 4);
ShowMaxtrix(maxtrix);
Console.WriteLine();
foreach (int e in maxtrix)
{
    if (IsInteresting(e) == true)
    {
        Console.Write($"{e} ");
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetsumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;

}

int GetsumOfDigits(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum += value % 10;
        value /= 10;
    }
    return sum;
}