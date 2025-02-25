using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Entidades
{
    public class Bola
    {
        Rectangle retangulo;
        int direita = 1, cima = 1, velocidade = 200;

        public Bola()
        {
            retangulo = new Rectangle(Global.LARGURA / 2 - 15, Global.ALTURA / 2 - 15, 30, 30);
        }

        public void Update(GameTime gameTime, Raquete raquete1, Raquete raquete2)
        {
            int delta = (int)(velocidade * gameTime.ElapsedGameTime.TotalSeconds);

            retangulo.X += direita * delta;
            retangulo.Y += cima * delta;

            // Condicionais para saber:
            // Se a bola bater no teto ela tem que descer
            // Se a bola encostar no chao ela tem que subir
            // Se a bola bater na raquete da esquerda ela vai pra direita
            // Se a bola bater na raquete da direita ela vai para a esquerda

            if (retangulo.Y < 0)
            {
                cima *= -1;
            }

            if (retangulo.Y > Global.ALTURA - retangulo.Height)
            {
                cima *= -1;
            }

            // Se encostou na raquete da esquerda
            if (raquete1.retangulo.Right > retangulo.Left && retangulo.Top > raquete1.retangulo.Top && retangulo.Bottom < raquete1.retangulo.Bottom)
            {
                direita = 1;
            }

            // Se encostou na raquete da direita
            if (raquete2.retangulo.Left < retangulo.Right && retangulo.Top > raquete2.retangulo.Top && retangulo.Bottom < raquete2.retangulo.Bottom)
            {
                direita = -1;
            }

            if(retangulo.X < 0)
            {
                Global.pontuacao2 += 1;
                ReiniciarPartida();
            }

            if (retangulo.X > Global.LARGURA - retangulo.Width)
            {
                Global.pontuacao1 += 1;
                ReiniciarPartida();
            }
        }

        public void ReiniciarPartida()
        {
            retangulo.X = Global.LARGURA / 2 - 15;
            retangulo.Y = Global.ALTURA / 2 - 15;
        }

        public void Draw()
        {
            Global.spriteBatch.Draw(Global.textura, retangulo, Color.White);
        }

    }
}
