try{
 Console.WriteLine("Введите номер квартиры: от 1 до 15");
int n = int.Parse(Console.ReadLine());
if (n>=1&&n<=15)
Console.WriteLine($"Этаж={(n-1)/3+1}");
}
catch
{
    Console.WriteLine("Введите данные правильно!");
}
