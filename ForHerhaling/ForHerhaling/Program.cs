namespace ForHerhaling;

internal class Program
{
    private double[] prijzen = new double[] { 0.99, 5.60, 10.11, 100.99 };
    private string[] artiekelen = { "snoepje", "luxe broodje", "lunch menu", "brootje" };
    private Formulier[] formulieren = new Formulier[2];

    static void Main()
    {
        Program p = new Program();
        p.Run();
    }

    internal void Run()
    {
        formulieren[0] = new Formulier()
        {
            Feedback = "prijzeg maar lekker",
            Sterren = 5
        };
        formulieren[1] = new Formulier()
        {
            Feedback = "lunch menu was erg veel",
            Sterren = 3
        };

        for (int i = 0; i < prijzen.Length; i++)
        {
            Console.WriteLine(prijzen[i]);
            Console.WriteLine(artiekelen[i]);
        }

        foreach (Formulier formulier in formulieren)
        {
            Console.WriteLine(formulier.Feedback.ToString());
            Console.WriteLine(formulier.Sterren.ToString());
        }
    }
}