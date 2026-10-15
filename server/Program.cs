Console.WriteLine("Добро пожаловать!");
Console.WriteLine("ФИО: Остапова Ульяна Александровна");
Console.WriteLine("Группа: ИСП-241");
Console.WriteLine("Текущая дата и время: " + DateTime.Now);

Console.WriteLine();
Console.WriteLine("Меню:");
Console.WriteLine("1 - Показать ФИО");
Console.WriteLine("2 - Показать группу");
Console.WriteLine("3 - Показать дату");
Console.WriteLine("4 - Выход");

Console.WriteLine("Выберите пункт: ");
string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        Console.WriteLine("ФИО: Остапова Ульяна Александровна");
        break;
    case "2":
        Console.WriteLine("Группа: ИСП-241");
        break;
    case "3":
        Console.WriteLine("Текущая дата и время: " + DateTime.Now);
        break;
    case "4":
        Console.WriteLine("Программа завершена.");
        break;
    default:
        Console.WriteLine("Такого пункта нет.");
        break;
}