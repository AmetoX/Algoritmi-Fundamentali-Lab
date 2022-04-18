int n = 10;
int m = 13;
int[,] matrice= new int[n,m];
int d = 1;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i==1 &&i - 1 >= 0 && j - 1 >= 0&&j<m-2)
        {
            matrice[i, j] = d;
            d++;
        }
        if (j == m - 2&&i!=0 && i<n-1)
        {
            matrice[i, j] = d;
            d++;
        }
    }    
}
for (int i = n-1; i > 0; i--)
{
    for (int j = m-1; j > 0; j--)
    {
        if(i==n-2 && j <= m - 3)
        {
            matrice[i, j] = d;
            d++;
        }
        if(i<n-2 && j<n-1 && i>1 && j<2)
        {
            matrice[i, j] = d;
            d++;
        }
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