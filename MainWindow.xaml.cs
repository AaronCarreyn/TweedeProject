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

namespace TweedeProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int teller;
        Random rand = new Random();
        private void btn_click3_Click(object sender, RoutedEventArgs e)
        {
            //Monssef
            int random = rand.Next(10);
            lblOutput3.Content = random.ToString();
        }

        private void btn_click2_Click(object sender, RoutedEventArgs e)
        {
            //Jordy
            teller++;
            lblOutput2.Content = teller.ToString();
        }
    }
}
