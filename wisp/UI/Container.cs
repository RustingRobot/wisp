using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.UI
{
    public enum direction { horizontal, vertical };
    class Container : UIElement
    {
        public List<UIElement> UIElements = new List<UIElement>();
        public direction Orientation = direction.vertical;
    }
}
