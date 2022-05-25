using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4444.BirdsDirectory
{
    internal class Penguin : NonFlyingBird
    {
        public Penguin(int age, double mvspeed, double flheight, bool canFly) : base(age, mvspeed, flheight, canFly)
        {

        }
        public Penguin() : base()
        {

        }
    }
}
