using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TodayMenu
{
    class ChooseNumberForAdd
    {
        CheckAdd added = new();
        public void TypeForAdd()
        {
            string number;
            do
            {
                number = Console.ReadLine();
                if (number != null && number != "E")
                {
                    int.TryParse(number, out int toIntNumber);
                    if (toIntNumber >= 1 && toIntNumber <= 5)
                    {
                        added.AddNumberCheck(toIntNumber);
                        
                        Console.WriteLine("Add another or type [ E ] if finished.");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input !!! Please type the number [ 1 - 5 ]");
                    }
                }
                else if (number == "E")
                {                   
                    added.showDetails();
                    break;
                }

            } while (number != "E");
        }
                
    }
}
