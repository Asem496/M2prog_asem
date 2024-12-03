using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using constructors.constructors;

namespace constructors
{
    internal class QuizVraagAntwoord
    {
        internal QuizVraag vraag;
        internal bool goed;
        internal QuizVraagAntwoord(QuizVraag vraag)
        {
            this.vraag = vraag;
            goed = false;
        }
    }
}