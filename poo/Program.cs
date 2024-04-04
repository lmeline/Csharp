using poo;

string a = "ABC" ;
Console.WriteLine(a.ToLower());
Voiture maVoiture1 = new Voiture(); // instancier l'objet 
Voiture maVoiture2 = new Voiture();
// Voiture = classe, maVoiture = objet 

maVoiture1.Demarrer(); // invoquer la méthode demarrer de la classe maVoiture 
maVoiture1.Freiner();

maVoiture2.Demarrer(); 
maVoiture2.Freiner();

// donne des valeurs aux propriétés de voiture1
maVoiture1.Marque = "nissan";
maVoiture1.Modele = "promax";
maVoiture1.Couleur = "rouge";
maVoiture1.Cylindree = 1000;
maVoiture1.NbPortes = 5;

// donne des valeurs aux propriétés de voiture2
maVoiture2.Marque = "dacia";
maVoiture2.Modele = "sandero";
maVoiture2.Couleur = "verte";
maVoiture2.Cylindree = 500;
maVoiture2.NbPortes = 3;
// Affiche les propriétés de Voiture1
Console.WriteLine(maVoiture1.ToString());
// Affiche les propriétés de Voiture2
Console.WriteLine(maVoiture2.ToString());
