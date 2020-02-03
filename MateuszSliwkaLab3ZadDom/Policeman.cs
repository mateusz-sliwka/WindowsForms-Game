using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab1ZadDom
{
    class Policeman : Enemy //klasa policjanta dziedziczaca po Enemy
    {
        public Policeman(string name) //konstruktor klasy policjanta
        {
            this.name = name; //ustawienie nazwy
        }
        public override void toDistrupt(ref List<Alcohol> alcoholList, ref int gameTime, ref int points) //klasa zaklocajaca
        {
            points = (int)(points * 0.7); //pomniejsze punktow o 30%
        }
    }
}
