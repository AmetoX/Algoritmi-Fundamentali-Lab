problema1();
Console.WriteLine();
problema2();

static void problema1()
{
    Random random = new Random();
    int n = random.Next(5, 25);
    int m = random.Next(5, 25);
    char[,] matr = new char[n, m];
    char a = 'a';
    char b = 'A';
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (j % 2 == 0)
            {
                matr[i, j] = a;
            }
            else
            {
                matr[i, j] = b;
            }
        }
        a++;
        b++;
    }
    viewMatrix(matr);
}
static void problema2()
{
    int n = 8;
    int[,] matr = new int[n, n];
    int nr = n;
    for (int i = 0; i < n; i++)
    {
        nr = n - i;
        for (int j = 0; j < n; j++)
        {

            if (i + j == n - 1)
            {
                matr[i, j] = 0;
            }
            if (i + j < n - 1)
            {
                matr[i, j] = nr - 1;
                nr--;
            }
            else
            {
                matr[i, j] = nr - 1;
                nr++;
            }
        }
    }
    viewMatrix2(matr);
}
static void viewMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static void viewMatrix2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}