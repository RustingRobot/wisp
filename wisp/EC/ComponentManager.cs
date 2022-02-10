using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using wisp.EC.ComponentPresets;

namespace wisp.EC
{
    class ComponentManager //the idea: avoid at least some CPU cache misses by executing all components bundled by their declaring type
    {  
        private static Dictionary<Type, List<Component>> UpdateRegistry = new Dictionary<Type, List<Component>>(), DrawRegistry = new Dictionary<Type, List<Component>>();

        public static void Register(Component component)
        {
            if (UpdateRegistry.ContainsKey(component.GetType()))
                UpdateRegistry[component.GetType()].Add(component);
            else if (component.GetType().GetMethod("Update").DeclaringType == component.GetType())
                UpdateRegistry.Add(component.GetType(), new List<Component>() { component });

            if (DrawRegistry.ContainsKey(component.GetType()))
                DrawRegistry[component.GetType()].Add(component);
            else if (component.GetType().GetMethod("Draw").DeclaringType == component.GetType())
                DrawRegistry.Add(component.GetType(), new List<Component>() { component });
        }

        public static void Update(GameTime gameTime)
        {
            foreach (List<Component> components in UpdateRegistry.Values)
                for (int i = 0; i < components.Count; i++)
                    if(components[i].enabled) components[i].Update(gameTime);
        }

        public static void Draw(GameTime gameTime)
        {
            foreach (List<Component> components in DrawRegistry.Values)
                for (int i = 0; i < components.Count; i++)
                    if (components[i].visible) components[i].Draw(gameTime);
        }
    }
}
