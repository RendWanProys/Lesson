try{
 Console.WriteLine("Введите прибыль за прошлый месяц:");
    double profitLastMonth = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите себестоимость за прошлый месяц:");
    double costLastMonth = double.Parse(Console.ReadLine());
    double costThisMonth = costLastMonth * 0.95; // Уменьшение на 5%
    double rent = (profitLastMonth / costThisMonth) * 100;
    Console.WriteLine($"Рентабельность работы предприятия за месяц: {rent:F1}%");
}
catch{
    
}