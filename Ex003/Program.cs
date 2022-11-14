Console.WriteLine("Введите имя");
string a = Console.ReadLine();
if (a.ToLower() == "маша") 
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(a);
}
