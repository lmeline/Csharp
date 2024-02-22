//Table de multiplication 
//1 Saisir la table de multiplication (Saisir un nombre)
//2 Boucle for pour afficher la table de multiplication
// Borne supérieure = constante 

// Boucle for 
//for (int i = 0; i < 5; i ++ ) {
  //  Console.WriteLine(i+1);
//}
//bool continuer = true;
//while (continuer){
  //  ...
   // continuer = false;
//}

Console.Write("Entrez votre valeur : ");
int valeur = int.Parse(Console.ReadLine());
const int a = 5;
for (int i = 0; i < a; i++) {
    Console.WriteLine(i*valeur);
}