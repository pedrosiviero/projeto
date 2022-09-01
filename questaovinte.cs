using System; 

class Programa{
    public static void Main(string [] args){

        double peso; 
        Console.WriteLine("Digite o seu peso: ");
        peso = double.Parse(Console.ReadLine()); 

        double altura; 
        Console.WriteLine("Digite a sua altura: ");
        altura = double.Parse(Console.ReadLine()); 

        double imc;
        Console.WriteLine("O seu IMC é de " + (peso / altura * altura ));  

        if(peso / (altura * altura) < 18.5){
            Console.WriteLine("Você está abaixo do peso. "); 
        }
        if (peso / (altura * altura ) > 18.5 && peso / (altura * altura ) < 25){
            Console.WriteLine("Você tem o peso ideal. "); 
        }
        if(peso / (altura * altura ) > 25 && peso / (altura * altura ) < 30){
            Console.WriteLine("Sobrepeso."); 
        } 
        if(peso / (altura * altura ) > 30 && peso / (altura * altura ) < 40 ){
            Console.WriteLine("Você está com obesidade"); 
        } 
        if(peso / (altura * altura) > 40){
            Console.WriteLine("Obesidade mórbida."); 
        }
        Console.WriteLine("Digite enter para sair..."); 
        Console.ReadLine(); 






    }

}