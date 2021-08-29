using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;
using wisp.Utilities;

namespace wisp
{
    public class wispWrapper : Game
    {
        
        public wispWrapper()
        {
            Globals.graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        { 
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D texture = new Texture2D(GraphicsDevice, 1, 1);
            Color[] data = new Color[1];
            data[0] = Color.White;
            texture.SetData(data);
            Primitives.pixel = texture;
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);
        }

        protected void LateDraw(GameTime gameTime)
        {

        }
    }
}
