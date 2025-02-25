
Console.WriteLine("Digite a sua media");
double media = double.Parse(Console.ReadLine());


//Estrutura condicional Encadeada
if (media >=  9)
{ Console.WriteLine("Seu conceito eh A"); }
else if (media >= 7.5 && media < 9)
{ Console.WriteLine("Seu conceito eh B"); }
else if(media >= 6 && media < 7.5)
{ Console.WriteLine("Seu conceito eh C"); }
else
{ Console.WriteLine("Voce foi REPROVADO"); }




//Média de Aproveitamento	Conceito
//9,0	A
//7,5 e < 9,0	B
//6,0 e < 7,5	C
//abaixo de 6	Reprovado
