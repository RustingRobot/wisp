using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using wisp.EC;
using wisp.EC.ComponentPresets;

namespace wisp.UI.UIPresets
{
    class Button : Entity
    {
        public Button()
        {
            CTransform transform = new CTransform();
            CColor color = new CColor(Color.Gray);
            AddBatch(transform, color);

            color.bgColor = new Color(80,80,80);
        }
    }
}
