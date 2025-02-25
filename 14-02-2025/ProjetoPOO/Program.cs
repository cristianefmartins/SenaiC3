// Classe
// - Atributos e Métodos

// Modificador de Acesso:
// public - Classe (Método, Atributo) é acessível de qualquer lugar
// private - Classe (Método, Atributo) não pode ser acessado por outras classes. Pot padrao eh privado
// internal - so os filhos podem acessar
// protected - idem


//Instanciar a Classe (que eh criar um objeto)
using ProjetoPOO;

//clicar na pessoa e clicar CTRL + . e escolhe using ProjetoPOO, vai usar classe que esta em qq arquivo desse
//projeto
Pessoa p1 = new Pessoa(); //eh nesse momento que a pessoa passa a existir

p1.Nome = "Cris";
p1.Idade = 22;

p1.ExibirInformacoes();


Calculadora calc = new Calculadora();

calc.Numero1 = 10;
calc.Numero2 = 15;
Console.WriteLine(calc.Soma());


Aluno aluno1 = new Aluno();
aluno1.Nome = "Aluninho";
aluno1.Idade = 12;
aluno1.Curso = "Engenharia civil";
aluno1.ExibirDetalhes();


