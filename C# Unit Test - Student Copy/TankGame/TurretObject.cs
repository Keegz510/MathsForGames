using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;

namespace TankGame
{
    public class TurretObject : SceneObject
    {
        private float barrelLength;
        private float rotation = 0;
        private Vector3 aimPosition = new Vector3();

        public new float Rotation
        {
            get => rotation;
            set
            {
                if (value == rotation) return;

                rotation = (value + 2 * (float)Math.PI) % (2 * (float)Math.PI);
                AimPosition = Globals.PointOffsetDistDir(barrelLength, rotation);
                MakeDirty();
            }
        }

        public Vector3 AimPosition
        {
            get => GlobalTransform * aimPosition;
            set => aimPosition = value;
        }

        public TurretObject(Vector3 position, float rotation, SceneObject parent)
            : base(position, new Vector3(0, 0, 0), rotation, parent)
        {
            sprite = Raylib_cs.Raylib.LoadTexture("barrelBlue.png");                   //Set image to the specified index of the spriteset
            offset = new Vector3(-sprite.width / 2, -sprite.height / 5, 0);           //Set the offset as specified
            barrelLength = sprite.height * Scale;                                                //Set the length to the appropriate value
            AimPosition = Globals.PointOffsetDistDir(barrelLength, rotation);                         //Set the initial AimPosition
        }

        // TODO: Fire Weapon
    }
}
