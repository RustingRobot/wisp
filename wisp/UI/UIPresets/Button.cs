using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.UI.UIPresets
{
    class Button : Entity
    {
        public Button()
        {
            CColor color = new CColor();
            color.bgColor = new Color(80,80,80);
            AddComponent(color);
        }
    }
}
