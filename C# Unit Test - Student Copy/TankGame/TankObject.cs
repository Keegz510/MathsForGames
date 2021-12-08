﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;
using MathClasses;

namespace TankGame
{
    public class TankObject : SceneObject
    {
        TurretObject turret;


        /// Movement Settings
        private float AccRate = 100F;                                        //The rate at which the tank accelerates
        private float DecRate = 25F;                                         //The rate at which the tank decelerates/goes backwards
        private float TurnSpeed = 1F;                                        //The rate at which the tank turns
        private float TurretSpeed = 1F;                                      //The rate at which the turret turns


        public TankObject(Vector3 position, Vector3 velocity, float rotation, float turretRot, SceneObject parent)
            : base(position, velocity, rotation, parent)
        {
            sprite = LoadTexture("tankBlue_outline.png");
            offset = new Vector3(-sprite.width / 2, -sprite.height / 2, 0);       //Set the offset as specified
            turret = new TurretObject(new Vector3(0, 0, 1), 0, this);        //Assign it a new turret
            friction = 0.9F;                                                        //Set the friction
        }

        public override void Update()
        {
            base.Update();
        }

        public Vector3 Forward()
        {
            return accelaration = Globals.DistanceDirectionToXY(AccRate, GlobalRotation);
        }

        public Vector3 Backwards()
        {
            return accelaration = Globals.DistanceDirectionToXY(DecRate, (GlobalRotation + (float)Math.PI));
        }

        public float TurnLeft() => RotationShift = -TurnSpeed;
        public float TurnRight() => RotationShift = TurnSpeed;

        public float TurretLeft() => turret.RotationShift = -TurretSpeed;
        public float TurretRight() => turret.RotationShift = TurretSpeed;

        public void Fire()
        {
            // TODO
        }

    }
}
