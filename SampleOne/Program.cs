using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleOne
{
    internal class Program
    {
        public static void getChar(string name)
        {
            foreach (char item in name)
            {
                Console.Write(item);
                Thread.Sleep(30);
            }
        }

        static void Main(string[] args)
        {
            string[] collectionName = { "Ali", "Reza", "Mahdi", "Sara", "Negar", "Ahmad" };
            Random random = new Random();
            ExtentiomMethod method = new ExtentiomMethod();

            for (int i = 0; i < 20;)
            {
                int index = random.Next(collectionName.Length);
                string name = collectionName[index];
                int posX = random.Next(1, 70);
                int posY = random.Next(1, 25);
                int indexNumber = random.Next(6);
                Console.ForegroundColor = indexNumber.ToColor();
                Console.SetCursorPosition(posX, posY);
                method.doShiftNames(name, posX, posY);
                i++;
                Thread.Sleep(500);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 16);
            Console.WriteLine($"count:{method.count}");
            foreach (var item in method.pos)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();

        }
    }
}
