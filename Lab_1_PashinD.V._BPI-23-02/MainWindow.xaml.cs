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
            var title = Title.Text;
            int pages = Convert.ToInt32(Pages.Text);
            double cost = Convert.ToDouble(Cost.Text); ;

            bookA = new Book(title, pages, cost);
            // int costPage = bookA.avgCostPage(pages, cost);
            //MessageBox.Show("Средняя цена страницы = ", Convert.ToString(costPage));
        }
    }
}
