using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TodayMenu
{
    class CheckAdd : FoodDetail, DisplayOnMainMenu
    {
        string CountryAndFood { get; set; }
        readonly List<string> alreadyAddedList = new();
        readonly HashSet<string> foodNotDuplicate = new();
        protected string filePath = "C:\\Users\\wiwee\\Desktop\\practice_cs\\today's_food_menu\\TodayMenu\\output.txt";

        public void AddNumberCheck(int inputNumber)
        {
            base.SetDetails(inputNumber);
            CountryAndFood = $"[ {base.Country} ] >>> {base.FoodName}";

            if(alreadyAddedList.Contains(CountryAndFood))
            {
                Console.WriteLine($"You select duplicates. !!!. Please select another item.");
            }
            else
            {
                using StreamReader checkSameNumberInTxt = new($"{filePath}");

                while (!checkSameNumberInTxt.EndOfStream)
                {
                    string checkSame = checkSameNumberInTxt.ReadLine();

                    foodNotDuplicate.Add(checkSame);
                };
                
                if(!foodNotDuplicate.Contains(CountryAndFood))
                {
                    alreadyAddedList.Add(CountryAndFood);
                    Console.WriteLine($"[ {base.Country} ] has already added.");
                }
                else
                {
                    Console.WriteLine($"!!! [ {base.Country} ] has been added to the menu in the previous selection !!!");
                    Console.WriteLine("Please select another item.");
                }                               
            }
        }

        public void showDetails()
        {
            using StreamWriter saveAdded = new($"{filePath}", true);
            if (alreadyAddedList.Count != 0)
            {
                Console.WriteLine("Today's menu has already added.");
                foreach (string detail in alreadyAddedList)
                {
                    saveAdded.WriteLine(detail);
                    Console.WriteLine(detail);
                }
            }
        }
    }
}
