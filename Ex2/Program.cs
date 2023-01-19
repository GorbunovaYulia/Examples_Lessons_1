Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{ 
    Console.WriteLine("Ура!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}