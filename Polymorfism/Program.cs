namespace Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter1 = new Fighter();
            fighter1.name = "Francis Nganou";
            //objekt av typen Fighter utför standard versionen av attack metoden
            fighter1.attack();

            Console.WriteLine("");

            Khabib khabib1 = new Khabib();
            //objekt av typen khabib utför den ändrade versionan av attack metoden
            khabib1.attack();

            Console.ReadLine();
            
        }
    }
}
