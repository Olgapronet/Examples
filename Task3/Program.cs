System.Console.Write("--> ");
int a = Convert.ToInt32(Console.ReadLine());

if ( (a < 1000) && (a > 99) ) {
    int b = a % 10;
    System.Console.WriteLine(b);
}

else
{
    System.Console.WriteLine("Ошибка");
}