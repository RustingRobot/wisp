using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace wisp
{
    public static class Primitives
    {
        public static Texture2D pixel;

        public static void DrawRect(Vector2 pos, Vector2 dim, Color color)
        {
            Globals.spriteBatch.Draw(pixel, new Rectangle((int)pos.X, (int)pos.Y, (int)dim.X, (int)dim.Y), color);
        }
    }
}
