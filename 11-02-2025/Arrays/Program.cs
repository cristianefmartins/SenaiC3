//Arrays / Vetores = lista de elementos, e.g Guardar varios nomes 

string[] nomes = new string[3]; //quantidades de elementos que a lista suporta
int[] coisas = new int[3];

//coloca o nome na primeira posicao do array. Todo array comeca na posicao 0
nomes[0] = "Vinicio";
nomes[1] = "Fulano";
nomes[2] = "Ciclano";


//listar todos elementos da lista
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);

}


//lista um nome especifico, e.g posicao 3
//Console.WriteLine(nomes[2]);


//usar para cadastrar nomes no array 
for (int i = 0; i < nomes.Length; i++)
{
    nomes[i] = Console.ReadLine();
}


//ForEach = Para cada, usada pra percorrer arrays 
//Para cada nome dentro de nomes
//estou chamando cada nome salvo como nome
foreach (string n in nomes)
{
    Console.WriteLine(n);
}