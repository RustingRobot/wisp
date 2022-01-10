using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.EC.ComponentPresets
{
    class CContainer : Component
    {
        private Entity parent;
        private List<Entity> children = new List<Entity>();

        private direction Orientation = direction.vertical;
    }
}
