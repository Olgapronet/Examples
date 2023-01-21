Console.Clear();
System.Console.Write("Первое число: ");
int a =Convert.ToInt32(Console.ReadLine());
System.Console.Write("Второе число: ");
int b =Convert.ToInt32(Console.ReadLine());

if (a == (b * b))
{
    Console.WriteLine($"{a} квадрат {b}");
}
else
{
    System.Console.WriteLine("Не квадрат!");
}
