// 1) Crie um programa que solicite ao usuário 5 números inteiros, armazene-os em um array e depois exiba os números digitados.

/* 
int[] numeros = new int[5];

//laco pra cadastrar os numeros
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite o " + (i+1) + "º numero");
    numeros[i] = int.Parse(Console.ReadLine());
}



Console.WriteLine("Os números digitados foram");

//foreach pra listar os valores do array
foreach (int n in numeros)
{
    Console.WriteLine(n);
}
*/


// 2) Crie um programa que permita ao usuário digitar 6 números inteiros, armazene-os em um array
// e depois exiba quantos números são pares e quantos são ímpares.

using static System.Runtime.InteropServices.JavaScript.JSType;

int[] numeros = new int[6];
int quantidadePares = 0;
int quantidadeImpares = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Digite o " + (i + 1) + "º numero");
    numeros[i] = int.Parse(Console.ReadLine());

    //outra solucao eh colocar o if aqui
    //if (numeros[i] % 2 == 0)
    //{
      //  Console.WriteLine("O numero eh par");
      //  quantidadePares++;
    //}
    //else
   // {
    //    Console.WriteLine("O numero eh impar");
    //    quantidadeImpares++;
    //}
}

Console.WriteLine("Os números digitados foram");

foreach (int n in numeros)
{
    Console.WriteLine(n);

    if (n % 2 == 0)
        quantidadePares = quantidadePares + 1;
    else
        quantidadeImpares = quantidadeImpares + 1;
}

Console.WriteLine("Quantidade de números pares:" + quantidadePares);
Console.WriteLine("Quantidade de números impares:" + quantidadeImpares);

