using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.EC //EC system heavily inspired by monofoxe
{
    public enum direction { horizontal, vertical };
    public class Entity
    {
        public Vector2 pos, dim;
        public bool enabled = true, visible = true;
        
        public int ID;
        private List<Component> components = new List<Component>();
        private Dictionary<Type, Component> componentDict;

        public Component AddComponent(Component component)
        {
            componentDict.Add(component.GetType(), component);
            components.Add(component);
            component.owner = this;
            component.Initialize();
            return component;
        }

        public Component RemoveComponent(Type type)
        {
            if (HasComponent(type))
            {
                Component tempComp = componentDict[type];
                tempComp.Delete();
                componentDict.Remove(type);
                components.Remove(tempComp);
                tempComp.owner = null;
                return tempComp;
            }
            return null;
        }

        public T GetComponent<T>() where T : Component => (T)componentDict[typeof(T)];
        
        public bool HasComponent(Type type) => componentDict.ContainsKey(type);
    }
}