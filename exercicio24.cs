using System; 

class Programa{
    public static void Main(string [] args){
 
        int num1 = 500; 
        int b = 0;

        while(num1 >= 0){
            b = b + num1; 
            Console.Write(num1 + " + "); 
            num1 = num1 - 50; 
            
        }
        Console.WriteLine("0 = " + b); 
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine(); 
    
    }
}