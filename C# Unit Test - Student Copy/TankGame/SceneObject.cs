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

        /// Positional Properties
        protected Matrix3 localTransform = new Matrix3();
        public Matrix3 globalTransform = new Matrix3();

        /// PHYSICS
        protected Vector3 position = new Vector3(0, 0, 1);
        protected Vector3 velocity = new Vector3();
        protected float friction = 0.9f;
        protected float minSpeed = 0.01f;

        public Vector3 Position
        {
            get => position;
            set
            {
                if (value == position) return;

                MakeDirty();
                position = value;
            }
        }

        public Vector3 Velocity
        {
            get => velocity;
            set
            {
                velocity = value;
                if(velocity.Magnitude() < minSpeed)
                {
                    velocity = new Vector3();
                }
            }
        }

        /// UPDATE PROPERTIES
        private bool bIsDirty = false;

        


        public SceneObject()
        { }

        public void MakeDirty()
        {
            if (bIsDirty) return;

            bIsDirty = true;
            if(Parent != null)
            {
                Parent.MakeDirty();
            }

            foreach(var child in Children)
            {
                child.MakeDirty();
            }
        }
    }
}
