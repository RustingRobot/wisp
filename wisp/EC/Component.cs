using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.EC
{
    public abstract class Component
    {
        protected Component()
        {
            ComponentManager.Register(this);
        }

        public Entity owner;
        public bool enabled, visible;
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(GameTime gameTime) { }

        public virtual void Initialize() { }
        public virtual void Delete() { }
    }
}
