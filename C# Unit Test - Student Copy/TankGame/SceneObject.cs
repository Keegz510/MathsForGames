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
        #region Parenting
        /// Reference to the parent object of this obejct
        protected SceneObject parent;
        /// returns the parent object
        public SceneObject Parent { get => parent; }
        /// List of children linked to this object
        protected List<SceneObject> children = new List<SceneObject>();
        /// Returns the children of this ohbject
        public List<SceneObject> Children { get => children; }
        #endregion

        #region Object Transform

        /// Reference to the local transform
        protected Matrix3 localTransform = new Matrix3();
        public Matrix3 LocalTransform { get => localTransform;  }
        /// Reference to the global transform
        protected Matrix3 globalTransform = new Matrix3();
        public Matrix3 GlobalTransform { get => globalTransform; }

        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public SceneObject()
        {

        }

        /// <summary>
        /// Constructor with parent
        /// </summary>
        /// <param name="parent">Parent of this object</param>
        public SceneObject(SceneObject parent)
        {
            this.parent = parent;
        }

        /// <summary>
        /// Constructor with parent and children
        /// </summary>
        /// <param name="parent">Parent of this object</param>
        /// <param name="children">List of children to this object</param>
        public SceneObject(SceneObject parent, List<SceneObject> children)
        {
            this.parent = parent;
            this.children = children;
        }

        /// <summary>
        /// Sets a new parent for this object
        /// </summary>
        /// <param name="newParent">The new parent</param>
        public void SetParent(SceneObject newParent)
        {
            if(parent != null)
            {
                parent.RemoveChild(this);
            }

            parent = newParent;
            parent.AddChild(this);
        }

        /// <summary>
        /// Adds a child to the game object
        /// </summary>
        /// <param name="newChild">Child we want to add</param>
        public void AddChild(SceneObject newChild)
        {
            if(!children.Contains(newChild))
            {
                children.Add(newChild);
            }
        }

        /// <summary>
        /// Removes the specified object from the scene
        /// </summary>
        /// <param name="child"></param>
        public void RemoveChild(SceneObject child)
        {
            if(children.Contains(child))
            {
                children.Remove(child);
            }
        }

    }
}
