/*int addition (int a,int b){
    int c = a + b ;
    return c ; 
}
Console.WriteLine(addition(11,6)); */

int factorielle( int a ) {
    int c = 1;
    for (int i = 1; i<=a; i++) {
        Console.WriteLine($"i ={i},c = {c}");
        c = c*i ;
        
    }
    return c;
}
Console.WriteLine(factorielle(8));