using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankGame
{
    public class TankObject : SceneObject
    {


        /// Movement Settings
        private float AccRate = 100F;                                        //The rate at which the tank accelerates
        private float DecRate = 25F;                                         //The rate at which the tank decelerates/goes backwards
        private float TurnSpeed = 1F;                                        //The rate at which the tank turns
        private float TurretSpeed = 1F;                                      //The rate at which the turret turns
    }
}
