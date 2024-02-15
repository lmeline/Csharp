string[] chaines = new string[5];
chaines [0] = "bonjour ";
chaines [1] = "à ";
chaines [2] = "tous ";
chaines [3] = "! ";
chaines [4] = "comment allez-vous ? ";

Console.Write(chaines[0] +chaines[1]+chaines[2]+chaines[3]+chaines[4]);

string saisie = Console.ReadLine();
/*bool b = int.TryParse(saisie, out int nb);
Console.WriteLine(b);*/

/* if (!b) {
   Console.WriteLine($"Vous n'avez pas saisi un nombre.");
} else {
    Console.WriteLine($"Vous avez saisi le nombre {nb}");
} */

for (int i = 0; i < chaines.Length; i++) {
    Console.Write(chaines[i]);
}