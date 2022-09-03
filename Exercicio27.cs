using System;

class Programa{
    public static void Main(string [] args){

        int linha = 1; 
        int produto = 0;
        int maiorValor = 0;
        int menorValor = 99999;

        for(linha = 1; linha <= 8; linha++){
            Console.Write("Digite o preço do " + linha + " produto: "); 
            produto = int.Parse(Console.ReadLine()); 

        if(produto > maiorValor){
            maiorValor = maiorValor * 0 + produto; 
        } 
        if(produto < menorValor){
            menorValor = menorValor * 0 + produto;
        } 
         
       }
       Console.WriteLine("O maior valor é " + maiorValor); 
       Console.WriteLine("O menor valor é " + menorValor);

       Console.WriteLine("Digite enter para sair...");
       Console.ReadLine(); 

    }
}