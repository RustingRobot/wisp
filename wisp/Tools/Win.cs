using Microsoft.Xna.Framework.Graphics;

namespace wisp.Tools
{
    public static class Win
    {
        public static float Height { get => Globals.graphics.GraphicsDevice.Viewport.Height; }
        public static float Width { get => Globals.graphics.GraphicsDevice.Viewport.Width; }

        public static float ScreenWidth { get => GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width; }
        public static float ScreenHeight { get => GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height; }
    }
}
