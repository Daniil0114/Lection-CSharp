Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "daniel") //.ToLower- позволяет все символы перевести в  нижний регистр
{
    Console.WriteLine("Hooray, it's Daniel");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}