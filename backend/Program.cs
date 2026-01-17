
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Морозова Олеся Сергеевна");
// Console.WriteLine(DateTime.Now);

System.Console.Write("Введите ваше имя: ");
string? name = Console.ReadLine();
System.Console.WriteLine($"Привет, {name}!");
System.Console.WriteLine(DateTime.Now.DayOfWeek.ToString());
System.Console.Write("Хотите продолжить? (y/n) ");
string? answer = Console.ReadLine();
if (answer == "y" || answer == "Y")
{
    System.Console.WriteLine("Продолжаем...");
}
else if (answer == "n" || answer == "N")
{
    System.Console.WriteLine("Остановка");
}
else
{
    System.Console.WriteLine("Попробуйте снова");
}