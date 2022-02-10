using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace wisp.EC //EC system heavily inspired by monofoxe
{
    public class Entity
    {
        public bool enabled = true, visible = true;
        
        public int ID;
        private List<Component> components = new List<Component>();
        private Dictionary<Type, Component> componentDict = new Dictionary<Type, Component>();

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

        //syntax sugar functions:
        public void AddBatch(params Component[] components)
        {
            foreach (Component comp in components)
                AddComponent(comp);
        }

        public T Get<T>() where T : Component => (T)componentDict[typeof(T)];
    }
}