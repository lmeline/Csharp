using System;

namespace poo
{
    public class Voiture
    {
       public string? Marque;
       public string? Modele;
       public string? Couleur;
       public int Cylindree;
       public int NbPortes;

        // méthodes
        public void Demarrer(){
            Console.WriteLine("vroum ");
        }

        public void Freiner(){
            Console.WriteLine("hiiiiii ");
        }

        public override string ToString(){
            return $"Marque : {Marque}, Modele : {Modele}, Couleur : {Couleur}, Cylindree : {Cylindree}, NbPortes : {NbPortes}";
        }
    }
 }
