// second programm. Say 'Hello' to definite user.
string username;
for(int i = 0; i < 3; i++)
{
    Console.Write("Введите имя пользователя: ");
    username = Console.ReadLine();

    if(username.ToLower() == "masha")
    {
        Console.WriteLine("WOW! This is Masha!");
    }
    else if(username == "")
    {
        Console.WriteLine("Nobody came. =(");
    }
    else
    {
        Console.Write("Hello,  ");
        Console.WriteLine(username);
    }
}