using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain.MilitaryEntities
{
    public class AirSupport : MilitaryEntity
    {
        public AirSupport()
        {

        }

        public override void Movement()
        {
            Console.WriteLine("These go faster than all other pieces of military equipment");
        }
    }
}
