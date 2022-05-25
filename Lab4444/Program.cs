using Lab4444.BirdsDirectory;

namespace Lab4444
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IZoo zoo1 = new Zoo();


            Eagle eagle = new(5, 30, 100, true);
            eagle.MeasureRelocationSpeed(12);
            Parrot parrot = new Parrot();
            Ostrich ostrich = new Ostrich();
            Penguin penguin = new Penguin();
            BaseBird bird = new BaseBird();
            eagle.DisplayProperties();
            eagle.AddToRepository(eagle);
            foreach(BaseBird item in zoo1.birdList)
            {
                Console.WriteLine(item);
            }       
         
        }    
    }
}