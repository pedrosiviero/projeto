using System; 

class Programa{
    public static void Main(string[] args){

       int soma = 0; int num = 1; 

       while(num <= 7){

        Console.Write("Digite o " + num + " número: ");
        soma = soma + int.Parse(Console.ReadLine());
        num++; 

       }
       Console.WriteLine("A soma dos números digitados é: " + soma); 
    
     
  }
}