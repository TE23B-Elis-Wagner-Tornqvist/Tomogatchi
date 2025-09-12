
using System.IO.Compression;

public class Tomogatchi
{
    private int Hunger;
    private int Boredom;
    private List<string> Words;
    private bool IsAlive;
    public string Name;


    public Tomogatchi()
    {
        IsAlive = true;
    }

    public void Feed()
    {
        Console.WriteLine($"{Name} äter en donut och är inte lika hungrig längre!");
        Hunger -= 1;
    }

    public void Hi()
    {
        Console.WriteLine("Hej min kompis!");
        ReduceBordedom();
    }

    public void Teach(string Word)
    {
        Words.Add(Word);
        Console.WriteLine($"{Word}");
        ReduceBordedom();
    }

    public void Tick()
    {

        Hunger++;
        Boredom++;

          if (Hunger > 10 || Boredom > 10)
            {
                IsAlive = false;
                
            }
        
    }

    public void PrintStats()
    {
        Console.WriteLine($" {Name} är såhär uttråkad: {Boredom}, såhär hungrig: {Hunger} och den {IsAlive}");
    }

    public void GetAlive()
    {
       
    }

    private void ReduceBordedom()
    {
        Boredom -= 1;
    }


}
