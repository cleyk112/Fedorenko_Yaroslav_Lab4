using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4444
{
    public class Zoo : IZoo
    {
        public List<BaseBird> birdList {get; set; }

        public Zoo()
        {
            birdList = new List<BaseBird>();
        }
        public void AddToRepository(BaseBird bird)
        {
             birdList?.Add(bird);
        }
    }
}
