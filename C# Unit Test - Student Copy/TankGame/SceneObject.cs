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
        public SceneObject Parent
        {
            get => Parent;
            set
            {
                if (Parent != null)
                    Parent.Children.Remove(this);

                Parent = value;
                Parent.Children.Add(this);
            }
        }
        public List<SceneObject> Children = new List<SceneObject>();

        /// GRAPHICS
        public float Scale = 1;
        public float Rotation = 0;
        protected Vector3 offset = new Vector3();
        protected Texture2D sprite;


        


        public SceneObject()
        { }
    }
}
