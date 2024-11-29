using System.Runtime.InteropServices;

namespace classes_asem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.run();
        }

        internal void run()
        {
            Console.WriteLine("hello world");

            Auto auto1 = new Auto()
            {
                automaat = true,
                kenteken = "AA824H",
                kilometerstand = 20567,
                merk = "volkswagen"
            };
            Auto auto2 = new Auto()
            {
                automaat = false,
                kenteken = "KU786G0",
                kilometerstand = 65739,
                merk = "volvo"
            };
            Rijleraar rijleraar = new Rijleraar()
            {
                leeftijd = 30,
                naam = "john",
                zzp = false
            };
            LesUur lesUur = new LesUur()
            {
                auto = auto1,
                rijleraar = rijleraar,
                tijd = 1130
            };


            LesPakket lesPakket = new LesPakket()
            {
                automaat = false,
                examenPogingen = 2,
                urenGekocht = 13,
                urenVebruikt = 9
            };

            TheroieTest theorieTest = new TheroieTest()
            {
                aantalFouten = 1,
                gehaald = true,
                afnameDatum = DateTime.Now
            };

            RijTest rijTest = new RijTest()
            {
                gehaald = true,
                afnameDatum = DateTime.Now,
            };

            Student student1 = new Student()
            {
                naam = "bob",
                leeftijd = 30,
                lespakket = lesPakket,
                leraar = rijleraar,
                theorieTest = theorieTest,
                RijTest = rijTest
            };

            LesUur lesUur1 = new LesUur()
            {
                auto = auto1,
                rijleraar = rijleraar,
                tijd = 1130,
                student = student1
            };

        }

    }
}