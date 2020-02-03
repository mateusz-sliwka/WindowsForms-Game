using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab1ZadDom
{
    //Klasa dziala na identycznej zasadzie jak klasa Whisky, rozni sie tylko enumem mowiacym o typie/cesze trunku. W klasie whisky.cs jest caly opis
    enum WineType { TANIE, WYTRWANE };
    class Wine : Alcohol
    {
        WineType type;
        public Wine(string name, int percents)
        {
            this.name = name;
            this.percents = percents;
            checkType();
        }
 
        public WineType getType() { 
            return this.type;
            }

        public void setType(WineType type)
        {
            this.type = type;
        }

        public override void checkType()
        {
            if (this.percents > 0)
                this.type = WineType.WYTRWANE;
            else
                this.type = WineType.TANIE;
        }
  

        public override void drink(ref int points, ref System.Windows.Forms.Label label, ref System.Media.SoundPlayer player, ref StreamWriter sw, ref System.Windows.Forms.Label drinkLabel)
        {

            points += this.getPercents();
            label.Text = points.ToString();
            player.Play();
            if (percents < 0)
                drinkLabel.ForeColor = System.Drawing.Color.Red;
            else
                drinkLabel.ForeColor = System.Drawing.Color.Green;
            drinkLabel.Text = "Wypiles " + this.getType() + " wino " + this.getName() + "! " + this.getPercents() + "pkt";
            sw.WriteLine(drinkLabel.Text);

        }
    }
}
