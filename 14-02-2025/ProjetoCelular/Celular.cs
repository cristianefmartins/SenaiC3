using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCelular
{
    public class Celular
    {
        public string Cor;
        public string Modelo;
        public string Tamanho;
        public bool Ligado;


        public void Ligar()
        {
            Console.WriteLine("Ligando o celular...");
            Ligado = true;
        }

        public void Desligar()
        {
            Console.WriteLine("O celular esta desligado");
            Ligado = false;
        }
        public void FazerLigacao()
        {
            if (Ligado) {
                Console.WriteLine("Fazendo ligacao");
            }
            else {
                Console.WriteLine("Celular desligado");
            }
        }

        public void EnviarMensagem()
        {
            Console.WriteLine("Enviando mensagem...");
        }
    }
}
