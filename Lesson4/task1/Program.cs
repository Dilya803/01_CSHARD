//int[,] maxtrix = new int[3, 5];

//Random rnd = new Random();
//for (int i = 0; i < maxtrix.GetLength(0); i++)
//{
    //for (int j = 0; j < maxtrix.GetLength(1); j++)
    //{
       // maxtrix[i, j] = rnd.Next(1, 11);
    //}
//}

//for (int i = 0; i < maxtrix.GetLength(0); i++)
//{
    //for (int j = 0; j < maxtrix.GetLength(1); j++)
    //{
        //Console.Write($"{maxtrix[i, j]} ");
    //}
    //Console.WriteLine();
//}

int[,] CreatMaxtrix(int rowCount, int columsCount)
{
    int[,] maxtrix = new int[rowCount, columsCount];

    Random rnd = new Random();
    for (int i = 0; i < maxtrix.GetLength(0); i++)
    {
        for (int j = 0; j < maxtrix.GetLength(1); j++)
        {
            maxtrix[i, j] = rnd.Next(1, 11);
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

int[,] maxtrix = CreatMaxtrix(4, 5);
ShowMaxtrix(maxtrix);