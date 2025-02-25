using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Pong.Entidades;
using System.Threading;

namespace Pong
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private Raquete raquete1;
        private Raquete raquete2;
        private Bola bola;

        private SpriteFont fonte;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = Global.LARGURA;
            _graphics.PreferredBackBufferHeight = Global.ALTURA;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            raquete1 = new Raquete(false);
            raquete2 = new Raquete(true);
            bola = new Bola();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            Global.spriteBatch = new SpriteBatch(GraphicsDevice);

            Global.textura = new Texture2D(GraphicsDevice, 1, 1);
            Global.textura.SetData<Color>([Color.White]);

            fonte = Content.Load<SpriteFont>("Pontuacao");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            raquete1.Update(gameTime);
            raquete2.Update(gameTime);
            bola.Update(gameTime, raquete1, raquete2);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            Global.spriteBatch.Begin();

            raquete1.Draw();
            raquete2.Draw();
            bola.Draw();

            Global.spriteBatch.DrawString(fonte, Global.pontuacao1.ToString(), new Vector2(80, 50), Color.White);

            Global.spriteBatch.DrawString(fonte, Global.pontuacao2.ToString(), new Vector2(Global.LARGURA - 80, 50), Color.White);


            Global.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
