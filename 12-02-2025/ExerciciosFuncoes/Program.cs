// 1) Crie uma função chamada Saudacao que recebe um nome como parâmetro e imprime "Olá, [Nome]!".

/* 

Console.WriteLine("Digite o seu nome");
string nome = Console.ReadLine();

//Declara o metodo
static void Saudacao(string nm)
{
    Console.WriteLine("Olá, " + nm);
    //Console.WriteLine($"Olá, {nm}"); //OUTRA IMPLEMENTACAO

}

//chama o metodo
Saudacao(nome);
//Saudacao("Kiara"); //OUTRA IMPLEMENTACAO

*/


// 2)  Crie uma função chamada Subtração que recebe dois números inteiros e retorna a subtração deles.
/* 

//Declara o metodo
static int Subtracao(int num1, int num2)
{
    return num1 - num2;
}

//chama o metodo
Console.WriteLine(Subtracao(10, 5));
Console.WriteLine(Subtracao(15, 22));
//CTRL + D copia uma linha igual em baixo

*/



// 3) Crie uma função chamada EhPar que recebe um número inteiro e retorna true se for par e false caso contrário.

/* 
static bool EhPar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("O numero eh par");
        return true;

    }
    else
    {
        Console.WriteLine("O numero eh impar");
        return false;

    }
}

EhPar(7);
*/

//Outra forma de fazer
/* static bool EhPar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("O numero é PAR");
        return true;
    }

    Console.WriteLine("O numero é IMPARRRR");
    return false;
}

EhPar(7);
*/




// 4) Crie uma função chamada VerificarNumero que recebe um número inteiro e retorna uma string informando
// se ele é positivo, negativo ou zero.

/*  

Console.WriteLine("Digite um numero");
int numero = int.Parse(Console.ReadLine());


//Declara o metodo
static string VerificarNumero(int num)
{

    if (num > 0)
    {
         return "O numero eh POSITIVO";
    }
    else if (num < 0)
    {
        return "O numero eh NEGATIVO";
    }
    else
    {
        return "O numero eh ZEROOO";
    }
}

//chama o metodo
Console.WriteLine(VerificarNumero(numero));
*/



// 5) Crie uma função CalcularMedia  que recebe três notas e retorna a média delas.
// Crie outra função VerificarAprovacao  que recebe a média e imprime se o aluno foi
// aprovado (média ≥ 7) ou reprovado.
/* 

static double CalcularMedia(double nota1, double nota2, double nota3)
{
    return ((nota1 + nota2 + nota3) / 3);
}


double media = (CalcularMedia(8, 7, 7));

Console.WriteLine("A media eh " + media);




static bool VerificarAprovacao(double med)
{
    if (med >= 7)
    {
        Console.WriteLine("O aluno foi APROVADO");
        return true;
    }

    Console.WriteLine("O aluno foi REPROVADO");
    return false;
}
VerificarAprovacao(media);
*/


//SOLUCAO DO PROFESSOR
/* 
static double CalcularMedia(int nota1, int nota2, int nota3)
{
    double media = (nota1 + nota2 + nota3) / 3;
    return media;
}

static void VerificarAprovacao(double m)
{
    if (m >= 7)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}

double mediaFinal = CalcularMedia(7, 8, 9);

VerificarAprovacao(mediaFinal);
*/


//SOLUCAO ALTERNATIVA (MAIS DIFICIL) DO PROFESSOR
/* 
 
//Variavel fora da funcao
//A funcao CalcularMedia nao vai mais retornar nada, pq ele ja vai ta na variavel media de fora da funcao
//temos que tirar o static das duas funcoes

double media;
void CalcularMedia(int nota1, int nota2, int nota3)
{
    media = (nota1 + nota2 + nota3) / 3;
}

void VerificarAprovacao()
{
    if (media >= 7)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}

CalcularMedia(7, 8, 9);

VerificarAprovacao();


 */


// [EXERCICIO EXTRA] XXXXXX
/* */
