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
        public static int rest;
        public static int inbox;
        public int label1;
        public int label2;
        public int label3;

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            IntextboxUmwandeln();
            if (rest + inbox >= 25)
            {
                label1 = Random1();
                label2 = Random1();
                label3 = Random1();
                Addmoney();
                Restberechnen();
                lb1.Content = Converter(label1);
                lb2.Content = Converter(label2);
                lb3.Content = Converter(label3);
                lb4.Content = rest;
                lb5.Content = Gewinn(label1, label2, label3) + " ( + " + Pointscalculation(label1, label2, label3) +" Punkte )" ;
            }
            else MessageBox.Show("Ich brauche mehr Geld");
        }
        static Random rng = new Random();
        private static int Random1()
        {
            int random1 = rng.Next(2, 15);
            return random1;
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
        private static string Gewinn(int label1, int label2, int label3)
        {
            string hallo = "";
            if (label1 == label2 && label2 == label3)
            {
                hallo = " 3 sind gleich ";
            }
            else
            {
                if (label1 == label2)
                {
                    hallo = " 2 sind gleich ";
                }
                else if (label2 == label3)
                {
                    hallo = " 2 sind gleich ";
                }
                else if (label1 == label3)
                {
                    hallo = " 2 sind gleich ";
                }
                else
                {
                    hallo = "Bruh!";
                }

            }
            return hallo;
        }
        private void Addmoney()
        {
            if (tb1.Text.Length > 0)
            {
                rest = rest + Convert.ToInt32(tb1.Text);
                tb1.Text = "";
            }
        }
        private void Restberechnen()
        {
            rest = rest - 25 + Pointscalculation(label1, label2, label3);
        }
        private void IntextboxUmwandeln()
        {
            if (tb1.Text.Length > 0)
            {
                inbox = Convert.ToInt32(tb1.Text);
            }
            else { inbox = 0; }
        }
    }
}
