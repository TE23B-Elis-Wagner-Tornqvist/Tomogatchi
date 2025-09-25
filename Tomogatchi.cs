
using System.IO.Compression;

public class Tomogatchi
{
    private int Hunger;
    private int Boredom;
    private List<string> Words = [];
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
        Console.WriteLine($"{Name} lärde sig {Word}");
        Words.Add(Word);
        ReduceBordedom();
    }

    public void Tick()
    {

        Hunger++;
        Boredom++;

         
        
    }

    public void PrintStats()
    {
        Console.WriteLine($" {Name} är såhär uttråkad: {Boredom}, såhär hungrig: {Hunger} och den kan {Words.Count} ord");
    }

    public void GetAlive()
    {
        if (IsAlive == true)
        {
            Console.WriteLine("Den lever yippie");

        }
        
         if (Hunger > 10 || Boredom > 10)
        {
            IsAlive = false;

        }
        

 if (IsAlive == false)
        {
            Console.WriteLine("Den död bre");

        }

    }

    private void ReduceBordedom()
    {
        Boredom -= 1;
    }


}
