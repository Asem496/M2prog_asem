namespace Lists;

internal class Program
{
    private string[] characters = new[] { "Pac-Man", "Samus", "Crash Bandicoot", "Spyro the Dragon", "Donkey Kong", "Mario", "Luigi", "Astro", "Solid Snake", "Master Chief", "Kratos", "Sonic the Hedgehog", "Link" };
    private List<string> characterslist = new List<string>();
    private List<double> reviews = new List<double>() { 0.9, 4.1, 5.1, 6.1, 7.1, 8.1, 9.1, 10.1, 11.1, 12.5, 342.97 };
    private List<Pickup> pickups = new List<Pickup>();
    private List<Mob> mobs = new List<Mob>();
    static void Main()
    {
        Program p = new Program();
        p.Run();
    }

    internal void Run()
    {
        reviews.Remove(342.97);
        reviews.RemoveAt(0);
        foreach (string character in characters)
        {
            characterslist.Add(character);
            Console.WriteLine(character);
        }
        foreach (double review in reviews)
        {
            Console.WriteLine(review);
        }

        for (int i = 0; i < 10; i++)
        {
            Pickup pickup = new Pickup()
            {
                x = i,
                y = 0
            };
            pickups.Add(pickup);
        }

        //foreach (var pickup in pickups)
        //{
        //    if (pickup.x == 4)
        //    {
        //        pickups.Remove(pickup);
        //    }
        //}
        for (int i = pickups.Count - 1; i >= 0; i--)
        {
            if (pickups[i] == null)
            {
                Console.WriteLine("pickup " + i + " IS ER NIET");
                pickups.RemoveAt(i);
            }
            Console.WriteLine("pickup " + i + " is er wel");
        }

        Mob toad = new Mob()
        {
            hp = 100,
        };
        Mob mario = new Mob()
        {
            hp = 50,
        };
        mobs.Add(toad);
        mobs.Add(mario);

        mobs[0].TakeDamage(10);
        mobs[1].TakeDamage(200);
    }
}

class Pickup
{
    internal int x, y;
}

class Mob
{
    internal bool isDead;
    internal int hp = 10;

    internal void TakeDamage(int damage)
    {
        if (hp > 0)
        {
            hp -= damage;
        }
        else
        {
            ;
            hp = 0;
            isDead = true;
        }

        Console.WriteLine("hp is: " + hp);
        Console.WriteLine("isDead: " + isDead);
    }
}