namespace Abstraktion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orc orc = new Orc();
            orc.name = "MR orc";

            //orc objektet utför attackmetoden som skapades i den abstrakta klassen
            orc.attack();
            //orc objektet utför special attack metoden som skapades i charachter klassen men...
            //bestämdes hur den skulle utföras i orc klassen
            orc.special_attack();

            Console.WriteLine();

            Wizard wizard = new Wizard();
            wizard.name = "Gandalf";

            //wizard objektet utför attackmetoden som specifierades i den abstrakta klassen
            wizard.attack();
            //wizard objektet utför special attack metoden som skapades i charachter klassen men...
            //bestämdes hur den skulle utföras i wizard klassen
            wizard.special_attack();


            Console.ReadLine();
        }
    }
}
