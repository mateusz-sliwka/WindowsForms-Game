using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab1ZadDom
{
    class Friend : Enemy //klasa przyjaciela dziedczy po klasie Enemy
    {
        public Friend(string name) //konstruktor klasy
        {
            this.name = name; //ustawienie nazwy
        }
        public override void toDistrupt(ref List<Alcohol> alcoholList, ref int gameTime, ref int points)
        {
            gameTime += 5; //w ramach "przeszkodzenia" w grze czas wydluza sie o 5sek
        }
    }
}
