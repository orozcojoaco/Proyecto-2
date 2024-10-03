using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Project1.Clases;
namespace Project1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Clases.Controlador _controlador;
        private ContentManager _context;
        const int PANTALLA_ALTO = 600;
        const int PANTALLA_LARGO = 600;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = PANTALLA_ALTO;
            _graphics.PreferredBackBufferHeight = PANTALLA_LARGO;
            _graphics.IsFullScreen = false;
            Window.Title = "Aviador";
            Content.RootDirectory = "Content";
            
            IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this._spriteBatch = new SpriteBatch(GraphicsDevice);
            
            this._context = Content;
            _controlador = new Clases.Controlador(PANTALLA_ALTO, PANTALLA_LARGO, _context, _spriteBatch);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            this._controlador.Actualizar();
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            this._controlador.Dibujar();
            _spriteBatch.End();
            base.Draw(gameTime);
        }
        protected override void UnloadContent()
        {
            base.UnloadContent();   
        }
    }
}
