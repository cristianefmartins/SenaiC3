//Exercício 1: Cálculo de Média de Notas
//O programa abaixo deveria calcular a média de 5 notas informadas pelo usuário e exibir a média final.
//No entanto, ele contém alguns erros e trechos incompletos.

/*
float[] notas = new float[5];

Console.WriteLine("Digite 5 notas:");

for (int i = 0; i < 5; i++) //<= 5 tava considerando a posicao 5 do vetor, que comeca na posicao zero
{
    Console.Write($"Nota {i + 1}: ");
    notas[i] = float.Parse(Console.ReadLine());
}

float soma = 0;
for (int i = 0; i < 5; i++) //ta contando a partir da posicao 1 do vetor
{
    soma += notas[i];
}

float media = soma / 5;

Console.WriteLine("A média das notas é: " + media);

if (media >= 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}
*/



//###Exercício 2: Verificação de Número Primo
//O código abaixo deveria verificar se um número **informado pelo usuário** é primo,
//mas contém alguns erros.

/**/

Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

bool ehPrimo = true;

if (numero < 2)
{
    ehPrimo = false;
}
else
{
    for (int i = 2; i < numero; i++)
    {
        // = atribuicao
        // == igualdade
        if (numero % i == 0)
        {
            ehPrimo = false;
            break;
        }
    }
}

//eh o mesmo que fazer ehPrimo == true
if (ehPrimo)
    Console.WriteLine("O número " + numero + " é primo!");
else
    Console.WriteLine("O número " + numero + " NAO é primo!");


