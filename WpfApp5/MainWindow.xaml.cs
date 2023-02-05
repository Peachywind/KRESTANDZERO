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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
     public partial class MainWindow : Window
    {
        static int count = 0;
        string[,] values = new string[3, 3];
        public MainWindow()
        {
         
        }

        private  void Button_Click(object sender, RoutedEventArgs e)

        {
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
            b10.Visibility = Visibility.Hidden;
            int x = 1;
            switch (IsWin())
            {
                case 0:
                    count++;
                    if (count % 2 != 0)
                    {
                        ((Button)e.OriginalSource).Content = "X";
                        ((Button)e.OriginalSource).IsEnabled = false;
                    }
                    else
                    {
                        ((Button)e.OriginalSource).Content = "O";
                        ((Button)e.OriginalSource).IsEnabled = false;
                    }
                    break;

                case 1:
                    MessageBox.Show("Player X WIN!");
                    break;

                case 2:
                    MessageBox.Show("Player O WIN!");
                    break;
            }


        }
        int Player =0 ;
        private int IsWin()
        {
           
            if (b1.Content == "X" & b2.Content == "X" & b3.Content == "X")
                return 1;
            else if (values[0, 0] == "X" & values[1, 0] == "X" & values[2, 0] == "X")
                return 1;
            else if (values[2, 0] == "X" & values[2, 1] == "X" & values[2, 2] == "X")
                return 1;
            else if (values[0, 2] == "X" & values[1, 2] == "X" & values[2, 2] == "X")
                return 1;
            else if (values[0, 0] == "X" & values[1, 1] == "X" & values[2, 2] == "X")
                return 1;
            else if (values[0, 2] == "X" & values[1, 1] == "X" & values[2, 0] == "X")
                return 1;

            if (values[0, 0] == "O" & values[0, 1] == "O" & values[0, 2] == "O")
                return 2;
            else if (values[0, 0] == "O" & values[1, 0] == "O" & values[2, 0] == "O")
                return 2;
            else if (values[2, 0] == "O" & values[2, 1] == "O" & values[2, 2] == "O")
                return 2;
            else if (values[0, 2] == "O" & values[1, 2] == "O" & values[2, 2] == "O")
                return 1;
            else if (values[0, 0] == "O" & values[1, 1] == "O" & values[2, 2] == "O")
                return 2;
            else if (values[0, 2] == "O" & values[1, 1] == "O" & values[2, 0] == "O")
                return 2;

            else return 0;

        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
     