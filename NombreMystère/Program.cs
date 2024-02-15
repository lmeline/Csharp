
// Demander un nbr mystère entre 1 et 100 sous forme de constante entière.
const int NOMBRE_MYSTERE = 9;
const int MIN = 1;
const int MAX = 100;

// Demander le nom de l'utilisateur et afficher un message de bienvenue personnalisé.

Console.WriteLine("Bonjour, quel est votre prénom ?");
string reponse = Console.ReadLine();

Console.WriteLine($"Bonjour, bienvenue {reponse} ! ");

// Demander un nbr à l'utilisateur et le stocker dans une variable entière.


bool check = false ;

while(check == false) {
    Console.Write($"Entrez un nombre entre {MIN} et {MAX} (vide pour quitter) : ");
    string chaine = Console.ReadLine();
    if(chaine =="") {
        check = true;
        Console.Write($"La réponse était : {NOMBRE_MYSTERE} ");
        break;
    }   
        
    int nbr = int.Parse(chaine);

    if (nbr > NOMBRE_MYSTERE) {
        Console.WriteLine("Dommage tu n'as pas trouvé, ton nombre est trop grand ");
      //  Console.Write("Tu veux continuer (o/n) ? ");
      //  string ans = Console.ReadLine();
      //  if (ans == "n") {
      //      check = true;
      //  }
    } else if (nbr < NOMBRE_MYSTERE) {
        Console.WriteLine("Dommage tu n'as pas trouvé, ton nombre est trop petit ");
       // Console.Write("Tu veux continuer (o/n) ? ");
       // string ans = Console.ReadLine();
       // if (ans == "n") {
       //     check = true;
      //  }
    } else {
        Console.Write("Bravo tu as trouvé "); 
        check = true ;
    }
}


    

