try{
 Console.WriteLine("Введите x");
 double x =double.Parse(Console.ReadLine());
  Console.WriteLine("Введите y");
 double y =double.Parse(Console.ReadLine());
  Console.WriteLine("Введите t");
 double t =double.Parse(Console.ReadLine());
double P = (Math.Pow(Math.Sin(x), 3) + Math.Log(2 * y + 3 * x)) / (Math.Pow(t, Math.E) + Math.Sqrt(x));
Console.WriteLine("P = "+P);
}
catch
{
    Console.WriteLine("Введите данные правильно!");
}