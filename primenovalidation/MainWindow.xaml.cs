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

namespace primenovalidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clickedtimes;

        public MainWindow()
        {
            InitializeComponent();
            clickedtimes = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
           
            if (clickedtimes == 1)
            {
                int n = 1;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {
                int num = 1;

                int n = 10 * num + num;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no" + n);
                    else
                        MessageBox.Show("not prime" + n);
                }
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 2;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {
                int num = 2;
                int n = 10 * num + num;

                
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 3;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {

                int num = 3;

                int n = 10 * num + num;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 4;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {

                int num = 4;

                int n = 10 * num + num;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 5;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {

                int num = 5;

                int n = 10 * num + num;
                for(int i=1;i<=n;i++)
                { 
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 6;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {

                int num = 6;

                int n = 10 * num + num;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 7;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {

                int num = 7;

                int n = 10 * num + num;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 8;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {

                int num = 8;

                int n = 10 * num + num;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            clickedtimes++;
            //string s = "";
            int c = 0;
            MessageBox.Show("no of times clicked is" + clickedtimes);
            if (clickedtimes == 1)
            {
                int n = 9;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                    if (c == 2)
                        MessageBox.Show("prime no." + n);
                    else
                        MessageBox.Show("not prime " + n);
                }
            }
            if (clickedtimes >= 2)
            {

                int num = 9;

                int n = 10 * num + num;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        c = c + 1;
                    }
                }
                if (c == 2)
                    MessageBox.Show("prime no" + n);
                else
                    MessageBox.Show("not prime" + n);
            }
        }
    }
}


    
