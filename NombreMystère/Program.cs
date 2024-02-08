
// Demander un nbr mystère entre 1 et 100 sous forme de constante entière.
const int NOMBRE_MYSTERE = 12;
const int MIN = 1;
const int MAX = 1OO;
// Demander le nom de l'utilisateur et afficher un message de bienvenue personnalisé.

Console.WriteLine("Bonjour, quel est votre prénom ?");
string reponse = Console.ReadLine();

Console.WriteLine($"Bonjour, bienvenue {reponse} ! ");

// Demander un nbr à l'utilisateur et le stocker dans une variable entière.
Console.Write($"Entrez un nombre entre {MIN} et {MAX} ? ");

string chaine = Console.ReadLine();
int nbr = int.Parse(chaine);


