Tomogatchi MyOwnTamagotchi = new();

Console.WriteLine("Vad vill du att din Tama ska heta?");
MyOwnTamagotchi.Name = Console.ReadLine() ?? string.Empty;
Console.WriteLine($"{MyOwnTamagotchi.Name} är ett fint namn!");

Console.Clear();

MyOwnTamagotchi.PrintStats();
Console.WriteLine($"Vad vill du göra med {MyOwnTamagotchi.Name}");
Console.WriteLine($"1: Prata med {MyOwnTamagotchi.Name} 2: Mata {MyOwnTamagotchi.Name} 3: Lära {MyOwnTamagotchi.Name} något nytt ord.");

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
    
}





// Console.WriteLine("Välj ett ord");
// string Word = Console.ReadLine();
// MyOwnTamagotchi.Teach(Word); 

// // pou.Tick();


Console.ReadLine(); 

