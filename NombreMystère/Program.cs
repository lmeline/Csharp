const int MAX =100;
const int MIN = 1;
const int NOMBRE_MYSTERE = 82;

Console.Write("Veuillez entrer votre prénom : ");
string prenom = Console.ReadLine();

bool trouve = false;
// pour créer une liste 
List<int> nombreSaisis = new List<int>();

while(! trouve){
    int nbSaisi = 0;

    Console.WriteLine("Nombre déjà proposés :" );
    foreach (int nb in nombreSaisis) {

        Console.Write($"{nb} ");

    Console.Write($"Entrez un nombre entre {MIN} et {MAX} : ");
    nbSaisi =int.Parse(Console.ReadLine());
    nombreSaisis.Add(nbSaisi);
    }

    if (nbSaisi==NOMBRE_MYSTERE) {
        Console.Write("Vous avez trouvé");
        trouve = true;

    } else {
        if (nbSaisi>NOMBRE_MYSTERE)
            Console.WriteLine("Votre nombre est trop grand ");
            else 
            Console.WriteLine("Votre nombre est trop petit ");
    }
}

