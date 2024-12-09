using constructors.constructors;

namespace constructors
{
    internal class Quiz
    {
        internal QuizVraag[] vragen = new QuizVraag[10];
        internal QuizVraagAntwoord[] ingevuldeAntwoorden;
        internal int score;

        internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
        {
            vragen[index] = vraag;
        }

        internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            QuizVraag nieuweVraag = new QuizVraag(vraag, antwoord);
            VoegVraagToeOpIndex(index, nieuweVraag);
        }

        internal void StelVraag(int index)
        {
            QuizVraag vraag = vragen[index];
            QuizVraagAntwoord quizVraagAntwoord = new QuizVraagAntwoord(vraag);

            Console.WriteLine(vraag.vraag);

            if (Console.ReadLine().ToLower() == vraag.antwoord.ToLower())
            {
                quizVraagAntwoord.goed = true;
                Console.WriteLine("GOED!");
                Score(1);
            }
            else
            {
                quizVraagAntwoord.goed = false;
                Console.WriteLine("FOUT! je bent tanto dom");
            }
        }  
        internal void Score(int add) 
        {
            score =+ add;
        }
    }
}
