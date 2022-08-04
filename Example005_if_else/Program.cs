Console.Write("Who are you? ");
string user = Console.ReadLine();
if (user.ToLower() == "anna")
{
    Console.Write("Yeah! This is Anna!");
}
else
{
     Console.Write("Hello, ");
    Console.WriteLine(user);
}