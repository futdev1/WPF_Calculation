using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.ComponentModel;
using Calculation.Repository;

namespace Calculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string defaultString = "0";
        string numberOneBuffer;
        string numberTwoBuffer;
        Calc c;
        public MainWindow()
        {
            InitializeComponent();

            c = new Calc();
            TextBox1.Text = defaultString;

            numberOneBuffer = "";
            numberTwoBuffer = "";
        }


        private void Btn0(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "0";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn1(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "1";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn2(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "2";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn3(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "3";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn4(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "4";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn5(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "5";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn6(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "6";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn7(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "7";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn8(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "8";
            TextBox1.Text = numberOneBuffer;
        }
        private void Btn9(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "9";
            TextBox1.Text = numberOneBuffer;
        }


        private void Clear_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer = "";
            TextBox1.Text = defaultString;
        }

        private void Delete_Btn(object sender, RoutedEventArgs e)
        {
            
            if (TextBox1.Text.Length > 0)
            {
                numberOneBuffer = TextBox1.Text.Substring(0, (TextBox1.Text.Length - 1));
                TextBox1.Text = numberOneBuffer;
            }
        }

        private void Nuqta_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += ".";
            TextBox1.Text = numberOneBuffer;
        }

        private void Present_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "%";
            TextBox1.Text = numberOneBuffer;
        }

        private void Plus_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "+";
            TextBox1.Text = numberOneBuffer;
        }

        private void Minus_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "-";
            TextBox1.Text = numberOneBuffer;
        }

        private void Daraja_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "°";
            TextBox1.Text = numberOneBuffer;
        }

        private void Enter_Btn(object sender, RoutedEventArgs e)
        {
            Double res = Eval(TextBox1.Text);
            numberOneBuffer = "";
            TextBox1.Text = res.ToString();
        }

        private void Kopaytirish_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "*";
            TextBox1.Text = numberOneBuffer;
        }

        private void Bolish_Btn(object sender, RoutedEventArgs e)
        {
            numberOneBuffer += "/";
            TextBox1.Text = numberOneBuffer;
        }
        static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }


    }
}
