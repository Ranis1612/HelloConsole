Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "гульназ" ) // ToLower() - операция позволяющая перевести все символы в нижний регистр
{
  Console.WriteLine("Привет Любимая!!!");  
}
else
{
  Console.WriteLine("Привет, " );
  Console.WriteLine(username);
}
