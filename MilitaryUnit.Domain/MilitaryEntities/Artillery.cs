using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain.MilitaryEntities
{
    public class Artillery : MilitaryEntity
    {
        public Artillery()
        {

        }

        public override void Move()
        {
            Console.WriteLine("Slower than the infantry");
        }
    }
}
