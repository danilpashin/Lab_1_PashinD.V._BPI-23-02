using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_1_PashinD.V._BPI_23_02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Book bookA { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        public void avgCostPage(object sender, RoutedEventArgs e)
        {
            string title = Title.Text;
            int pages;
            double cost;
            if (title != "" && !string.IsNullOrWhiteSpace(title) && int.TryParse(Pages.Text, out pages) && double.TryParse(Cost.Text, out cost))
            {
                if(pages > 0 && cost >= 0)
                {
                    bookA = new Book(title, pages, cost);
                    double costPage = bookA.avgCostPage(pages, cost);
                    AvgCostPage.Content = Convert.ToString(costPage);
                }
                else
                {
                    MessageBox.Show("Некорректные данные!");
                }
            }
            else
            {
                MessageBox.Show("Неправильный ввод!");
            }
        }

        public void doubleCost(object sender, RoutedEventArgs e)
        {
            string title = Title.Text;
            int pages;
            double cost;
            string key = Key.Text;
            if (title != "" && !string.IsNullOrWhiteSpace(title) && int.TryParse(Pages.Text, out pages) && double.TryParse(Cost.Text, out cost))
            {
                if (pages > 0 && cost >= 0)
                {
                    bookA = new Book(title, pages, cost);
                    double costChanged = bookA.changeCost(title, cost);
                    NewCost.Content = Convert.ToString(costChanged);
                }
                else
                {
                    MessageBox.Show("Некорректные данные!");
                }
            }
            else
            {
                MessageBox.Show("Неправильный ввод!");
            }

        }
    }
}
