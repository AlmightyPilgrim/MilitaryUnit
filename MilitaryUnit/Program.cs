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

            soldier.Move();
            planes.Move();
            tank.Move();
            biggun.Move();
        }
    }
}
