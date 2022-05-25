using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4444
{
    internal interface IZoo
    {
        public List<BaseBird> birdList { get; set; }
        void AddToRepository(BaseBird bird);
    }
}
