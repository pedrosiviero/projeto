using System;

class Programa{
    public static void Main(string[] args){

        double valor; 
        Console.WriteLine("Digite o valor do imóvel: "); 
        valor = double.Parse(Console.ReadLine()); 

        double salario;
        Console.WriteLine("Digite o seu salário: "); 
        salario = double.Parse(Console.ReadLine()); 

        int anos; 
        Console.WriteLine("Em quantos anos você pretende pagar? "); 
        anos = int.Parse(Console.ReadLine()); 

        if(salario * 0.30 < valor / anos * 12){
            Console.WriteLine("Você não pode usar o emprestimo."); 
        } else{
            Console.WriteLine("Você pode usar o emprestimo. "); 
        }
        Console.WriteLine("Digite enter para sair..."); 
        Console.ReadLine(); 


    }
}