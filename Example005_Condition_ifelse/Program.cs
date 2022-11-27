Console.Write("Введите ваше имя!");
string userName = Console.ReadLine();

if (userName == "Маша")
{
    Console.WriteLine("Привет Машуля!");
} else {
    Console.Write("Привет, гость: ");
    Console.WriteLine(userName + "!");
}
