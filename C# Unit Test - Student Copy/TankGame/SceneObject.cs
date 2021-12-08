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
        /// Reference to the parent object
        private SceneObject parent;
        public SceneObject Parent
        {
            get => parent;
            set
            {
                if (parent != null)
                    parent.Children.Remove(this);

                parent = value;
                if (value == null)
                    return;

                parent.Children.Add(this);
            }
        }
        /// Reference to this game objects children
        public List<SceneObject> Children = new List<SceneObject>();

        /// GRAPHICS
        public float Scale = 1;                     // Scale the sprite will be set to
        public float Rotation = 0;                  // Rotation of the sprite
        protected Vector3 offset = new Vector3();           // The visual offset from the position
        protected Texture2D sprite;                 // Reference to the sprite image

        /// Positional Properties
        protected Matrix3 localTransform = new Matrix3();           // The local position of this game object
        public Matrix3 GlobalTransform = new Matrix3();             // The global position of this game object
        // Returns an updated version of the localTransform
        protected Matrix3 LocalTransform                                        
        {
            get
            {
                return
                    new Matrix3(1, 0, 0, 0, 1, 0, Position.x, Position.y, 1) *
                    Globals.RotationMatrix2D(Rotation) *
                    new Matrix3(Scale, 0, 0, 0, Scale, 0, 0, 0, 1);
            }
        }
        public float GlobalRotation
        {
            get => (float)Math.Atan2(GlobalTransform.m2, GlobalTransform.m1);
        }

        public Vector3 GlobalPosition
        {
            get => new Vector3(GlobalTransform.m7, GlobalTransform.m8, 1);
        }

        /// PHYSICS
        protected Vector3 position = new Vector3(0, 0, 1);          // Reference to the relative position of its parent
        protected Vector3 velocity = new Vector3();                 // Current relative velocity to the parent
        protected float friction = 0.9f;                            // Slow to stop
        protected float minSpeed = 0.01f;                           // Min Speed before the object comes to a stop

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
        private float rotationShift = 0;
        public float RotationShift { set => rotationShift = value; }
        protected Vector3 accelaration = new Vector3();

        


        public SceneObject()
        { }

        public SceneObject(Vector3 pos, Vector3 vel, float rot, SceneObject parent)
        {
            Position = pos;
            Velocity = vel;
            Rotation = rot;
            localTransform = LocalTransform;
            GlobalTransform = parent.GlobalTransform * localTransform;
            Parent = parent;

            Globals.AllObjectsInScene.Add(this);
            
        }
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

        public void PhysicsUpdate()
        {
            Velocity += accelaration * Globals.DeltaTime;
            accelaration = new Vector3();

            Position = Velocity * Globals.DeltaTime;
            Velocity *= (float)Math.Pow(1 - friction, Globals.DeltaTime);

            Rotation += rotationShift * Globals.DeltaTime;
            rotationShift = 0;

            foreach(var child in Children)
            {
                child.PhysicsUpdate();
            }
        }

        public void GlobalTransformUpdate()
        {
            if (!bIsDirty)
                return;

            bIsDirty = false;
            if(Parent != null)
            {
                GlobalTransform = Parent.GlobalTransform * localTransform;
            }

            if(Children.Count > 0)
            {
                foreach(var child in Children)
                {
                    child.GlobalTransformUpdate();
                }
            }
        }

        public void LocalTransformUpdate()
        {
            if(!bIsDirty)
            {
                return;
            }

            localTransform = LocalTransform;

            if (Children.Count > 0)
            {
                foreach (var child in Children)
                {
                    child.LocalTransformUpdate();
                }
            }
        }

        public void Draw()
        {

            DrawTextureEx(
                sprite,
                new System.Numerics.Vector2(GlobalTransform.m7, GlobalTransform.m8) +
                Globals.Vec3toVec2(Globals.RotationMatrix2D(GlobalRotation) * offset * Scale),
                GlobalRotation * (float)(180.0f / Math.PI),
                Scale,
                Color.WHITE
                );

            foreach(var child in Children)
            {
                child.Draw();
            }
        }

        public virtual void Update()
        {
            foreach(var child in Children)
            {
                child.Update();
            }
        }

        private float GetDirectionTo(SceneObject so)
        {
            return (float)Math.Atan2(so.Position.y - Position.y, so.Position.x - Position.x) - (float)Math.PI / 2;
        }
    }
}
