using System;

namespace constructeur 
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciation de la classe Animal 
            Animal _animal = new Animal("Médor",5);

            // Affectation des valeurs aux propriétés de la classe Animal (set)
            //_animal.Nom = "Médor";
           // _animal.Age = 5;

            // Affichage des valeurs des propriétés de la classe Animal(get, lire)
            Console.WriteLine(_animal.Nom + " a "+ _animal.Age+" ans ");
        }

    }
}