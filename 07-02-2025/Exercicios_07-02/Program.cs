
/*
 Crie um programa que solicite ao usuário seu peso (em kg) e altura (em metros).
O programa deve calcular o Índice de Massa Corporal (IMC) e informar a categoria de acordo com a tabela abaixo:
- Abaixo do peso * *: IMC menor que 18,5
- Peso normal**: IMC entre 18,5 e 24,9
- Sobrepeso**: IMC entre 25 e 29,9
- Obesidade**: IMC 30 ou maior
 */

/*
using System.Globalization;

Console.WriteLine("Digite o seu peso");
int peso = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua altura");
double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine("Abaixo do peso. Seu IMC eh: " + imc);
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine("Peso normal. Seu IMC eh: " + imc);
}
else if (imc >25 && imc <= 29.9)
{
    Console.WriteLine("Sobrepeso. Seu IMC eh: " + imc);
}
else
{
    Console.WriteLine("Obesidade. Seu IMC eh: " + imc);
}
 */



/*
Crie um programa que solicita ao usuário dois números e uma operação matemática (+, -, *, /). 
Use switch/case para executar a operação correspondente e exibir o resultado.
 */

/*
Console.WriteLine("Digite o primeiro numbero");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a operacao");
string operacao = (Console.ReadLine());


switch (operacao)
{
    case "+":
        Console.WriteLine("O total eh: " + (numero1 + numero2));
        break;
    case "-":
        Console.WriteLine("O total eh: " + (numero1 - numero2));
        break;
    case "*":
        Console.WriteLine("O total eh: " + (numero1 * numero2));
        break;
    case "/":
        Console.WriteLine("O total eh: " + (numero1 / numero2));
        break;
    default:
        Console.WriteLine("Operacao invalida!");
        break;
}
 */



/*
Crie um programa que solicita ao usuário uma nota (de 0 a 10) e retorna uma mensagem correspondente:

- 10 ou 9 → "Excelente"
- 8 ou 7 → "Bom"
- 6 ou 5 → "Regular"
- 4 ou menos → "Insuficiente"

💡 Utilize `switch/case` para avaliar a nota e exibir a mensagem correspondente.
 */


/*
Console.WriteLine("Digite sua nota (de 0 a 10)");
int nota = int.Parse(Console.ReadLine());

switch (nota)
{
    //voce pode usar case 10 or 9

    //voce pode agrupar os cases
    case (10):
    case (9):
        Console.WriteLine("Excellente");
        break;
    case (8):
    case (7):
        Console.WriteLine("Bom");
        break;
    case (6):
    case (5):
        Console.WriteLine("Regular");
        break;
    case (4):
    case (3):
    case (2):
    case (1):
        Console.WriteLine("Insuficiente");
        break;
    default:
        Console.WriteLine("Nota invalida!");
        break;
};
 */




/*
Peça ao usuário um número e use o operador ternário (`? :`) para exibir se ele é par ou ímpar.
 */

/*
Console.WriteLine("Digite um numero");
int numero = int.Parse(Console.ReadLine());

//resto da divisao
string tipo = (numero % 2 == 0) ? "Par" : "Ímpar";
Console.WriteLine($"O número {numero} é {tipo}.");
 */



/*
Solicite ao usuário sua idade e utilize o operador ternário para determinar se ele é maior de
idade (`>= 18`) ou não, exibindo a mensagem correspondente.
 */

/* Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());

string mensagem = (idade >= 18) ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);

*/




/*  */


/*  */


/*  */