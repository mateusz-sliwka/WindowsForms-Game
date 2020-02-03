using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab1ZadDom
{
    abstract public class Alcohol //klasa abstrykcja Alkohol
    {
        protected string name; //zawiera dwa pola typu protected tak aby klasy mogly je odziedziczyc
        protected int percents;

        private static readonly Random random = new Random(); //posiada jedno pole uzywane tylko w metodzie nieabstrakcyjnej zadeklarowanejnizej, moze byc wiec prywatne
        

      public virtual void changePercents() //metoda zmieniajaca procenty alkoholu, dodajaca do niego losowa liczbe calkowita
        {
            this.percents += random.Next(-7,5);
            checkType(); //wywolanie funkcji sprawdzajacej typ danego trunku po zmianie procentow
        }

       public virtual String getName() //funkcja zwracajaca nazwe
        {
            return name;
        }
        public virtual void setName(String name) //funkcja pozwalajca na zmiane nazwy
        {
            this.name = name;
        }
        public virtual int getPercents() //funkcja zwracajaca procenty
        {
            return percents;
        }
        public virtual void setPercents(int percents) //funckja zmieniajca procenty
        {
            this.percents = percents;
            checkType();
        }
        abstract public void checkType(); //metoda abstrakcyjna ktora bedzie deklarowana w klasach dziedziczacych
       

        abstract public void drink(ref int points, ref System.Windows.Forms.Label label, ref System.Media.SoundPlayer player, ref StreamWriter sw, ref System.Windows.Forms.Label drinkLabel);
    //abstrakcyjna metoda picia ktora dziala na referencji punktow, labeli, soundplayera i streamwritera, bedzie definiowana w klsach dziedziczacych
    }
}
