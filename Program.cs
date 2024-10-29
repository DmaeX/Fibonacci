// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

int CalcNth(int n)
{
    if (n == 1 || n == 2)
        return 1;

    return CalcNth(n - 2) + CalcNth(n - 1);
}


int DonnaMaeFib(int n)
{
    int n1 = 1;
    int n2 = 1;

    if (n == 1)
    {
        return n1;
    }

    if (n == 2)
    {
        return n2;
    }

    for (int i = 0; i < n; i++)
    {
        int temp = n2;
        n2 = n2 + n1;
        n1 = temp;
    }

    return n2;
}

var sw = new Stopwatch();

sw.Start();

// 1 1 2 3 5 8
for (int i = 1; i < 40; i++)
{
    Console.WriteLine(CalcNth(i));
}

sw.Stop();

// 1 2 3 4 5
// 1 1 2 3 5


Console.WriteLine($"Runtime took {sw.ElapsedMilliseconds}ms");