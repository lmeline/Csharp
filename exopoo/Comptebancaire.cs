using System;

namespace exopoo
{
    public class Comptebancaire
    {
        // privés
        private int _solde; 
        public int Solde 
       {
            get {return _solde;}

            set
            {
                if(value>0);
            }
            _solde = value;
       }
       private bool Actif;
       {
        get{return _actif;}
       } 

        // propriété de lecture seule
        public string ? Nom;
        public string ? Prenom;
       

       // propriété en lecture/écriture 
       private int _decouvertautorise;
       

        int DecouvertAutorise
        {
            get {return _decouvertautorise;}

            set
            {
                if (value<0 || value >100)
                throw new Exception ("le decouvert nest pas autorisé");
            }
            _decouvertautorise = value;
        }


        // Méthodes 
        public void Crediter(){
            Console.WriteLine("ajout argent ");
        }
        public void Debiter (){
            Console.WriteLine("perte d'argent ");
        }
        public void Activer (){
            _actif = true;
        }
        public void Desactiver(){
            _actif = false;
        }

        // constructeur par défaut 
        public Comptebancaire()
        {
            this.Nom = string.Empty;
            this.Prenom = string.Empty;
            solde = 0;
            DecouvertAutorise = 0;
            _actif = true;
        }
        // Constructeur avec des paramètres
        public Comptebancaire(string Nom, string Prenom)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
        }

        public override string ToString()
        {
            return $"Nom : {Nom}, prenom : {Prenom}, Solde : {solde}, Actif : {Actif}, decouvert : {Decouvert}";
        }
        }
    }   

}

