// Demander le nom de l'utilisateur et afficher un message de bienvue personnalisé.
// 

Console.WriteLine("Bonjour comment tu t'appelles ?");
string a = Console.ReadLine();

Console.WriteLine($"Holà, bienvenido {a}");

Console.Write("Appuyez sur une touche pour quitter");
Console.ReadKey();

/* pour convertir une chaine en nbr entier 
string chaine = "2";
int nombre = int.Parse(chaine)
intnombre = Convert.ToInt32(chaine);

Console.WriteLine(nombre); */



