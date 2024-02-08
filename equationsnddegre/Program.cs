// ax + b = 0


//float a;
//float b;
// pas besoin de le déclarer avant 
// peut mettre float directement 

Console.WriteLine("Entrez la valeur de a :");
float a =Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Entrez la valeur de b :");
float b = Convert.ToSingle(Console.ReadLine());


float x;
x = -b/a;
// Interpolation de string
Console.WriteLine($"x prend la valeur {x}" );

// décimal a = Convert.ToDecimal(System.Console.ReadLine());
// System est implicite, pas besoin de l'importer
// Console.RealLine (toujours une chaine de caractère)
// utilisé decimal 
// double = Convert.ToDouble (moins précis au nv des décimales)
