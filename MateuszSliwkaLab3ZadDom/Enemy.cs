using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab1ZadDom
{
    abstract class Enemy //klasa wroga, ktory przeszkadza w grze
    {
        protected string name; //wrog ma pole name, jest ustawione na protected zeby klasy dziedzizace je odziedziczyly
     
        public string getName() //getter pola name zwracajacy jego wartosc
        {
            return name;
        }
        public void setName (string name) //setter pola name zmieniajacy jego wartosc na te z argumentu
        {
            this.name = name;
        }
        abstract public void toDistrupt(ref List<Alcohol> alcoholList, ref int gameTime, ref int points); 
        //metoda abstrakcyjna, ktora bedzie zadeklarowana w klasach dziedziczacych, dziala on an referencji do listy trunkow, czasu gry i punktow gracza
    }
}
