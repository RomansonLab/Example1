﻿Console.WriteLine("Vvedite imya polzovatelys");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Preved Masha");
}
else
{
    Console.Write("A tebe tyt ne radi ");
    Console.WriteLine(username);
}
