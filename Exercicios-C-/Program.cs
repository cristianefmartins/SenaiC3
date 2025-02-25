/*
 * 1 ----
 * Faça um programa que o usuário informe o salário recebido e o total gasto. 
 * Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto 
 * não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.
 * 
 * */


/*
 
Console.WriteLine("Informe o salário recebido");
double salario = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o total gasto");
double totalGasto = double.Parse(Console.ReadLine());

if (totalGasto <= salario)
{
    // Console.WriteLine - escreve uma linha no terminal
    Console.WriteLine("Gastos dentro do orçamento");
}
else
{
    Console.WriteLine("Orçamento estourado");
}

 */



/*
 * 2------
 * Desenvolva um programa que recebe do usuário, 
 * o placar de um jogo de futebol (os gols de cada time) 
 * e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.
 * 
 * */


/*
Console.WriteLine("Informe a quantidade de gols to time 1");
int golsTime1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade de gols to time 2");
int golsTime2 = int.Parse(Console.ReadLine());


//Estrutura condicional Encadeada
if (golsTime1 > golsTime2)
{ Console.WriteLine("O time 1 venceu"); }
else if (golsTime1 < golsTime2)
{ Console.WriteLine("O time 2 venceu"); }
else
{ Console.WriteLine("Putz, deu empate"); }
*/



/*
 * 3------
 * Escreva	 um	 programa que leia	 as	 medidas	 dos	 lados	 de	 um	 triângulo	 
 * e	escreva	se	ele	é	Equilátero,	Isósceles	ou	Escaleno.	
 * Sendo	que:	
− Triângulo	Equilátero:	possui	os	3	lados	iguais.	
− Triângulo	Isóscele:	possui	2	lados	iguais.	
− Triângulo	Escaleno:	possui	3	lados	diferentes.
 * 
 * */


/*

Console.WriteLine("Informe a medida do lado 1 do triangulo");
int lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a medida do lado 2 do triangulo");
int lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a medida do lado 3 do triangulo");
int lado3 = int.Parse(Console.ReadLine());


//Estrutura condicional Encadeada
if (lado1 == lado2 && lado1 == lado3)
{ Console.WriteLine("Esse triangulo eh Equilátero"); }

else if (lado1 == lado2 && lado1 > lado3 )
{ Console.WriteLine("Esse triangulo eh Isóscele"); }
else if (lado1 == lado2 && lado1 < lado3 )
{ Console.WriteLine("Esse triangulo eh Isóscele"); }

else if (lado3 == lado2 && lado3 > lado1)
{ Console.WriteLine("Esse triangulo eh Isóscele"); }
else if (lado3 == lado2 && lado3 < lado1)
{ Console.WriteLine("Esse triangulo eh Isóscele"); }

else if (lado1 == lado3 && lado1 > lado2)
{ Console.WriteLine("Esse triangulo eh Isóscele"); }
else if (lado1 == lado3 && lado1 < lado2)
{ Console.WriteLine("Esse triangulo eh Isóscele"); }
else
{ Console.WriteLine("Esse triangulo eh Escaleno"); }

*/



/*
 * 4 - Escreva	 um	 programa	 que	 verifique	 a	 validade	 de	 uma	 senha	 fornecida pelo	 usuário.	 
 * A	 senha	 válida	 é	 o	 número	 1234.	Devem	 ser	impressas	 as	seguintes	 mensagens:	
ACESSO	PERMITIDO	caso	a	senha	seja	válida.	
ACESSO	NEGADO	caso	a	senha	seja	inválida
 * 
 * */

/*

Console.WriteLine("Digite a senha");
int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine("ACESSO PERMITIDO");
}
else
{
    Console.WriteLine("ACESSO NEGADO");
}

*/





/*
 * 5 - As	maçãs custam R$ 0,30 cada se forem compradas	menos do que uma dúzia, 
 * e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, 
 * calcule e escreva o valor	total	da	compra.
 * 
 * */


/*
using System.Threading.Channels;

double valor1 = 0.30;
double valor2 = 0.25;

Console.WriteLine("Digite a quantidade de maçãs que voce quer comprar");
int quantidade = int.Parse(Console.ReadLine());

if (quantidade >= 12)
{
    Console.WriteLine("Voce comprou " + quantidade + " maçãs. O valor total eh: " + (quantidade * valor2));
}
else
{
    Console.WriteLine("Voce comprou " + quantidade + " maçãs. O valor total eh: " + (quantidade * valor1));
}

 */



/* int quantidadeMacas = int.Parse(Console.ReadLine()); ;
double totalCompra;

if (quantidadeMacas < 12)
{
    xxxxxx; 
}
else
{
    xxxxxx; 
}
Console.WriteLine("Voce comprou " + quantidade + " maçãs. O valor total eh: " + (quantidade * valor1));
 */

/*
 * 6 -Sabemos que um aluno é aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%. 
 * Na verdade, em uma situação real, se o aluno obtiver a frequência mínima exigida e uma média entre 3 e 7, 
 * ainda teria direito a uma última avaliação de recuperação. Como faríamos para resolver o problema em questão 
 * utilizando apenas estruturas de condição se-então-senão? Poderíamos começar avaliando a frequência do aluno, 
 * e se a mesma for menor que 75% o aluno já estaria reprovado, porém caso a frequência respeite o mínimo exigido, 
 * começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
 * 
 * */

/*
Console.WriteLine("Insira a primeira nota:");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a segunda nota:");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a terceira nota:");
int nota3 = int.Parse(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;


if (media > 6)
{
Console.WriteLine("APROVADO");
}
else
{
Console.WriteLine("REPROVADO");
}
*/



/*
 EXERCICIOS EXTRA NO https://dontpad.com/senai-c#
*/

/*
7 - Escreva um programa que pergunte o dia, mês e ano do aniversário de uma pessoa e diga se a data é válida ou não. 
Caso não seja, diga o motivo. Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.
*/


/*
 8 - Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
    - "Telefonou para a vítima?" 
    
    - "Esteve no local do crime?" 
    
    - "Mora perto da vítima?" 
    
    - "Devia para a vítima?" 
    
    - "Já trabalhou com a vítima?" 

O programa deve no final emitir uma classificação sobre a participação da pessoa no crime.
Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", 
entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.
*/



/*
 XXXXX
*/