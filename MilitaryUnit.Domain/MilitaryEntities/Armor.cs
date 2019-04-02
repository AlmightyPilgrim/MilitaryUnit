using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain.MilitaryEntities
{
    public class Armor : MilitaryEntity
    {
        public Armor()
        {

        }

        public override void Movement()
        {
            Console.WriteLine("Faster than the infantry");
        }
    }
}
