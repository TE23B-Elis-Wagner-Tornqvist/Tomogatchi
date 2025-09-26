
using System.IO.Compression;

public class Tomogatchi
{
    private int Hunger;
    private int Boredom;
    private List<string> Words = ["Hello my friend!"];
    private bool IsAlive = true;
    public string Name = "";

    public void Feed()
    {
        Console.WriteLine($"{Name} äter en donut och är inte lika hungrig längre!");
        Hunger -= 2;
    }

    public void Hi()
    {
        int i = Random.Shared.Next(Words.Count);

        Console.WriteLine(Words[i]);
        ReduceBordedom();
    }

    public void Teach(string Word)
    {
        Console.WriteLine($"{Name} lärde sig {Word}");
        Words.Add(Word);
        ReduceBordedom();
    }

    public void Tick()
    {

        Hunger++;
        Boredom++;

     if (Hunger >= 10 || Boredom >= 10)
        {
            IsAlive = false;
            
        }


    }

    public void PrintStats()
    {
        Console.WriteLine($" {Name} är såhär uttråkad: {Boredom}, såhär hungrig: {Hunger} och den kan {Words.Count} ord");
    }

    public bool GetAlive()
    {

        return IsAlive; 

    }

    private void ReduceBordedom()
    {
        Boredom -= 1;
    }


}
