int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Matrix 1:");
int[,] a = new int[n,m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == j)
        {
            a[i, j] = 1;
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{a[i, j], 3} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Matrix 2:");
int[,] b = new int[n,m];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < m; j++)
    {
        if (i <= j)
        {
            b[i, j] = j - i + 1;
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{b[i, j], 3} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Matrix 3:");
int[,] c = new int[n,m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i >= j)
        {
            c[i, j] = j + 1;
        }
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{c[i, j], 3} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Matrix 4:");
int[,] d = new int[n,m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        d[i, j] = n - i - j;
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{d[i, j], 3} ");
    }
    Console.WriteLine();
}
