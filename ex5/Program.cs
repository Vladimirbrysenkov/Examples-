Write("Введите имя пользователя: ");
string username = ReadLine();

if(username.ToLower() == "маша")
{
    WriteLine("Ура, это Маша!");
}
else
{
    Write("Привет, ");
    WriteLine(username);
}