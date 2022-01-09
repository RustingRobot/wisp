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
        public bool enabled = true, visible = true;
        
        public int ID;
        private List<UIComponent> components = new List<UIComponent>();
        private Dictionary<Type, UIComponent> componentDict; //inspired by monofoxe

        public void AddComponent(UIComponent component)
        {
            componentDict.Add(component.GetType(), component);
            components.Add(component);
            component.owner = this;
            component.Initialize();
        }

        public void RemoveComponent(Type type)
        {
            if(componentDict.TryGetValue(type, out UIComponent tempComp))
            {
                tempComp.Delete();
                componentDict.Remove(type);
                components.Remove(tempComp);
                tempComp.owner = null;
            }
        }

        public T GetComponent<T>() where T : UIComponent => (T)componentDict[typeof(T)];
        
        public bool HasComponent(Type type) => componentDict.ContainsKey(type);

        public bool TryGetComponent<T>(out T component) where T : UIComponent
        {
            var result = componentDict.TryGetValue(typeof(T), out UIComponent c);
            component = (T)c;
            return result;
        }
        
        public bool TryGetComponent(out UIComponent component, Type type) =>
            componentDict.TryGetValue(type, out component);
    }
}
