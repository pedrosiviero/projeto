using System; 

class Programa{
    public static void Main(string[] args){
        string nome; 
        Console.WriteLine("Digite o seu nome: "); 
        nome = Console.ReadLine(); 

        double salario;
        Console.WriteLine("Digite o seu salário: "); 
        salario = double.Parse(Console.ReadLine()); 

        double ano; 
        Console.WriteLine("Digite quantos anos você está na empresa: "); 
        ano = double.Parse(Console.ReadLine()); 

        if(ano <= 3 && ano < 4){
            Console.WriteLine("O seu salário aumentou para " + (salario * 0.03));
        } 
        if(ano <= 10 && ano < 11){
            Console.WriteLine("O seu salário aumentou para " + (salario * 0.125)); 
        } else{
            Console.WriteLine("O seu salário aumentou para " + (salario * 0.20)); 
        }
        Console.WriteLine("Digite enter para sair..."); 
        Console.ReadLine(); 
        

      


    }
}