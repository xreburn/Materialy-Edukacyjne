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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click (object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 = (number1 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            } else
            {
                number2 = (number2 * 10) + 1;
                txtDisplay.Text = number1.ToString();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txtDisplay.Text = number1.ToString();
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txtDisplay.Text = number1.ToString();
            }

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txtDisplay.Text = number1.ToString();
            }

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txtDisplay.Text = number1.ToString();
            }

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txtDisplay.Text = number1.ToString();
            }

        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                txtDisplay.Text = number1.ToString();
            }

        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txtDisplay.Text = number1.ToString();
            }

        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txtDisplay.Text = number1.ToString();
            }

        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                txtDisplay.Text = number1.ToString();
            }

        }

        public void btnPlus_Click (object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        public void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        public void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";

        }
        public void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }
        public void btnDot_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }
        public void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
                case "%":
                    txtDisplay.Text = (number1 % number2).ToString();
                    break;
            }
        }
        public void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }
        public void btnPercent_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            txtDisplay.Text = "0";
        }
        public void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }
        public void btnSq_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

    }
}
