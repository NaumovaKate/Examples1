Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Урряя, это же МАША!");
    }
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}