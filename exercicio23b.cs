using System; 

class Programa{
    public static void Main(string [] args){
 
        int num1 = 6; 
        int b = 0;

        while(num1 <= 100){
            b = b + num1; 
            Console.Write(num1); 
            

            if(num1 != 100){
                Console.Write(" + "); 
            }
            num1 = num1 + 2; 
            
        }

        Console.WriteLine(" = " + b); 
        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine(); 
    
    }
}