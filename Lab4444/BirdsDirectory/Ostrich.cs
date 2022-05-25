using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4444.BirdsDirectory
{
    internal class Ostrich : NonFlyingBird
    {
        public Ostrich(int age, double mvspeed, double flheight, bool canFly) : base(age, mvspeed, flheight, canFly)
        {
           
        }
        public Ostrich() : base()
        {

        }
    }
}
