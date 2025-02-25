/*
 1) Crie um programa que solicite ao usuário seu **nome** e uma **senha**. 
- A senha deve ter exatamente **6 caracteres**.
- O programa deve pedir a senha repetidamente **enquanto** o usuário não digitar uma senha válida.
- Assim que uma senha correta for informada, o programa deve exibir a mensagem: **"Usuário e Senha recebidos com sucesso!"**.
- Utilize `while` para garantir que a senha tenha o número correto de caracteres.
*/


/*
Console.WriteLine("Digite o seu nome");
string nome = Console.ReadLine();

bool acertou;

do
{
    Console.WriteLine("Digite uma senha com 6 caracteres");
    string senha = Console.ReadLine();

    if (senha.Length == 6) 
    {
        Console.WriteLine("Usuário e Senha recebidos com sucesso!");
        acertou = true;
    }
    else
    {
        acertou = false;
    }

} while (!acertou);
*/



/*
2) Crie um programa que gere a **tabuada** de um número informado pelo usuário.
- O programa deve solicitar ao usuário um **número inteiro** e, em seguida, exibir a tabuada desse número de **1 a 10**.
- Utilize um **laço de repetição (`for`)** para calcular e exibir os resultados no formato
- Ao final, o programa deve exibir a mensagem: **""**.
- Utilize `for` para percorrer os valores de 1 a 10 e exibir os resultados.
*/

Console.WriteLine("Digite um numero inteiro");
int numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
}
Console.WriteLine("Fim da Tabuada!");


/*
 xxxx
*/

