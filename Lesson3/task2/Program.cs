void PrintSquares (int Limit)
{
    int i = 1;
    while (i <= Limit)
    {
        Console.Write($"{i*i} ");
        i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);