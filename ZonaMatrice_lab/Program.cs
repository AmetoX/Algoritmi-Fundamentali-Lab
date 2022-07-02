int n = 11;//linii
int m = 11;//coloane
int[,] matrice = new int[n,m];
viewMatrix(matrice);
Console.WriteLine();
//spirala
for (int j = 0; j < n / 2; j++)
{
    for (int i = j; i < n - 1 - j; i++)
        matrice[j, i] = 1;
    for (int i = j; i < n - 1 - j; i++)
        matrice[i, n - 1 - j] = 1;
    for (int i = n - 1 - j; i > j; i--)
        matrice[n - 1 - j, i] = 1;
    for(int i = n - 1 - j; i > 0; i--)
        matrice[i,j]=1;
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
        