using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;
using Raylib_cs;
using static Raylib_cs.Raylib;
namespace TankGame
{
    public class SceneObject
    {
        protected SceneObject parent;
        public SceneObject Parent { get => parent; }

        protected List<SceneObject> children = new List<SceneObject>();
        public List<SceneObject> Children { get => children; }

        public SceneObject()
        {

        }

        public SceneObject(SceneObject parent)
        {
            this.parent = parent;
        }

        public SceneObject(SceneObject parent, List<SceneObject> children)
        {
            this.parent = parent;
            this.children = children;
        }

        public void SetParent(SceneObject newParent)
        {
            if(parent != null)
            {
                parent.RemoveChild(this);
            }

            parent = newParent;
            parent.AddChild(this);
        }

        public void AddChild(SceneObject newChild)
        {
            if(!children.Contains(newChild))
            {
                children.Add(newChild);
            }
        }

        public void RemoveChild(SceneObject child)
        {
            if(children.Contains(child))
            {
                children.Remove(child);
            }
        }

    }
}
