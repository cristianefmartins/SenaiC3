using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    public class Pessoa
    {
        //atributos da classe
        public string Nome;
        public int Idade;

        //metodos da classe
        public void ExibirInformacoes()
        {
            //Console eh a classe e o WriteLine eh o metodo
            //static - vinculo `a classe e nao ao objeto
            Console.WriteLine($"Nome: {Nome}, idade: {Idade}");
        }
    }
}
