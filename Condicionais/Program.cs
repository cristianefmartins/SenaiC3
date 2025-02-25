
//Switch case - mais performatico quando temos varias condicoes

//quando temos entre 5 e 6 condicoes = usar o if/else
//quando passo de 6 condicoes = usar o Switch
//default situacao onde o numero digitado nao corresponda a nenhum caso

// 1) Com base no numero do dia da semana, imprima o nome do dia

Console.WriteLine("Digite o dia da semana");
int diaSemana = int.Parse(Console.ReadLine());

switch (diaSemana)
{
    case 1:
        Console.WriteLine("Hoje eh domingo!");
        break;
    case 2:
        Console.WriteLine("Hoje eh segunda!");
        break;
    case 3:
        Console.WriteLine("Hoje eh terca!");
        break;
    case 4:
        Console.WriteLine("Hoje eh quarta!");
        break;
    case 5:
        Console.WriteLine("Hoje eh quinta!");
        break;
    case 6:
        Console.WriteLine("Hoje eh sexta!");
        break;
    case 7:
        Console.WriteLine("Hoje eh sabado!");
        break;
    default:
        Console.WriteLine("Dia invalido!");
        break;
}


//Usando o If normal
double temperatura = 40;

if (temperatura > 35)
{
    Console.WriteLine("Esta quente");
}
else
{
    Console.WriteLine("Esta ameno");
}


//Usando o If ternario = if enxuto
string texto = temperatura > 35 ? "Esta quente" : "Esta ameno";
Console.WriteLine(texto);