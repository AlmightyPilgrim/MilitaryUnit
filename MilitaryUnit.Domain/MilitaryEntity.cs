using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit.Domain
{
    public class MilitaryEntity
    {
        public virtual void Move()
        {
            Console.WriteLine("Basic Movements");
        }

        public void WeaponFire()
        {
            Console.WriteLine("Pew Pew Pew, with the occasional boom");
        }
    }
}
