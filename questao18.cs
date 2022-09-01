using System;

class Programa{
    public static void Main(string[] args){
        int seg1, seg2, seg3; 

        Console.WriteLine("Digite o tamanho do primeiro segmento: ");
        seg1 = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Digite o tamanho do segundo segmento: ");
        seg2 = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Digite o tamanho do terceiro segmento: ");
        seg3 = int.Parse(Console.ReadLine()); 

        if(seg1 < seg2 + seg3 || seg2 < seg1 + seg3 ||  seg3 < seg1 + seg2){
            Console.WriteLine("Possivel de fazer um triangulo. "); 
        if(seg1 == seg2 && seg2 == seg3){
            Console.WriteLine("Forma um equilátero.");
        }
        if(seg1 == seg2 || seg1 == seg3 || seg2 == seg3){
            Console.WriteLine("Forma um isóceles. "); 
        } else{
            Console.WriteLine("Forma um escaleno. "); 
        }
        } else{
            Console.WriteLine("Não é possivel de fazer um triangulo. "); 
        }
        Console.WriteLine("Digite enter para sair..."); 
        Console.ReadLine(); 
        

    }
}