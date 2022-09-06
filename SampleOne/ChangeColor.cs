using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleOne
{
    public static class ChangeColor
    {
        public static ConsoleColor ToColor( this int indexnumber)
        {
            switch (indexnumber)
            {
                case 0:
                    return ConsoleColor.Green;
                case 1:
                    return ConsoleColor.Blue;
                case 2:
                    return ConsoleColor.Red;
                default:
                    return ConsoleColor.Yellow;
            }
        }
    }
}
