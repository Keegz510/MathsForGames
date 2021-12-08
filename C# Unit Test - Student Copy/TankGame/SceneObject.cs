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

        


        public SceneObject()
        { }
    }
}
