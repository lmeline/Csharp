
// Demander un nbr mystère entre 1 et 100 sous forme de constante entière.
const int NOMBRE_MYSTERE = 100;

// Demander le nom de l'utilisateur et afficher un message de bienvenue personnalisé.

Console.WriteLine("Bonjour, quel est votre prénom ?");
string reponse = Console.ReadLine();

Console.WriteLine($"Bonjour, bienvenue {reponse} ! ");

// Demander un nbr à l'utilisateur et le stocker dans une variable entière.
Console.Write("Entrez un nombre entre 0 et 100 ? ");

string chaine = Console.ReadLine();
int nbr = int.Parse(chaine);


