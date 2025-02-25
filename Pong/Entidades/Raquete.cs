using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;


namespace Pong.Entidades
{
    public class Raquete
    {
        public Rectangle retangulo;
        public bool segundaRaquete;

        // Método que tem o mesmo nome da classe
        // Método Construtor
        // Determina o que acontece quando eu criar objetos dessa classe
        public Raquete(bool segundaRaquete)
        {
            this.segundaRaquete = segundaRaquete;
            retangulo = new Rectangle((this.segundaRaquete ? Global.LARGURA - 30 : 0), 140, 30, 180);
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState teclado = Keyboard.GetState();

            if ((this.segundaRaquete ? teclado.IsKeyDown(Keys.Up) :  teclado.IsKeyDown(Keys.W)) && retangulo.Y > 0)
            {
                // Tempo Delta
                retangulo.Y -= (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            }

            if ((segundaRaquete ? teclado.IsKeyDown(Keys.Down) :  teclado.IsKeyDown(Keys.S)) && retangulo.Y < Global.ALTURA - retangulo.Height)
            {
                retangulo.Y += (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            }


        }

        public void Draw()
        {
            Global.spriteBatch.Draw(Global.textura, retangulo, Color.White);
        }
    }
}
