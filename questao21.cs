using System;

class Programa{


    public static void Main(string[] args)
    {

        string tipo;
        Console.WriteLine("O seu carro é de luxo ou popular? ");
        tipo = Console.ReadLine();

        int dias;
        Console.WriteLine("Por quantos dias você alugou? ");
        dias = int.Parse(Console.ReadLine());

        int km;
        Console.WriteLine("Quantos km você percorreu? ");
        km = int.Parse(Console.ReadLine());

        if (tipo == "Popular" && km < 100)
        {
            Console.WriteLine("Você terá que pagar " + (dias * 90) + " reais e " + (km * 0.20) + " reais");
        }
        if (tipo == "Popular" && km > 100)
        {
            Console.WriteLine("Você terá que pagar " + (dias * 90) + " reais e " + (km * 0.10) + " reais");
        }
        if (tipo == "Luxo" && km < 200)
        {
            Console.WriteLine("Você terá que pagar " + (dias * 150) + " reais e " + (km * 0.30) + " reais");
        }
        if (tipo == "Luxo" && km > 200)
        {
            Console.WriteLine("Você terá que pagar " + (dias * 150) + " reais e " + (km * 0.25) + " reais");
        }

    }
}