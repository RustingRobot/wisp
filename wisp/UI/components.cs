using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.UI
{
    class CColor : UIComponent
    {
        public Color bgColor;
        public CColor()
        {
            colorSys.Register(this);
        }

        public override void Draw(GameTime gameTime)
        {
            Primitives.DrawRect(entity.pos, entity.dim, bgColor);
        }
    }

    class CContainer : UIComponent
    {
        private UIEntity parent;
        private List<UIEntity> children = new List<UIEntity>();

        private direction Orientation = direction.vertical;
    }
}
