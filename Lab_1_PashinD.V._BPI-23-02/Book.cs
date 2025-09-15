using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_PashinD.V._BPI_23_02
{
    public class Book
    {
        private string title;
        private int pages;
        private double cost;

        public string Title { get; set; }
        public int Pages { get; set; }
        public double Cost { get; set; }

        public Book(string title, int pages, double cost)
        {
            Title = title;
            Pages = pages;
            Cost = cost;
        }

        public double avgCostPage(int pages, double cost)
        {
            int avgCost = 0;
            avgCost = (int)cost / pages;
            return avgCost;
        }

        public double changeCost(string key, double cost)
        {
            if (key.Contains("Программирование")) cost = cost * 2;
            return cost;
        }
    }
}
