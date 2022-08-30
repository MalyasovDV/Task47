float NextFloat()
{
    Random rnd = new Random();
    double mantissa = (rnd.NextDouble() * 2.0) - 1.0;
    return (float)Math.Round((Decimal)(mantissa * rnd.Next(-10,10)), 1);
}

void ArrayGeneration(int m, int n, ref float[,] array)
{
    for (int i = 0; i < m; ++i)
        for (int j = 0; j < n; ++j)
            array[i,j] = NextFloat();
}

void Output(int m, int n, ref float[,] array)
{   
    Console.WriteLine("\n Here's the array");
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
            Console.Write(+ array[i,j] + ";  ");
        Console.WriteLine();
    }
}

int m,n;
Console.WriteLine("Enter scales of the array M x N");
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
float[,] array = new float[m,n];

ArrayGeneration(m, n, ref array);
Output(m, n, ref array);