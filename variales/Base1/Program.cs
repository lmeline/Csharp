// Variables int, string, bool, decimal
// bool seulement True ou False 
// string chaine de caractère 
// int variable numérique entier 
// décimal variable numérique à virgule

int a = 5;
int b = 3; 

string c = "Hello";
bool d = true;
decimal e = 3.14m;

Console.WriteLine(a);

const double PI = 3.14159265359;
const decimal TVA = 0.2m;
const int Max = 100;

// suffixe m pour convertir en décimal
// on peut mettre des _ entre les chiffres
/* 
Entier non signés

int  son véritable nom c'est system.Int32  il utilise en mémoire 32 bits (4 bytes) - 2,147,483,648 à 2,147,483,647
long                         system.Int64                        64 bits (8 bytes) - 9,223,372,036,854,775,808 à

Entier signés

uint                         system.UInt32                       32 bits (4 bytes)
ulong                        system UInt64                       64 bits (4 bytes)

Réel 

float System.Single    32 bits   (4 bytes) -3;4022823e38 à 3.402823e38
double System.Double   64 bits   (8 bytes) 
decimal System.Décimal 128 bits  (16 bytes)
*/

/* 
Texte 
string f = "hello"\ "World !";
char g = 'A';
