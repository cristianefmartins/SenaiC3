using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;

namespace Pong
{
    public class Global
    {
        //permite que eu carregue varios elementos ao mesmo tempo 
        public static SpriteBatch spriteBatch;
        //largura e altura da tela.
        //Boas praticas = Quando vc tem uma variavel estatica vc deve colocar seu nome em maiusculo
        public static int LARGURA = 640, ALTURA = 400;
        //permite carregar elementos em 2D
        public static Texture2D textura;
    }
}
