// ax + b = c


float a;
float b;
float c; 

Console.WriteLine("Entrez la valeur de a :");
a =Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Entrez la valeur de b :");
b = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("Entrez la valeur de c :");
c = Convert.ToSingle(Console.ReadLine());

float x;
x =(c-b)/a;
Console.WriteLine($"x prend la valeur {x}" );
