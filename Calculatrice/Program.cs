Console.WriteLine("Bienvenue dans la calculette !");

Console.Write("Entrez le premier nombre : ");

string nbr = Console.ReadLine();
if (decimal.TryParse(nbr)== true){
    decimal a = decimal.Parse(nbr);
} else {
    System.Console.WriteLine("Ca n'est pas possible ");
}

Console.Write("Entrez votre l'opérateur : ");
string opérateur = Console.ReadLine();

Console.Write("Entrez le deuxième nombre : ");
string nbr1 = Console.ReadLine();
if (decimal.TryParse(nbr1)== true){
    decimal b = decimal.Parse(nbr1); 
} else {
    System.Console.WriteLine("Ca n'est pas possible ");
}

if(opérateur == "+" ){
    a = a + b;
    Console.Write($"Le calcul est {a}");
} else if (opérateur == "-") {
    a = a - b;
    Console.Write($"Le calcul est {a}");
} else if (opérateur == "*") {
    a = a + b;
    Console.WriteLine($"Le calcul est {a}");
} else if(opérateur == "/") {
    a = a / b;
    System.Console.WriteLine($"Le calcul est {a}");
} else if (opérateur == "%"){
    a = a%b;
    System.Console.WriteLine($"Le calcul est {a}");
} else {
    System.Console.WriteLine("ça n'est pas possible.");
}
