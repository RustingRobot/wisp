using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using wisp.EC;
using wisp.EC.ComponentPresets;
using wisp.Tools;
using wisp.UI.UIPresets;

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
            Button test = new Button();
            test.GetComponent<CTransform>().pos = new Vector2(80, 80);
            test.GetComponent<CTransform>().dim = new Vector2(80, 20);
            base.Initialize();
        }

        protected override void LoadContent()
        { 
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);
            Primitives.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            ComponentManager.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); 
            
            Globals.spriteBatch.Begin();
            ComponentManager.Draw(gameTime);
            Globals.spriteBatch.End();

            base.Draw(gameTime);
        }

        protected void LateDraw(GameTime gameTime)
        {

        }
    }
}
