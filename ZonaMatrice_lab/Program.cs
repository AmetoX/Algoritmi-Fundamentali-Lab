int n = 11;//linii
int m = 11;//coloane
int[,] matrice = new int[n,m];
viewMatrix(matrice);
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {

        if (i < j && i + j < n/2+1)
            matrice[i, j] = 1;
        if (i < j && i + j > n / 2 + 1)
            matrice[i, j] = 1;
        if (i < j/2 && i + j > n/2 - 1)
            
        if (i > j/2 && i + j > n/2 - 1)
            
        if (i > j && i + j < n/2 - 1)
            matrice[i, j] = 4;
    }
}
viewMatrix(matrice);

static void viewMatrix(int[,] matrix)
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
        