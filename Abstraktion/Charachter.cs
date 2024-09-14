using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktion
{
    //skapar en abstrakt klass som inte går att skapa ett objekt utav
    //abstrakta klasser fungerar enbart som en mall för subklasserna
    //I detta exemplet tänker jag mig ett tv spel. I spel så kan man inte välja att vara en "charachter", utan...
    //man måste välja en specifik klass som orc eller wizard. Men klasserna är uppbyggda på samma struktur
    //de har alla tex ett namn, en ordinarie attack och en unik special attack
    //därför har man den abstrakta klassen som en mall för alla subklasser
    abstract class Charachter
    {
        public string name;

        //en vanlig klass som är samma för alla subklasser
        public void attack()
        {
            Console.WriteLine(name + " attacks");
        }

        //en abstrakt klass som varje subklass måste overridea och ange vad denna klass ska göra
        public abstract void special_attack();
    }

    class Orc : Charachter 
    {
        //anger vad orcens special attack är
        public override void special_attack()
        {
            Console.WriteLine(name + " uses his twohanded axe to deal a devastating blow!");   
        }

    }

    class Wizard : Charachter
    {
        //anger vad wizards special attack är
        public override void special_attack() 
        {
            Console.WriteLine(name + " uses his staff to shoot fire at the enemy!");
        }       
    }

}
