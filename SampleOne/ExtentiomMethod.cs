using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleOne
{
    public class ExtentiomMethod
    {
        //public static string toShamsi(this DateTime value)
        //{
        //    PersianCalendar pc = new PersianCalendar();
        //    var result = pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" + pc.GetDayOfMonth(value);
        //    return result;
        //}


        public List<PosClass> pos = new List<PosClass>();
        public int count = 0;



        public void doShiftNames(string name, int posx, int posy)
        {
            if (!pos.Any(x => (x.posY == posy) && (x.posStartX <= posx && posx <= x.posEndX)))
            {
                pos.Add(new PosClass { name = name, posStartX = posx, posEndX = posx + name.Length - 1, posY = posy });
                Console.WriteLine(name);
            }
            else
            {
                count++;
            }
        }


    }
}
