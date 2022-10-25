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

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            //spielen

            int label1 = Random1();
            int label2 = Random2();
            int label3 = Random3();
            lb1.Content = Converter(label1);
            lb2.Content = Converter(label2);
            lb3.Content = Converter(label3);

            lb4.Content = Pointscalculation(label1,label2,label3);
        }


        static Random rng = new Random();

        private static int Random1()
        {
            int random1 = rng.Next(2, 15);
            return random1;
        }
        private static int Random2()
        {
            int random2 = rng.Next(2, 15);
            return random2;
        }
        private static int Random3()
        {
            int random3 = rng.Next(2, 15);
            return random3;
        }
        private static string Converter(int random)
        {
            string show = "";
            if (random == 14)
            { show = "A"; }
            else if (random == 11)
            { show = "J"; }
            else if (random == 12)
            { show = "Q"; }
            else if (random == 13)
            { show = "K"; }
            else { show = Convert.ToString(random); }

            return show;
        }
        private static int Pointscalculation(int label1, int label2, int label3)
        {

            int points = 0;
            
            if (label1 == label2 && label2 == label3)
            {
                points = label1 * 100;
            }
            else
            {
                if (label1 == label2)
                {
                    points = (label1 * 10);
                }
                else if (label2 == label3)
                {
                    points = (label2 * 10);
                }
                else if (label1 == label3)
                {
                    points = (label1 * 10);
                }
                
            }
            return points;
        }
    }
}