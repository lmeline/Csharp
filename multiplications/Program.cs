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


bool K = true;

while (K ==true) {
    Console.Write("Entrez votre valeur : ");
    string valeurStr = Console.ReadLine();
    if (int.TryParse(valeurStr, out int valeur)){
        const int a = 11;
        for (int i = 0; i < a; i++) {
            int b = i * valeur;
            Console.WriteLine($"{i} * {valeur} = {b} ");
            
        }
    
        Console.Write("Voulez-vous recommencer o/n ?");
        string reponse = Console.ReadLine();

        if (reponse == "o"){
           K =true; 

        } else {
            K = false;
        }
        
    } else
    {
        Console.WriteLine("Entrez une valeur numérique  ");
        K = true;
    }  
    Console.Write("Au revoir !");
}
  

