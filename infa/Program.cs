int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] a = new int[n,m];
int s1 = 0;
int s2 = 0;
int s3 = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        a[i, j] = 1;
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == 0 ||  i == n - 1)
        {
            s1 += a[i, j];
        } else if (j == 0  || j == n - 1)
        {
            s1 += a[i, j];
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == j || i == n - j)
        {
            s2 += a[i, j];
        }
    }
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (j >= i && j >= n - i)
        {
            s3 += a[i, j];
        } else if (j <= i && j <= n - i)
        {
            s3 += a[i, j];
        }
    }
}

Console.WriteLine($"5 - {s1}, 6 - {s2}, 7 - {s3}");
