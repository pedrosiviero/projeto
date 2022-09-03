using System;

class Programa{
    public static void Main(string[] args){

    int linhas = 1; // linhas 
    int idade = 0; // idade
    int num1 = 0; // sexo feminino
    int num2 = 0; // sexo masculino
    int sexo = 0;
    int mediaGrupo = 0; // media do grupo
    int idadeMulheres = 0; // idade das mulheres 
    int idadeHomens = 0; // media homens 
    int maiorDeVinte = 0; 

        for(linhas = 1; linhas <= 5; linhas++){
           
            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine()); 

            Console.Write("Digite 1 para feminino e 2 para masculino: "); 
            sexo = int.Parse(Console.ReadLine()); 

        if(sexo == 1){
            num1 = num1 + 1;
    }
        if(sexo == 2){
            num2 = num2 + 1;
            idadeHomens = idade + idadeHomens;
    }
        if(idade != 0){
            mediaGrupo = idade + mediaGrupo;
    } 
    if(sexo == 1){
            num1 = num1 + 1;
            idadeMulheres = idade + idadeMulheres;
    }
    if(idadeMulheres > 20){
        maiorDeVinte++; 
    }
    }
    Console.WriteLine("Possui " + num1 + " mulheres.");
    Console.WriteLine("Possui " + num2 + " homens" + " e a média é " + idadeHomens / num2);
    Console.WriteLine("A média é de " + mediaGrupo / 5); 
    Console.WriteLine(maiorDeVinte + " mulheres possuem acima de 20 anos.");
    }
}