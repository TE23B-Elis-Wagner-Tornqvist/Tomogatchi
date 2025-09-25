
Tomogatchi MyOwnTamagotchi = new();


Console.WriteLine("Vad vill du att din Tama ska heta?");
MyOwnTamagotchi.Name = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"{MyOwnTamagotchi.Name} är ett fint namn!");
Console.Clear();

// MyOwnTamagotchi.PrintStats();
// MyOwnTamagotchi.Tick();
// MyOwnTamagotchi.PrintStats();
// MyOwnTamagotchi.Feed();
// MyOwnTamagotchi.PrintStats();
// MyOwnTamagotchi.Hi();
// MyOwnTamagotchi.PrintStats();
// MyOwnTamagotchi.Tick();
// MyOwnTamagotchi.PrintStats();
// MyOwnTamagotchi.GetAlive();

// while (MyOwnTamagotchi.GetAlive() == true)
// {

// }

Console.WriteLine($"Vad vill du göra med {MyOwnTamagotchi.Name}");
Console.WriteLine($"1: Prata med {MyOwnTamagotchi.Name} 2: Mata {MyOwnTamagotchi.Name} 3: Lära {MyOwnTamagotchi.Name} något nytt ord. 4: Göra inget alls!");
MyOwnTamagotchi.PrintStats();
string choice = Console.ReadLine();

if (choice == "1")
{
    MyOwnTamagotchi.Hi();
}
if (choice == "2")
{
    MyOwnTamagotchi.Feed();
}
if (choice == "3")
{
    Console.WriteLine($"Vad vill du lära {MyOwnTamagotchi.Name} För ord ");
string Word = Console.ReadLine() ?? string.Empty;
MyOwnTamagotchi.Teach(Word);
}
if (choice == "4")
{
    MyOwnTamagotchi.Tick();
}





Console.ReadLine(); 

