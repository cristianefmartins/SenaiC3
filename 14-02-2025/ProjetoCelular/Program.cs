// 

using ProjetoCelular;

Celular c1 = new Celular();

c1.Cor = "Preto";
c1.Modelo = "Galaxy S23";
c1.Tamanho = "Edge";
c1.Ligado = true;


c1.Ligar();

if (c1.Ligado == true)
    {
        c1.FazerLigacao();
        c1.EnviarMensagem();
    }
else
    {
        c1.Desligar();
    }