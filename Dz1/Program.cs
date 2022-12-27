double [,] number = new double [3,4];
Random rnd = new Random();

{
for (int i = 0; i < number.GetLength(0); i++)
{
    for (int j = 0; j < number.GetLength(1); j++)
    {
        number [ i, j ] = rnd.NextDouble() * 10;
        Console.Write("{0,6:F2}", number[i, j]);
        Console.WriteLine();
    }

}
    
}


