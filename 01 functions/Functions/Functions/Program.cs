using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Functions
{
    internal class Program
    {
      string[] vragen = new string[] {
            "How long do you think you'd survive in a zombie apocalypse?",
            "What secret conspiracy would you like to actually start letting other people know?",
            "If you can still remember, what are your funniest childhood memories??",
            "What would you do if you won a million dollars??",
            "Why do round pizzas come in square boxes?",
            "Has someone caught you dancing in front of the mirror?",
            "Have you ever tried talking to a animal?",
            "What would you call a male ladybug?",
            "Which species would be the rudest if all animals could talk?"
        };
        static void Main(string[] args)

        {
            Program program = new Program();
            program.Run(); //dit is een program

        }
        internal void Run()
        {
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();

        }
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);

        }
        internal void Vraag2()
        {
            Console.WriteLine("- What secret conspiracy would you like to actually start letting other people know?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);

        }
        internal void Vraag3()
        {
            Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);


        }
        internal void Vraag4()
        {
            Console.WriteLine(" What would you do if you won a million dollars?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);


        }
        internal void Vraag5()
        {
            Console.WriteLine("What is the worst game you played but that you liked anyway?");
            string antwoord = Console.ReadLine();
            Console.WriteLine(antwoord);


        }
        internal string Vraag7()
        {
            Console.WriteLine("What would you call a male ladybug ?");
            string antwoord = Console.ReadLine();
            return antwoord;
        }
        internal string Getvraag(int vraagIndex)
        {
            return vragen[vraagIndex];

        }
        internal string GetRANDOMvraag()
        {
            Random vraag = new Random();
            int intr = vraag.Next(0, vragen.Length);
            return vragen[intr];

        }
    }
}