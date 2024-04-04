using MySql.Data.MySqlClient;
using System;

namespace Media 
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("test de mysql");
            // chaîne de connexion ou Data Server Name (DSN)
            string _connexionString ="Server=localhost;Database=media;Username=root;Password=;";
            MySqlConnection _connexion = new MySqlConnection(_connexionString);
            // Ouverture de la connexion 

            try {
              _connexion.Open(); 
              Console.WriteLine("Connexion ouverte");

            // requête SQL
              string _sql = "SELECT nom , prenom, type_personne FROM personnes JOIN types_personnes ON types_personnes.id = personnes.type_personne_id";
              MySqlCommand _command = new MySqlCommand(_sql, _connexion);

            // Exécution de la requête
            MySqlDataReader _reader = _command.ExecuteReader();

           while(_reader.Read())
           {
                Console.WriteLine(_reader["nom"]+" | "+ _reader["prenom"]+" | "+ _reader["type_personne"]);

           }
           _reader.Close();

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _connexion.Close();
                Console.WriteLine("Connexion fermée");
            }
            
        }
    }
}