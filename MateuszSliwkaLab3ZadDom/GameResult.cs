using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszSliwkaLab3ZadDom
{
    

        class GameResult
    {
         //polaczenie z baza danych na podstawie connectionString skonfigurowanego w configu aplikacji
        private readonly Func<SqlConnection> dbConnectionLapButle = () => new SqlConnection(ConfigurationManager.ConnectionStrings["LapButle"].ConnectionString);


        public SqlCommand QuerySql { get; set; }
        public string Nickname { get; set; }
        public int Result { get; set; }

        //konstruktor parametryczny
        public GameResult(string username, int result)
        {
            Nickname = username; //ustawienie wartosci pola nickname
            Result = result; //ustawienie wartosci pola result
        }

        //metoda dodajaca gracza i wynik do rankingu
        public void InsertIntoDB()
        {
            string query = "INSERT INTO dbo.Results(Nickname, Result) VALUES (@Nickname,@Result)"; //poczatkowa postac zapytania
            using (var connection = dbConnectionLapButle()) //przyjecie wartosci polaczenia
            {
                connection.Open(); //otworzenie polaczenia 
                QuerySql = new SqlCommand(query, connection); //stworzneie nowej komendy query podczas polaczenia
                QuerySql.Parameters.Add(new SqlParameter("@Nickname", Nickname)); //ustawienie wartosci parametru nickname
                QuerySql.Parameters.Add(new SqlParameter("@Result", Result)); //oraz result
                QuerySql.ExecuteScalar(); //wykonanie zapytania
                connection.Close(); //zamkniecie polaczenie
            }

        }
    }
}
