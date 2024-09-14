using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism
{
    class Fighter
    {
        public string name;

        //skapar en virtual metod vilket betyder att subklasserna kan välja att behålla matoden som den är eller overridea den
        public virtual void attack()
        {
            Console.WriteLine(name + " does a jab,cross!");
        }
    }

    class Khabib : Fighter
    {
        //overridear metoden vilket betyder att denna versionen kommer att köras istället för original versionen av khabib objekt
        public override void attack()
        {
            Console.WriteLine("Khabib pushes you against the fence and secures a takedwon!");
        }
    }
}
