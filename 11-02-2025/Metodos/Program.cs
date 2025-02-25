/*Programacao estruturada = O problema eh repetir codigo
int numero 1 = 5;
int numero 2 = 8;

int resultado = numero1 + numero2;

int num 1 = 3;
int num 2 = 9;
*/



//Metodo
// Pode ser reutilizado em varias partes do sistema
// Organiza melhor o codigo

//static - Por enquanto precisamos usar o static
//int - O que o metodo vai retornar ou nao algo pra ser usado fora dela
//somar - nome da funcao, vai pintar o nome do metodo de amarelo
//num1 e num2 - sao os parametros que vem de fora 
//Aqui estamos apenas DEFININDO o metodo/funcao
static int Somar(int num1, int num2)
{
    return num1 + num2;
}


//Aqui vamos chamar o metodo/funcao 
Console.WriteLine(Somar(3, 8));
Console.WriteLine(Somar(15, 22));


//void - nesse caso a funcao nao vai retornar nada, por isso nao tem o return
//como essa funcao na retorna nada o Console.WriteLine tem que ser feito dentro do metodo
//static void Somar2(int num1, int num2)
//{
//    Console.WriteLine(Somar2(10, 10));
//}


//Calculos = usar funcao com return
//Exibir mensagem de saudacao - usar uma funcao sem return

static void Saudacao()
{
    Console.WriteLine("Seja bem vindo ao sistema!");
}
Saudacao();



//Exemplo funcao para cadastro a partir de um vetor
string[] nomes = new string[5];

static void Cadastrar(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        vetor[i] = Console.ReadLine();
    }
}

//Chamar a funcao varias vezes
Cadastrar(nomes);
Cadastrar(cpfs);