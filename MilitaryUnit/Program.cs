using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryUnit.Domain;
using MilitaryUnit.Domain.MilitaryEntities;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Infantry soldier = new Infantry();
            AirSupport planes = new AirSupport();
            Armor tank = new Armor();
            Artillery biggun = new Artillery();

            soldier.Movement();
            planes.Movement();
            tank.Movement();
            biggun.Movement();

            List<MilitaryEntity> testFire = new List<MilitaryEntity> { new Infantry(), new Armor(), new AirSupport(), new Artillery() };

            foreach (var fire in testFire)
            {
                fire.WeaponFire();
            }
        }
    }
}
