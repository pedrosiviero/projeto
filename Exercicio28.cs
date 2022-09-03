using System; 

class Programa{
    public static void Main(string [] args){

        int contador = 1; // contador 
        int idade = 0; // linhas 
        int media = 0; // media 
        int maiorDezoito = 0; // maior de 18 
        int menorCinco = 0; // menos de 5 
        int maiorIdade = 0; // a maior idade 

        for(contador = 1; contador <= 10; contador++){
           
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine()); 

            if(idade > 18){
                maiorDezoito = maiorDezoito + 1; 
            }
            if(idade < 5){
                menorCinco = menorCinco + 1;
            }
            if(idade > maiorDezoito){
                maiorIdade = maiorIdade * 0 + idade;
            }
            if(idade != 0){
                media = idade + media;
            }
        }

        Console.WriteLine("Maiores de 18 são: " + maiorDezoito);
        Console.WriteLine("Menores de 5 são: "+ menorCinco); 
        Console.WriteLine("A maior idade é: " + maiorIdade); 
        Console.WriteLine("A média é: " + media / 10); 
    }
}