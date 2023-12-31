using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayMenu
{
    public class FoodDetail
    {
        public int Id { get; set;}
        public string Country { get; set; }
        public string FoodName { get; set; }
        public void SetDetails(int number)
        {
            switch (number)
            {
                case 1:
                    Id = 1;
                    Country = "Thai food";
                    FoodName = "Tom Yum Goong | Som Tam | Pad Krapow";
                    break;
                case 2:
                    Id = 2;
                    Country = "Chinese food";
                    FoodName = "Dim Sum | Xiaolongbao | Peking duck";
                    break;
                case 3:
                    Id = 3;
                    Country = "Japanese food";
                    FoodName = "Gyoza | Katsudon | Ramen";
                    break;
                case 4:
                    Id = 4;
                    Country = "Italian food";
                    FoodName = "Risotto | Pizza | Pasta";
                    break;
                case 5:
                    Id = 5;
                    Country = "Mexican food";
                    FoodName = "Mexican Rice | Gorditas | Grilled Chicken Street Tacos";
                    break;
                default:
                    Console.WriteLine("Invalid input !!!");
                    break;
            }
        }
    }
}
