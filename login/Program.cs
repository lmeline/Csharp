using System;
using MySql.Data.MySqlClient;

namespace Login 
    {
        class Program
        {
            static void Main (string[] args)
            {
                Console.WriteLine("Login");
                string dsn ="Server=localhost;Database=login;username=root;password=;";

                MySqlConnection _connexion = new MySqlConnection(dsn);

            }
        }
















    }