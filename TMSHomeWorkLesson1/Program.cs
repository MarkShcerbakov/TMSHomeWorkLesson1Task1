using ClassLibrary1;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Homework after lesson 1 in TMS school.");

Console.WriteLine("Введите ваше ФИО:"); // Commit 5
string name = Console.ReadLine();
Console.WriteLine("Введите вашу дату рождения (дд.мм.гггг):"); // Commit 6
string birthdate = Console.ReadLine(); // Commit 4

Person person = new(name, birthdate); // Commit2

Console.WriteLine($"Ваши данные: {person.Name}, дата рождения: {person.Birthdate}");
Console.ReadKey(); // Commit1
