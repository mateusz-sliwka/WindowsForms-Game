using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab1ZadDom
{
    //Opis ponizszej klasy jest tozsamy dla klas Beer/Vodka/Champage/Wine/Homebrew
    enum WhiskyType { ROZWODNIONA, SZKOCKA }; //klasa trunku ma swoj enum mowiacy o dwoch cechach jakie moze miec w zaleznosci od ustawionych procentow
    class Whisky : Alcohol //definicja klasy, ustawienie dziedizenia po klasie Alcohol
    {
        WhiskyType type; //klasa Whisky ma pole WhiskyType
        public Whisky(string name, int percents) //konstruktor klasy przyjmujacy jako argument nazwe i procenty do ustawienia, po ich ustawieniu sprawdza typ/ceche trunku
        {
            this.name = name;
            this.percents = percents;
            checkType();
        }
   
        public WhiskyType getType() {  //metoda zwracajaca typ/ceche trunku
            return this.type;
            }

   
        public override void checkType() //metoda sprawdzajaca i zmieniajca typ w zaleznosci od procentow
        {
            if (this.percents > 0)
                this.type = WhiskyType.SZKOCKA;
            else
                this.type = WhiskyType.ROZWODNIONA;
        }
 
    
        public override void drink(ref int points, ref System.Windows.Forms.Label label, ref System.Media.SoundPlayer player, ref StreamWriter sw, ref System.Windows.Forms.Label drinkLabel)
        {
            //funkcja picia trunku operujaca na referencjach do obiektow Formsa

            points += this.getPercents(); //zwikeszenie punktacji gracza 
            label.Text = points.ToString(); //odswiezenie labela wyswietlajacaego punktacje gracza
            player.Play(); //odtworzenie dzwieku zdobycia punktu
            if (percents < 0) //zmiana koloru informacji o czynnosci w zaleznosci od procentu/znaku zdobytego punktu
                drinkLabel.ForeColor = System.Drawing.Color.Red;
            else
                drinkLabel.ForeColor = System.Drawing.Color.Green;
            drinkLabel.Text = "Wypiles " + this.getType() + " whisky " + this.getName() + "! " + this.getPercents() + "pkt"; //zmiana labela informacji o czynnosci
            sw.WriteLine(drinkLabel.Text); //zapis czynnosci do logow

        }
    }
}
