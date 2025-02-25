// ENTRADA
//int nota1 = 2;
//int nota2 = 5;
//int nota3 = 10;


//o ReadLine por padrao espera uma string por isso temos que converte

Console.WriteLine("Insira a primeira nota");
int nota1 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a segunda nota");
int nota2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a terceira nota");
int nota3 = int.Parse(Console.ReadLine());

string name = "Cris";
char sexo = 'M';
bool terminouFaculdade = true; //ao aceita true or false


// PROCESSAMENTO

double media = (nota1 + nota2 + nota3) / 3;


//if-else eh o losango do fluxograma = condicao
//writeline escreve uma linha no cw
//Estrutura condicional composta
if (media >= 6) 
{ Console.WriteLine("Aprovado"); }
else
    { Console.WriteLine("Reprovadooooo"); }


// SAIDA 
//digitar cw e tab = escreve uma linha no terminal
//concatenacao = juntar texto e variavel
Console.WriteLine("A media do aluno e: " + media);

//Outra forma de fazer a saida de dados = interpolacao
//Console.WriteLine($"A media do alunoOOO e: " + {media}");