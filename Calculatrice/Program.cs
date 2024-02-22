Console.WriteLine("Bienvenue dans la calculette !");

Console.Write("Entrez le premier nombre : ");

string s_nbr = Console.ReadLine();
decimal nbr;
if (decimal.TryParse(s_nbr, out nbr)== true){

} else {
    Console.WriteLine("Ca n'est pas possible ");
    Environment.Exit(0);
}

Console.Write("Entrez votre l'opérateur (+, -, /, %, *) : ");
string operateur = Console.ReadLine();

Console.Write("Entrez le deuxième nombre : ");
string s_nbr1 = Console.ReadLine();
decimal nbr1;
if (decimal.TryParse(s_nbr1, out nbr1)== true){
} else {
    Console.WriteLine("Ca n'est pas possible ");
    Environment.Exit(0);
}

if(operateur == "+" ){
    nbr = nbr + nbr1;
    Console.Write($"Le résultat est {nbr}");
} else if (operateur == "-") {
    nbr = nbr - nbr1;
    Console.Write($"Le résultat est {nbr}");
} else if (operateur == "*") {
   nbr = nbr * nbr1;
    Console.WriteLine($"Le résultat est {nbr}");
} else if(operateur == "/") {
    nbr = nbr / nbr1;
    System.Console.WriteLine($"Le résultat est {nbr}");
} else if (operateur == "%"){
    nbr = nbr % nbr1;
    System.Console.WriteLine($"Le résultat est {nbr}");
} else {
    System.Console.WriteLine("ça n'est pas possible.");
}
