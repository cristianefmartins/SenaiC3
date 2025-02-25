using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    //tudo que tem na classe pessoa vai ter na classe aluno = HERANCA
    public class Aluno : Pessoa
    {
        public String Curso;

        public void ExibirDetalhes()
        {
            ExibirInformacoes();
            Console.WriteLine($"Curso: {Curso}");
        }
    }
}
