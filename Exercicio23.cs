using System; 

class Programa{
    public static void Main(string[] args){

        int num1, num2, incremento, aux;

        Console.Write("Digite o primeiro valor: ");
        num1 = int.Parse(Console.ReadLine()); 

        Console.Write("Digite o segundo valor: "); 
        num2 = int.Parse(Console.ReadLine()); 

        Console.Write("Digite o incremento: "); 
        incremento = int.Parse(Console.ReadLine()); 

        if(num1 > num2){
           aux = num1; 
           num1 = num2; 
           num2 = aux; 
        }

        aux = num1; 

       while(num1 < num2){
          Console.Write(num1 + ""); 
          num1 = num1 + incremento; 
        }
        for(num1; num1 < num2; num1 += incremento){

        }
        Console.WriteLine("Pressione enter para sair... ");
        Console.ReadLine(); 
    }
}