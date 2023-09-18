Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

// функция ToLower() позволяет все символы строки перевести в нижний регистр
if (username.ToLower() == "masha")
{
    Console.WriteLine("Ура, это Masha!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}
