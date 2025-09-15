using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_PashinD.V._BPI_23_02
{
    public class Book
    {
        string title;
        int pages;
        double cost;

        public Book(string title, int pages, double cost)
        {
            this.title = title;
            this.pages = pages;
            this.cost = cost;
        }

        public double avgCostPage(int pages, double cost)
        {
            int avgCost = 0;
            avgCost = (int)cost / pages;
            return avgCost;
        }

        public double changeCost(string title, double cost)
        {
            if (title.Contains("Программирование")) cost = cost * 2;
            return cost;
        }
    }
}
