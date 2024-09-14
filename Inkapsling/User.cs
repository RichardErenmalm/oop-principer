using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inkapsling
{
    public class User
    {
        //privata attributer som bara går att nå innefrån klassen
        private string username;
        private string password;

        //konstruktor som säger att man måste ange username och password vid skapandet av ett user objekt
        //attributerna här är inte samma som de privata attributerna i klassen, dessa attributer finns bara...
        //medan konstruktorn körs, representerar de värden som man skriver in när man skapar ett objekt
        public User(string username, string password)
        { 
            //säger att string Username och Password är lika med konstruktorns username och password, alltså det...
            //inskrivna värdet när man skapar objektet. det aktiverar också koden inuti Username och Password
            Username = username;
            Password = password;    
        }

        //en string propertie som hämtar och sätter värdet av username
        //det är "mellanhanden" som gör att man kan modifiera och se privat information utanför klassen utan att man har...
        //direkt kontakt med den
        public string Username
        {
            //hämtar värdet av privata username, används när man kallar på Username utanför klassen
            get { return username; }
            //ger privata username samma värde som "value", alltså värdet vi tillgav Username. Används när man ska...
            //ändra värdet på privata username, som i detta fallet när vi skapar ett objekt av User klassen
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
           
    }

    

}
