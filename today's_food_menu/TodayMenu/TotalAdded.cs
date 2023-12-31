using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace TodayMenu
{
    class TotalAdded : CheckAdd, DisplayOnMainMenu
    {
        int Number { get; set; }
        public bool CountReadingTxt()
        {
            bool lineCheck = false;
            int count = 0;
            using StreamReader showMenu = new($"{base.filePath}");           

            while (!showMenu.EndOfStream)
            {
                string foodList = showMenu.ReadLine();

                count++;
                lineCheck = true;

            }

            Number = count;
            return lineCheck;
        }

        public void showDetails()
        {
            if (CountReadingTxt())
            {
                Console.WriteLine("Today's menu have >>>");

                using StreamReader showMenu = new($"{base.filePath}");

                while (!showMenu.EndOfStream)
                {
                    string foodList = showMenu.ReadLine();

                    Console.WriteLine(foodList);
                };

                Console.WriteLine($"There are {Number} types of food.");
                Console.WriteLine();
            }
        }          
    }
}
