using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.UI
{
    public enum direction { horizontal, vertical };
    class UIEntity
    {
        public Vector2 pos, dim;
        
        public int ID;
        private List<UIComponent> components = new List<UIComponent>();

        private UIEntity parent;
        private List<UIEntity> children = new List<UIEntity>();


        private direction Orientation = direction.vertical;

        public void AddComponent(UIComponent component)
        {
            components.Add(component);
            component.entity = this;
        }

        public void Update()
        {
            foreach (var child in children)
                child.Update();
        }

        public void Draw()
        {
            foreach (var child in children)
                child.Draw();
        }
    }
}
