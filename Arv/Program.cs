


namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //skapar ett objekt av klassen Book
            Book book1 = new Book();

            //tillsätter värden till attributerna
            book1.title = "Kalle anka";
            book1.pages = 243;

            //utför metoderna
            book1.takeBookshelf();
            book1.readBook();
            book1.putBootShelf();

            Console.WriteLine("");

            //Skapar ett objekt av subklassen Expository
            Expository expository1 = new Expository();

            //tillsätter värde till attributerna från basklassen
            expository1.title = "Atomic habits";
            expository1.pages = 320;
            //tillsätter värde till attributern från subklassen
            expository1.referencelist = "Influence: The psychology of persuasion - Robert Ciadini, Fogg behaviour model - B.j Fogg etc etc...";

            //kallar på metoderna från basklassen
            expository1.takeBookshelf();
            expository1.readBook();
            expository1.putBootShelf();

            //kallar på metoden från subklassen
            expository1.checkFacts();

            Console.ReadLine();
        }
    }


}
