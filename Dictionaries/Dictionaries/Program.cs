namespace Dictionaries
{
    internal class Program
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();

        static void Main()
        {
            Program p = new Program();
            p.Run();
        }

        internal void Run()
        {
            personeelOpNummer.Add(382942, "jim");
            personeelOpNummer.Add(382943, "tim");

            string jim = personeelOpNummer[382942];
            string tim = personeelOpNummer[382943];

            Console.WriteLine(jim + "\n" + tim);

            foreach (KeyValuePair<int, string> item in personeelOpNummer)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }

    }
        }
    
