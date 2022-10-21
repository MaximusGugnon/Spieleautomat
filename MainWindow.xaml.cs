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

namespace Spieleautomat
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();




        }

        private static int Points()
        {
        
        }
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            //spielen

            lb1.Content = Random1();
            lb2.Content = Random1();
            lb3.Content = Random1();
        }

        static Random rng = new Random();

        private static string Random1()
        {
            string show = "";
            int random = rng.Next(1, 15);

            if (random == 14)
            { show = "A"; }
            else if (random == 11)
            { show = "J"; }
            else if (random == 12)
            { show = "Q"; }
            else if (random == 13)
            { show = "K"; }
            
            else {show = Convert.ToString(random);}
            return show;

        }


    }
}