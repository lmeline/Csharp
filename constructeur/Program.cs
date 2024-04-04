using System;

namespace constructeur 
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciation de la classe Animal 
            Animal _animal = new Animal();

            // Affectation des valeurs aux propriétés de la classe Animal (set)
            _animal.Nom = "Médor";
            _animal.Age = -6;

        Console.WriteLine(_animal.Age);

            //string s =_animal.Afficher();
            //Console.WriteLine(s);
            
            //Console.WriteLine(_animal.ToString());
        }
    }
}