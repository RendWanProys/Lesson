Console.WriteLine("┌---------------------------------------┐");
Console.WriteLine($"|        x          |         y         |");
Console.WriteLine("|---------------------------------------|");
long factorial = 1;
for (double x = -1; x <= 2; x += 0.3)
{
    double y = 0;
    if (x > 0)
    {
        for (int k = 1; k <= 7; k++) y += Math.Pow(x, k) / (k!);
    }
    else y = Math.Atan(Math.Pow(double.Pi,x));
    Console.WriteLine($"|       {x,-5:F2}       |       {y,5:F2}       |");
}
Console.WriteLine("└---------------------------------------┘");
Console.WriteLine();