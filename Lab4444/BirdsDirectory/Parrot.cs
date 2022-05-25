using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4444.BirdsDirectory
{
    internal class Parrot : BaseBird
    {
        public Parrot() : base()
        {
        }

        public Parrot(int age, double mvspeed, double flheight, bool canFly) : base(age, mvspeed, flheight, canFly)
        {

        }
    }
}
