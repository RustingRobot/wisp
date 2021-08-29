using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace wisp.UI
{
    class Button : UIElement
    {
        Label text;
        Color hoverColor, clickColor;
        Texture2D image;

        public delegate void Event();
        public Event ClickEvent;

        public Button()
        {
            text.foregroundColor = foregroundColor;
        }

        public void Draw(GameTime gameTime)
        {
            if (image == null)
                Globals.spriteBatch.Draw(image, new Rectangle(pos.ToPoint(), dim.ToPoint()), Color.White);
            else
                Primitives.DrawRect(pos, dim, backgroundColor);
            text.Draw();
        }
    }
}