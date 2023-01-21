Console.Write("Введите имя пользователя: ");
string? name = Console.ReadLine();

if(name.ToLower() == "маша")
{
   Console.WriteLine("Ура, это же Маша!");
}

else
{
   Console.Write("Привет," + name);
   //Console.WriteLine(username);
}
