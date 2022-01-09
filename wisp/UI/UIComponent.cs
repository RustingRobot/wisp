using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.UI
{
    abstract class UIComponent
    {
        public UIEntity owner;
        public bool enabled, visible;
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(GameTime gameTime) { }

        public virtual void Initialize() { }
        public virtual void Delete() { }
    }
}
