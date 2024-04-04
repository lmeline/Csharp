using System;
using System.Security.Cryptography;

namespace constructeur
{

    public class Animal 
    {
        // chaine nullable 
        public string? Nom;
        public int Age;

    // Constructeur par défaut(méthode spéciale qui porte le même nom que la classe et qui ne retourne pas de valeur)
    // méthode qui est appelée lors de l'instanciation de la classe
        public Animal(string Nom, int Age) 
        {
           this.Nom = Nom;
           this.Age = Age;
        }
        
        public Animal()
        {
            
        }

        
    }
}