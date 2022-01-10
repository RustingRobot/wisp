using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.EC.ComponentPresets
{
    class CColor : Component
    {
        public Color bgColor;

        public override void Draw(GameTime gameTime)
        {
            CTransform transform = owner.GetComponent<CTransform>();
            Primitives.DrawRect(transform.pos, transform.dim, bgColor);
        }
    }
}
