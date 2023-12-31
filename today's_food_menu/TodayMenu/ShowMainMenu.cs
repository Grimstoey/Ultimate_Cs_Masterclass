using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayMenu
{
    public class ShowMainMenu : FoodDetail, DisplayOnMainMenu
    {
        readonly ChooseNumberForAdd add = new();
        TotalAdded displayAddedList = new();

        private int showId;
        private string showContry = "";

        public void showDetails()
        {
            displayAddedList.showDetails();
            Console.WriteLine("Create today's menu. Choose the number country's food below.\n" +
                              "Type [ E ] if finished.");

            for (int i = 1; i < 6; i++)
            {
                base.SetDetails(i);
                showId = base.Id;
                showContry = base.Country;
                Console.WriteLine($"{showId}. {showContry}");
            }

            add.TypeForAdd();
        }
    }
}
