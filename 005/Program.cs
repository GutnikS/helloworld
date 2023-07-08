// приветствие пользователя в зависимости от имени
Console.Write ("Как тебя зовут? ");
string username = Console.ReadLine();

if (username.ToLower() == "алиса") //оператор выравнивания шрифта
{
    Console.WriteLine ("Привет Алиса. Будешь чай?");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}