using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.UI
{
    class BaseSys<T> where T : UIComponent
    {
        protected static List<T> components = new List<T>();

        public static void Register(T component)
        {
            components.Add(component);
        }

        public static void Update(GameTime gameTime)
        {
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Update(gameTime);
            }
        }

        public static void Draw(GameTime gameTime)
        {
            for (int i = 0; i < components.Count; i++)
            {
                components[i].Draw(gameTime);
            }
        }
    }

    class colorSys : BaseSys<CColor> { }
}
