﻿using ClassLibrary1;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Homework after lesson 1 in TMS school.");

Console.WriteLine("Введите ваше ФИО:");
string name = Console.ReadLine();
Console.WriteLine("Введите вашу дату рождения (дд.мм.гггг):");
string birthdate = Console.ReadLine();

Person person = new(name, birthdate);

Console.WriteLine($"Ваши данные: {person.Name}, дата рождения: {person.Birthdate}");
Console.ReadKey();