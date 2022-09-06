using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOne
{
    public  class PosClass
    {
        public int posStartX { get; set; }
        public int posEndX { get; set; }
        public int posY { get; set; }
        public string name { get; set; }


        public override string ToString()
        {
            return name +"\t"+ posStartX +"\t"+ posEndX +"\t"+ posY ;
        }
    }
}
