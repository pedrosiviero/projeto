using System;

class Programa{
    public static void Main(string [] args){

        int linhas = 0;
        int num = 0;
        int impar = 0;
        int par = 0; 

        for(linhas = 0; linhas < 6; linhas++){
            Console.WriteLine("Digite um número: "); 
            num = int.Parse(Console.ReadLine()); 

            if( num % 2 != 0){
                impar = impar + 1;
            } else{
                par = par + 1;
            }
       }
       Console.WriteLine(impar + " são impares e " + par + " são pares.");
       Console.WriteLine("Digite enter para sair...");
       Console.ReadLine();
    }
}