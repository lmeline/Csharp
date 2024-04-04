using System;

namespace exopoo
{
    public class Comptebancaire
    {
        public string ? Nom;
        public string ? Prenom;
       private int _solde; 

       public int solde 
       {
            get {return _solde}

            set
            {

            }

       }

        int DecouvertAutorise
        {
            get {return _decouvertautorise}

            set
            {
                ....
            }
        }

        public void Crediter(){
            Console.WriteLine("ajout argent ");
        }

        public void Debiter (){
            Console.WriteLine("perte d'argent ");
        }

        public void Activer (){
            Console.WriteLine("actif");
        }

        public void Desactiver(){
            Console.WriteLine("pas activer");
        }

        public Comptebancaire()
        {
            this.Nom = string.Empty;
            this.Prenom = string.Empty;
            solde = 0;
            DecouvertAutorise = 0;
        }
        public Comptebancaire(string Nom, string Prenom)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
        }

    }   

}

