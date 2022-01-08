using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.UI
{
    class UIComponent
    {
        public UIEntity entity;

        public virtual void Update(GameTime gameTime) { }
    }
}
