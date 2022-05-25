using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4444
{
    //base class
    public class BaseBird :Zoo
    {
        private int age;
        private double mvspeed;
        private double flheight;
        private bool canFly;

        //ctors
        public BaseBird()
        {
            age = 0;
            mvspeed = 0;
            canFly = false;
            flheight = 0;
        }
        public BaseBird(int age, double mvspeed, double flheight, bool canFly)
        {
            this.age = age;
            this.mvspeed = mvspeed;
            this.flheight = flheight;
            this.canFly = canFly;
           
            if (!canFly)
            {
                 this.flheight = 0;
            } 
            else
            {
                 this.flheight = flheight;
            }
        }

        //
        public double FlightHeight()
        {
            return flheight;
        }

        public double MoveSpeed()
        {
            return mvspeed;
        }


        //test inheritable method
        public void MeasureRelocationSpeed(double distance) 
        {
            if (canFly && mvspeed != 0 )
            {
                double time = distance / mvspeed;
                Console.WriteLine("The time to complete {0} km: {1} hours", distance, time);
            }
            else
            {
                Console.WriteLine("The bird is stationary therefore it cant complete the distance");
            }
        }

        public void DisplayProperties()
        {
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Move speed: " + mvspeed);
            Console.WriteLine("Fly height: " + flheight);
            Console.WriteLine("Can fly: " + canFly);
        }

       
        public static BaseBird AddBird(int age, double mvspeed, double flheight, bool canFly)
        {
            
            return new BaseBird(age, mvspeed, flheight, canFly);

        }
    }
}
