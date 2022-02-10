using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.EC.ComponentPresets
{
    public enum direction { horizontal, vertical};
    class CContainer : Component
    {
        private Entity parent;
        private List<Entity> children = new List<Entity>();

        private direction Orientation = direction.vertical;
    }
}
