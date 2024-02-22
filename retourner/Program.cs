/*int addition (int a,int b){
    int c = a + b ;
    return c ; 
}
Console.WriteLine(addition(11,6)); */

int factorielle(int a) {
    for (int i = 1; i<a; i++) {
        int c = i*(i+1) ;
        return c;
    }
}
Console.WriteLine(factorielle(15));