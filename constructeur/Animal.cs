using System;
using System.Security.Cryptography;

namespace constructeur
{

    public class Animal 
    {
        // chaine nullable 
        public string? Nom;

        // attribut 
        private int _age;

        // propriété
        public int Age
        {
            // acceseur en lecture 
            get { return_age; }

            // accesseur en écriture 
            set
            {
                if(value<0 || value > 100) // valeur invalide 
                throw new Exception ("L'âge doitvêtre entre 0 et 100 ans ");
            }
            _age = value;
        }

    // Constructeur par défaut(méthode spéciale qui porte le même nom que la classe et qui ne retourne pas de valeur)
    // méthode qui est appelée lors de l'instanciation de la classe
        public Animal()
        {
            Age = 0;
            this.Nom = string.Empty;
        }
    
       public Animal(string Nom, int Age) 
        {
           this.Nom = Nom;
           this.Age = Age;
        }
        public string Afficher() 
        {
            return this.Nom + " a " + this.Age + " ans ";
        }

        // Redéfinition de la méthode ToString() de la classe Object

        public override string ToString()
        {
            return "-------" + base.ToString() + "---------\nNom : " + this.Nom + "\nAge : " + this.Age;
        }
    }    
        

        
}