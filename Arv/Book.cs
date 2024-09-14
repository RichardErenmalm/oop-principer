using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    //basklass Book som representerar alla typer av böcker
    public class Book
    {
        //Attribut som alla böcker har
        public int pages;
        public string title;

        //metod som representerar att du tar fram boken ur bokhyllan
        public void takeBookshelf()
        {
            Console.WriteLine("Du tar fram boken ur bokhyllan");
        }

        //metod som representerar att man läser boken
        public void readBook()
        {
            Console.WriteLine("Du tar upp boken och läser");
        }

        //metod som representerar att man lägger tillbaka boken i bokhyllan
        public void putBootShelf()
        {
            Console.WriteLine("Du lägger tillbaka boken i bokhyllan");
        }
    }


    //subklass som ärver alla egenskaperna från Book klassen
    public class Expository : Book
    {
        //string för referenslistan i boken. Detta görs i subklassen eftersom det är unikt för ...
        //faktabaserade böcker att ha en referenslista. Fiction har inte det.
        public string referencelist;


        //metod för att faktakolla referenserna. Återigen sär detta i subklassen eftersom alla...
        // typer av böcker inte har en referenslista som man kan faktakolla och ska då inte vara...
        //inuti Book klassen
        public void checkFacts()
        {
            Console.WriteLine("Du fakta kollar referenserna... Det verkar stämma!");
        }
    }
}
