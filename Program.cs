float NextFloat()
{
    Random rnd = new Random();
    double mantissa = (rnd.NextDouble() * 2.0) - 1.0;
    return (float)Math.Round((mantissa * rnd.Next(-10,10)), 1);
}

void MatrixGeneration(ref float[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            matrix[i,j] = NextFloat();
}

void Output(int m, int n, ref float[,] matrix)
{   
    Console.WriteLine("\n Here's the matrix");
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
            Console.Write(+ matrix[i,j] + ";  ");
        Console.WriteLine();
    }
}

int m,n;
Console.WriteLine("Enter scales of the matrix M x N");
m = int.Parse(Console.ReadLine());
n = int.Parse(Console.ReadLine());
float[,] matrix = new float[m,n];

MatrixGeneration(ref matrix);
Output(m, n, ref matrix);