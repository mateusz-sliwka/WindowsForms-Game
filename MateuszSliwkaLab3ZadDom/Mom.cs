using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab1ZadDom
{
    class Mom : Enemy //klasa mamy dziedziczy po Enemy
    {
        public Mom(string name) //konstruktor klasy mamy
        {
            this.name = name; //ustawienie nazwy
        }

        public override void toDistrupt(ref List<Alcohol> alcoholList, ref int gameTime, ref int points) //klasa zaklocenia
        {
            foreach (Alcohol a in alcoholList) //itercja po liscie trunkow
            {
                a.changePercents(); //wywolanie metody zmiany procentow na kazdym z trunkow
            }
           
        }
    }
}
