using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Diagnostics;

namespace wisp
{
    public static class Primitives
    {
        public static Texture2D pixel;

        public static void Initialize()
        {
            Texture2D texture = new Texture2D(Globals.graphics.GraphicsDevice, 1, 1);
            Color[] data = new Color[1];
            data[0] = Color.White;
            texture.SetData(data);
            pixel = texture;
        }


        public static void DrawRect(Vector2 pos, Vector2 dim, Color color)
        {
            Globals.spriteBatch.Draw(pixel, new Rectangle((int)pos.X, (int)pos.Y, (int)dim.X, (int)dim.Y), color);
        }
    }
}
