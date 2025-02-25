
Console.WriteLine("Digite a sua idade");
int idade = int.Parse(Console.ReadLine());


int idadeEmMeses = idade * 12;
int idadeEmDias = idade * 365;

Console.WriteLine("Voce tem: " + idadeEmMeses + " meses de vida");
Console.WriteLine("Voce tem: " + idadeEmDias + " dias de vida");

