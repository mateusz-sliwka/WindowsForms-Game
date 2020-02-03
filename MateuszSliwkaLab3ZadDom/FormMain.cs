using MateuszSliwkaLab3ZadDom;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace MateuszSliwkaLab1ZadDom
{

    public partial class FormMain : Form
    {
        private readonly Func<SqlConnection> dbConnectionLapButle = () => new SqlConnection(ConfigurationManager.ConnectionStrings["LapButle"].ConnectionString);
        List<Alcohol> alcoholList = new List<Alcohol>();
        List<GameResult> ranking = new List<GameResult>();
        Enemy[] enemyTable = new Enemy[3];
        int gameTime = 31, disturbTime = 0, points = 0; //inicjalizacja zmiennych odpowiedzialnych za czas gry, poczatkowy moment zaklocenia i poczatkowe punkty 
        Vodka vodka; //inicjalizujemy zmienne do przechowywania trunkow i wrogow
        Beer beer;
        Wine wine;
        Champagne champagne;
        Whisky whisky;
        Homebrew homebrew;
        Mom mom;
        Friend friend;
        Policeman policeman;
        Random random = new Random(); //obiekt klasy Random, ktory wykorzystywany bedzie do generowania liczb losowych
        StreamWriter streamWriter; //inicjalizujemy writer zapisujacy logi do pliku
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources/point.wav"); //player odtwarzajacy dzwiek zdobycia pkt
        System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(@"Resources/wtf.wav"); //player odtwarzajacy dzwiek zaklocenia
        System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(@"Resources/ok.wav"); //player odtwarzajacy dzwiek konca gry
        System.Media.SoundPlayer player4 = new System.Media.SoundPlayer(@"Resources/start.wav"); //player odtwarzajacy dzwiek startu gry
        public FormMain()
        {
            InitializeComponent();
          
            resultLabel.Text = points.ToString();

        }

        public void initializeRank() //funkcja inicjalizujaca ranking
        {
            using (var connection = dbConnectionLapButle()) //bazujemy na zdefiniowanym globalnie polaczeniu z baza
            {
           
                connection.Open(); //otwieramy polaczenie
                using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT ID,Nickname, Result FROM Results", connection)) //bazujemy na wszystkich wierszach tabeli Result
                {
            
                    DataTable table = new DataTable(); //tworzymy nowa datatable
                    adapter.Fill(table); //wypelniamy je wynikiemz zapytania
                    rankGridView.DataSource = table; //ustawiamy je jako zrodlo danych tabeli z rankingiem
                }
                connection.Close();
            }
            rankGridView.Columns[0].ReadOnly = true; //ustawienie kolumn ID i wynik na niezmienialny
            rankGridView.Columns[2].ReadOnly = true;
            ((DataTable)rankGridView.DataSource).AcceptChanges();
          
        }

        public void generateStartPointsSystem() //wypisanie poczatkowej punktacji do przygotowanych labeli
        {
            policeman = new Policeman("Policjant"); //tworzymy nowe obiekty wrogow
            mom = new Mom("Mama");
            friend = new Friend("Ziomeczek");
            enemyTable[0] = friend; //dodajemy obiekty wrogow do tablic
            enemyTable[1] = mom;
            enemyTable[2] = policeman;
            vodka = new Vodka("Żołądkowa", 5); //tworzymy nowe obiekty trunkow
            beer = new Beer("Harnas", 1);
            wine = new Wine("Carlo Rossi", 2);
            champagne = new Champagne("Moet", 3);
            whisky = new Whisky("JackDaniels", 4);
            homebrew = new Homebrew("Samogon", 6);
            alcoholList.Clear();//czyscimy liste
            alcoholList.Add(vodka);//dodajemy obiekty trunkow do listy
            alcoholList.Add(beer);
            alcoholList.Add(homebrew);
            alcoholList.Add(champagne);
            alcoholList.Add(whisky);
            alcoholList.Add(wine);
            refreshPointTable();

        }




        public void refreshPointTable() //funkcja odswiezajace tabele punktacji
        {
            homebrewPointsLabel.Text = homebrew.getPercents().ToString(); //wypisanie punktow alkoholi do labeli na ekranie
            vodkaPointsLabel.Text = vodka.getPercents().ToString();
            whiskyPointsLabel.Text = whisky.getPercents().ToString();
            champagnePointsLabel.Text = champagne.getPercents().ToString();
            winePointsLabel.Text = wine.getPercents().ToString();
            beerPointsLabel.Text = beer.getPercents().ToString();
        }

        public void disturbTheGame() //funckcja wywolujaca zaklocenie gry
        {

            player2.Play(); //odtworzenie dzwieku
            int index = random.Next(0, 2); //wylosowanie indexu wroga sposrod 3 dostepnych
            String name = enemyTable[index].getName(); //pobranie imienia wroga
            string info = "Po zamknieciu okna masz 2 sekundy na start gry."; //ustawienie komunikatu dla gracza
            enemyTable[index].toDistrupt(ref alcoholList, ref gameTime, ref points); //wywolanie metody zaklocenia na obiekcie wroga
            if (enemyTable[index] is Mom) //sprawdzenie typu wroga i wysweitlenie adekwatnego komunikatu i zapisu do logow
            {
                MessageBox.Show("Uwaga! Przychodzi " + name + " i sprzata szafke z alkoholem! Punkta sie zmienia." + info);//komunikat
                streamWriter.WriteLine("Przyszła " + name + " i posprzatala. Punktacja sie zmienila.");//zapis do logow
                refreshPointTable(); //odswiezenie tabeli punktacji
            }
            else if (enemyTable[index] is Policeman)
            {
                MessageBox.Show("O nie! To " + name + "! Dostajesz punkty karne! " + info);
                streamWriter.WriteLine("Przyszedł " + name + " i dal mandat. Punkty zmniejszaja sie.");
                pointsLabel.Text = points.ToString(); //odswiezenie punktacji
            }
            else if (enemyTable[index] is Friend)
            {
                MessageBox.Show("Wbija twój " + name + " i pijecie kolejke! Dostajesz 5 sekund więcej! " + info);
                streamWriter.WriteLine("Przyszedł " + name + " i wypiliście kolejke. Dostajesz dodatkowe 5 sek.");
                timeLabel.Text = gameTime.ToString(); //odswiezenie czasu gry
            }


            disturbTime = -100; //wylaczenie zaklocania, potrzebne w przypadtku otrzymywanie bonusowego czasu po to zeby wydarzenie zaklocenia sie nie zapetlalo
        }

        public void swapLocation(PictureBox x, PictureBox y) //funkcja zamieniajaca dwa PictureBoxy polozeniem
        {
            Point location_temp = x.Location; //zapamietanie do zmiennej lokalizacji jednego
            x.Location = y.Location; //przypisanie temu wczesniej zapisanemu nowej lokalizacji
            y.Location = location_temp; //przypisanie drugiemu zapamietanej wczesniej lokalizacji pierwszego

        }
        public void swapLocation(int x) //wywolanie funkcji decydujacej o postaci zamiany PictureBoxow
        {
            // instrukcje warunkowe sprawdzaja jaki jest x i wzgledem tego dobieraja kombinacje zmian miejsca, zabieg celowy dla urozmaicenia zamian miejscami
            if (x == 0)
            {
                swapLocation(whiskyBox, homebrewBox);
                swapLocation(wineBox, vodkaBox);
                swapLocation(beerBox, champagneBox);
            }
            else if (x == 1)
            {
                swapLocation(beerBox, homebrewBox);
                swapLocation(wineBox, vodkaBox);
                swapLocation(whiskyBox, champagneBox);
            }
            else if (x == 2)
            {
                swapLocation(whiskyBox, vodkaBox);
                swapLocation(wineBox, champagneBox);
                swapLocation(beerBox, homebrewBox);
            }
            else if (x == 3)
            {
                swapLocation(beerBox, homebrewBox);
                swapLocation(champagneBox, whiskyBox);
                swapLocation(vodkaBox, wineBox);
            }
        }
        private void timerGame_Tick(object sender, EventArgs e) //funkcja opisujaca tick glownego zegara gry
        {

            gameTime--; //zmneijszenie czasu do konca gry o 1
            if (gameTime == disturbTime) //sprawdzenie czy obecny czas gry to moment wywolania zaklocenia
            {
                timerGame.Stop(); //jezeli tak to zatrzymujemy timer czasus gry
                swapTimer.Stop(); //zatrzymanie timera zamian miejscami
                disturbTheGame(); //wywolujemy funkcje generujaca zaklocenie
                swapTimer.Start(); //wznawiamy timer zamiany miejscami
                Thread.Sleep(2000); //po zamknieciu okna zaklocenia dajemy 2sek graczowi na przyzwyczajenie sie do nowego stanu
                timerGame.Start(); //wznawiamy timer czasu gry

            }

            if (gameTime < 10)
                timeLabel.Text = "0:0" + gameTime; //jesli czas gry mniejszy od 0 to dodajemy 0 na miejscu dziesiatek sekundy i minut w zegarze
            else
                timeLabel.Text = "0:" + gameTime; //jezeli wiekszy to dodajemy 0 tylko na miejsce minut

            if (gameTime ==0) //warunek sprawdzajacy czy czas dobiegl konca
            {
                swapTimer.Stop(); //zatrzymanujemy timer zamiany pictureBoxow
                timerGame.Stop(); //zatrzymujemy timer gry
                player3.Play(); //odtwarzamy dzwiek zakonczenia 
                MessageBox.Show("Koniec czasu! Zdobyles " + points + " pkt! Historia zostala gry zapisana do pliku wynik.txt"); //pokazujemy komunikat z wynikiem koncowym
                resultLabel.Text = points.ToString(); //zmiana tresci labela o zdobytych puntktach
                streamWriter.WriteLine("W sumie zdobyles #" + points.ToString() + "# punktów!"); //wypisujemy wynik do logow
                streamWriter.Close(); //zamkniecie writera
                readGameLog(); //odczytanie logow z pliku do dataView zapisu stanu gry
                initializeRank(); //odczytanie rankingu graczy z bazy danych
                resultGroupBox.Visible = true; //wyswietlenie ekranu koncowego gry

            }

        }

        private void startGameButton_Click(object sender, EventArgs e) //funkcja wywolywana po klikneciu przycisku startujacego gre
        {

            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName; //szukamy sciezki folderu z .exe
            string fileName = Path.Combine(path, "lastGame.txt"); //dodajemy do sciezki nazwe
            drinkLabel.ForeColor = Color.Black; //przywracamy domyslny kolor poczatkowemu labelowi
            if (File.Exists(fileName)) //sprawdzamy czy istnieje plik z wczesniejszymi logami
            {
                if (streamWriter != null)//jezeli jest otwarta operacja zapisu na pliku (np ktos nie dokonczyl ostatniej gry w danym cyklu aplikacji) to 
                    streamWriter.Close(); //zamykamy writer
                StreamReader streamReader = new StreamReader(fileName); //tworzymy nowy reader logow
                string lastLine = ""; //definiujemy zmienna pomocnicza
                while (streamReader.EndOfStream == false) //iterujemy po pliku
                {
                    lastLine = streamReader.ReadLine(); //przypisujemy kolejne linie do zmiennej pomocniczej az do lini ostatniej
                }
                try
                {
                    string lastPoints = lastLine.Split('#')[1];  //na koncu poprawnych logow punkty maja postac #POINTS#, wyodebrniamy wiec je ze stringa
                    drinkLabel.Text = "Ostatni wynik to: " + lastPoints + ". Spróbuj go pobić!"; //zmieniamy label na pokazujacy ostatni wyni k
                }
                catch (IndexOutOfRangeException) { } //jezeli linia ma nieprawdilowa postac to pomijamy odczyt logow, program dalej dziala
                streamReader.Close(); //zamykamy reader

            }

            streamWriter = new StreamWriter(fileName); //tworzymy nowy Writer
            player4.Play();  //odtworzenie dzwieku startu
            generateStartPointsSystem(); //wygenerowanie tabeli punktacji
            disturbTime = random.Next(1, 30); //wylosowanie momentu wygenerowania zaklocenia
            points = 0; //wyzerowanie licznika
            pointsLabel.Text = points.ToString(); //wyzerowanie labela licznika
            gameTime = 31; //przywrocenie domyslnego czasu gry
            timerGame.Interval = 1000; //ustawienie interwalu glownego timera gry na 1sek
            timerGame.Start(); //uruchomienie glownego timera gry
            swapTimer.Interval = 2000; //ustawienie interwalu timera zamiany miejscami na 2sek
            swapTimer.Start(); //uruchomienie timera zamiany
            startGameButton.Visible = false; //wygaszenie przycisku od rozpoczecia gry
            gameGroup.Visible = true; //pokazanie grupy komponenetow od gry wlasciwej
        }

        private void homebrewBox_Click(object sender, EventArgs e) //funkcja wywolywana po klikneciu bimbru
        {

            homebrew.drink(ref points, ref pointsLabel, ref player, ref streamWriter, ref drinkLabel);  //wywolanie funkcji drink obiektu, 
                                                                                                        //przekazanie referencji na punktacje, jej labelke, sound player, writer i label aktualnej cznnosci gry
            homebrewTimer.Stop();//zatrzymujemy timer
            homebrewBox.Visible = false;//"znikamy" dany trunek juz klikniety
        }

        /* PONIZSZE FUNKCJE DZIALAJA IDENTYCZNIE JAK homebrewBox_Click, dotycza poprostu innych butelek */
        private void whiskyBox_Click(object sender, EventArgs e)
        {
            whisky.drink(ref points, ref pointsLabel, ref player, ref streamWriter, ref drinkLabel);
            whiskyBox.Visible = false;
            whiskyTimer.Stop();
        }
        private void vodkaBox_Click(object sender, EventArgs e)
        {
            vodka.drink(ref points, ref pointsLabel, ref player, ref streamWriter, ref drinkLabel);
            vodkaBox.Visible = false;
            vodkaTimer.Stop();
        }

        private void champagneBox_Click(object sender, EventArgs e)
        {
            champagne.drink(ref points, ref pointsLabel, ref player, ref streamWriter, ref drinkLabel);
            champagneBox.Visible = false;
            champagneTimer.Stop();
        }

        private void wineBox_Click(object sender, EventArgs e)
        {
            wine.drink(ref points, ref pointsLabel, ref player, ref streamWriter, ref drinkLabel);
            wineBox.Visible = false;
            wineTimer.Stop();
        }

        private void beerBox_Click(object sender, EventArgs e)
        {
            beer.drink(ref points, ref pointsLabel, ref player, ref streamWriter, ref drinkLabel);
            beerBox.Visible = false;
            beerTimer.Stop();
        }

        private void swapTimer_Tick(object sender, EventArgs e) //funkcja wywolywana co kazdy interwal zegara zamiany butelek miejscami
        {
            swapLocation(random.Next(0, 3)); //wywolanie funkcji zamiany
            champagneTimer.Interval = 1600; //ustawienie interwalu dobranego dla danego alkoholu wzgledem poczatkowej punktacji, najmniej pktowane pokazuja sie najdluzej
            champagneTimer.Start(); //uruchomienie timera danego alkoholu
            champagneBox.Visible = true; //pokazanie butelki

            /*RESZTA TEJ FUNKCJI JEST ANALOGICZNA DLA FRAGMENTU WYZEJ, DOTYCZY POZOSTALYCH BUTELEK */
            Thread.Sleep(100);
            wineTimer.Interval = 1200;
            wineTimer.Start();
            wineBox.Visible = true;
            Thread.Sleep(100);
            beerTimer.Interval = 1400;
            beerTimer.Start();
            beerBox.Visible = true;
            Thread.Sleep(100);
            vodkaTimer.Interval = 1000;
            vodkaTimer.Start();
            vodkaBox.Visible = true;
            Thread.Sleep(100);
            homebrewTimer.Interval = 800;
            homebrewTimer.Start();
            homebrewBox.Visible = true;
            Thread.Sleep(100);
            whiskyTimer.Interval = 600;
            whiskyTimer.Start();
            whiskyBox.Visible = true;
        }


        private void whiskyTimer_Tick(object sender, EventArgs e) //funkcja wywolywana co interwal timera danej butelki 
        {
            whiskyTimer.Stop(); //zatrzymanie timera
            whiskyBox.Visible = false; //ukrycie butelki
        }

        /* PONIZSZE FUNKCJE DZIALAJA ANALOGICZNIE DO TICKA OPISANEGO WYZEJ, DOTYCZA POPROSTU INNYCH BUTELEK */
        private void beerTimer_Tick(object sender, EventArgs e)
        {
            beerTimer.Stop();
            beerBox.Visible = false;
        }

        private void wineTimer_Tick(object sender, EventArgs e)
        {
            wineTimer.Stop();
            wineBox.Visible = false;
        }
        private void homebrewTimer_Tick(object sender, EventArgs e)
        {
            homebrewTimer.Stop();
            homebrewBox.Visible = false;
        }
        private void champagneTimer_Tick(object sender, EventArgs e)
        {
            champagneTimer.Stop();
            champagneBox.Visible = false;
        }

        private void vodkaTimer_Tick(object sender, EventArgs e)
        {
            vodkaTimer.Stop();
            vodkaBox.Visible = false;
        }


        private void addToRankButton_Click(object sender, EventArgs e) //dodanie wyniku do rankingu na skutek wcisniecia przycisku
        {
            GameResult gameResult = new GameResult(rankNameTextBox.Text, points); //utworzenie nowego obiektu klasy gameResult
            gameResult.InsertIntoDB(); //wywolanie na nim metody przeslania do bazy utworzony wyniku
            initializeRank();
        }

       
        private void refreshDB() //metoda odswiezajaca baze po wykonaniu operacji na tabeli 
        {
            DataTable newTable = ((DataTable)rankGridView.DataSource).GetChanges(); //stworzenie DataTable zawierajacej zmiany wzgledem poczatkowego stanu tabeli
            if (newTable != null) //petla sprawdzajaca czy zmiany zaszly
               
                    using (var connection = dbConnectionLapButle()) //dzialamy na polaczeniu zadeklarowanym globalnie
                    {
                        connection.Open(); //otwieramy polaczenie
                        SqlDataAdapter dataAdpater = new SqlDataAdapter("SELECT ID, Nickname, Result FROM Results", connection); //pobieramy obiekty na jakich dzialamy
                        dataAdpater.UpdateCommand = new SqlCommand("UPDATE Results SET Nickname = @Nickname, Result = @Result " + "WHERE ID = @ID", connection);
                        dataAdpater.UpdateCommand.Parameters.Add("@Nickname", SqlDbType.VarChar, 20, "Nickname");
                        dataAdpater.UpdateCommand.Parameters.Add("@Result", SqlDbType.Int, 4, "Result");

                        SqlParameter parameter2 = dataAdpater.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int);
                        parameter2.SourceColumn = "ID";
                        parameter2.SourceVersion = DataRowVersion.Original;

                        dataAdpater.DeleteCommand = new SqlCommand("DELETE FROM Results " + "WHERE ID = @ID", connection); //definiujemy query usuniecia obiektow

                        SqlParameter parameter = dataAdpater.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int); //przypisujemy wartosc parametru ID
                        parameter.SourceColumn = "ID";
                        parameter.SourceVersion = DataRowVersion.Original;

                        DataTable categoryTable = new DataTable(); //tworzymy nowa tabele
                        dataAdpater.Fill(categoryTable); //wypelniamy ja wynikiem query
                        dataAdpater.Update(newTable); //odswiezamy nasz gridView
                        connection.Close();
                    }
                     ((DataTable)rankGridView.DataSource).AcceptChanges(); //przyjmujemy stan po akcji jako poczatkowy
       
                
      
        }

        private void readGameLog() //funkcja odczytujaca logi z pliku
        {
            List<string> przebieg = new List<string>(); //lista gdzie bedziemy przechocywac logi
            string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName; //szukamy sciezki folderu z .exe
            string fileName = Path.Combine(path, "lastGame.txt"); //dodajemy do sciezki nazwe
        
            if (File.Exists(fileName)) //sprawdzamy czy napewno ostatnia gra juz sie zapisala
            {
               
                    if (streamWriter != null)//jezeli jest otwarta operacja zapisu na pliku (np ktos nie dokonczyl ostatniej gry w danym cyklu aplikacji) to 
                        streamWriter.Close(); //zamykamy writer
                    StreamReader streamReader = new StreamReader(fileName); //tworzymy nowy reader logow
         

                while (streamReader.EndOfStream == false) //iterujemy po pliku
                    {
           
                        przebieg.Add(streamReader.ReadLine()); //dodanie linijki do listy stringow
                    }
            
                    streamReader.Close(); //zamykamy reader
                }
                else
                {
                    przebieg.Add("Odczyt nieudany!"); //jezeli sie nie uda odczytac logow to wypisujemy informacje
                }
        
            DataTable dataTable= new DataTable(); //tworzymy nowa DataTable 

            dataTable.Columns.Add("Akcja"); //dodajemy mu kolumne  

            foreach (string akcja in przebieg) //iterujemy po tablicy stringow z logami
            {
                dataTable.Rows.Add(akcja); //dodajemy pojednynczy log jako wiersz
            }
            gameLogGridView.DataSource =dataTable; //przypisujemy utowrzona DataTable jako zrodlo danych gridView logów

        }

        private void deleteRowsButton_Click(object sender, EventArgs e) //funkcja wcisniecia przycisku usuniecia wiersza
        {
            foreach (DataGridViewRow item in rankGridView.SelectedRows) //funkcja iterujaca po wybranych wierszach
                rankGridView.Rows.RemoveAt(item.Index); //i je usuwajaca z tabeli
            refreshDB(); //odswiezanie bazy danych po usunieciu wierszy w tabeli
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) //funkcja zmiany zawartosci komorki
        {
            refreshDB(); //odswiezenia bazy danych po updacie danych tabeli
        }

     

        private void playAgainButton_Click(object sender, EventArgs e) //funkcja wywolana podczas klikniecia przycisku zagraj jeszcze raz
        {
            resultGroupBox.Visible = false;
            startGameButton_Click(this, null); //zasymulowanie klikniecia przycisku nowa gra = uruchomienie gry od nowa
        }
    }
}
