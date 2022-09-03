using System; 

class Programa
{
    public static void Main(string[] args)
    {
        int F1 = 0;
        int F2 = 1;
        int num1 = 0;
        int linhas = 0;
        int Fn = 0;
        
        Console.WriteLine("Quantos elementos de Fibonacci deseja visualizar?: "); 
        num1 = int.Parse(Console.ReadLine());

        if(num1 >= 1){
            Console.WriteLine("0");
        }
        if(num1 >= 2){
            Console.WriteLine("1");
        }

        while(linhas != num1 - 2){
            linhas++;
            Fn = F1 + F2;
            Console.WriteLine(Fn);
            F1 = F2;
            F2 = Fn;

        }

        Console.WriteLine("Digite enter para sair...");
        Console.ReadLine();

    }
}