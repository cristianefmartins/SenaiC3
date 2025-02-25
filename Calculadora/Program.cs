// Utilizando o switch faca uma calculadora que recebe 2 numeros e a operacao a ser realizada

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