using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Pong.Entidades
{
    public class Raquete
    {
        //pegar o Rectangle do Microsoft.Xna.framework
        public Rectangle retangulo;

        //Metodo Construtor = eh o metodo que tem o mesmo nome da classe
        //Determina o que vai acontecer quando eu criar um objeto raquete
        public Raquete()
        {
                //onde o retangulo vai comecar na tela e o tamanho dele (x, y, width, height)
                retangulo = new Rectangle(0,140, 30, 180);
        }

        //O que acontece com o objeto quando cada tecla eh pressionada
        public void Update(GameTime gametime)
        {
            //pega tudo que a pessoa pressionar no teclado
            KeyboardState teclado = Keyboard.GetState();

         //eixo Y, altura da tela
         if (teclado.IsKeyDown(Keys.W) && retangulo.Y > 0) 
            {
                //o (int) eh tipo um parse, porque pixel nao pode ser quebrado
                //(400 * ) tempo da animacao, pra raquete nao se movimentar travando, vai se movimentar suave
                //Tempo Delta = tempo q um elemento leva pra chegar a algum lugar da tela
                retangulo.Y -= (int)(400 * gametime.ElapsedGameTime.TotalSeconds);
            }

            //calcular
            if (teclado.IsKeyDown(Keys.S) && retangulo.Y < Global.ALTURA - retangulo.Height)
            {
                //eh mais pq o Y ta aumentando quando vai pra baixo
                retangulo.Y += (int)(400 * gametime.ElapsedGameTime.TotalSeconds);
            }


        }

        public void Draw()
        {
            Global.spriteBatch.Draw(Global.textura, retangulo, Color.White);

        }
    }
}
