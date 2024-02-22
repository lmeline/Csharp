
const char LIGNE_HORIZONTALE = '\u2550' ;
const char LIGNE_VERTICALE = '\u2551' ;
const char COIN_HAUT_GAUCHE ='\u2554' ;
const char COIN_HAUT_DROITE ='\u2557' ;
const char COIN_BAS_GAUCHE = '\u255A' ;
const char COIN_BAS_DROITE = '\u255D' ; 

/*const int NB_LIGNES = 5;
// const int NB_COLONNES = 5;

Rectangle(4,9);
Rectangle(8,25);

void Rectangle(int lignes, int colonnes ){

    Console.WriteLine();
    Console.Write(COIN_HAUT_GAUCHE);
    for (int i=0; i<colonnes;i ++){
        Console.Write(LIGNE_HORIZONTALE);
    }
    Console.Write(COIN_HAUT_DROITE);  

    for (int i =0; i<lignes; i++){
        Console.WriteLine();
        Console.Write(LIGNE_VERTICALE);
        for (int j=0; j<colonnes; j++ ){
            Console.Write(" ");
        }
        Console.Write(LIGNE_VERTICALE);
    }
        

    Console.WriteLine();
    Console.Write(COIN_BAS_GAUCHE);
    for (int i = 0; i<colonnes; i++) {
        Console.Write(LIGNE_HORIZONTALE);
    }
    Console.Write(COIN_BAS_DROITE);

    int surface_rectangle = Surface(colonnes, lignes);
    Console.WriteLine(surface_rectangle);
}

int Surface(int largeur, int hauteur){
    int surface = largeur * hauteur;
    Console.WriteLine();
    return surface;
} */

void encadre(string texte) {
// Calculer la hauteur et la largeur 
   string[] lignes = texte.Split('\n');
   int nb_lignes = lignes.Length;
   

   int nb_colonnes = 0;
   for (int i=0 ; i< lignes.Length; i++){
        Console.WriteLine(lignes[i]+ " " + lignes[i].Length);
        if (lignes[i]> nb_colonnes); 
        nb_colonnes = lignes[i].Length ;
   }
  
   
}
    Console.WriteLine($"{nb_lignes} lignes");
    Console.WriteLine($"{nb_colonnes} colonnes");

// ecriture de la 1ère ligne 
Console.Write(COIN_HAUT_GAUCHE + new string(LIGNE_HORIZONTALE,nb_colonnes) + COIN_HAUT_DROITE);
for (int i = 0; i< lignes.Length; i++) {
    Console.WriteLine(lignes[i]);
}
// ecriture des lignes du milieu 
for (int i = 0; i< lignes.Length;i++) {
    Console.WriteLine(LIGNE_VERTICALE + lignes[i]+ new string (' ', (nb_colonnes - lignes[i].Length)) + LIGNE_VERTICALE); 
}

// ecriture de la derniere ligne 
Console.WriteLine(COIN_BAS_GAUCHE + new string(LIGNE_HORIZONTALE,nb_colonnes)+ COIN_BAS_DROITE);

encadre("Bonjour\nlesamis\nComment vous allez ?" );