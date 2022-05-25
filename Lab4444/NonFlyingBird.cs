using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4444
{
    internal class NonFlyingBird : BaseBird
    {
  
        public NonFlyingBird(int age, double mvspeed, double flheight, bool canFly) : base(age, mvspeed, flheight, canFly)
        {
            canFly = false;
            flheight = 0;
        }

        public NonFlyingBird() : base()
        {

        }

        public double MeasureFootSpeed()
        {
            return MoveSpeed();
        }
    }
}
