using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
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

namespace Quadratic_Equation_Calculator
{

    public partial class MainWindow : Window
    {

        ValueManager value = new ValueManager();

        public MainWindow()
        {
            InitializeComponent();
        }

        //Run program

        private void Run(object sender, RoutedEventArgs e)
        {

            //Class call

            var math = new Equation();

            //Variables

            string aInput = valueInputA.Text;
            string bInput = valueInputB.Text;
            string cInput = valueInputC.Text;

            double a;
            double b;
            double c;

            if (value.NullCheck(aInput) || aInput == "0")
            {

                MessageBox.Show("Variable 'A' has a null value. Can't operate");

                return;
            }
            else
            {
                a = Convert.ToDouble(aInput);
            }

            if (value.NullCheck(bInput))
            {
                b = 0;
            } 
            else
            {
                b = Convert.ToDouble(bInput);
            }

            if (value.NullCheck(cInput))
            {
                c = 0;
            }
            else
            {
                c = Convert.ToDouble(cInput);
            }

            //Math

            double[] results = math.QuadraticEquation(a, b, c);

            string result1 = results[0].ToString();
            string result2 = results[1].ToString();

            if (results[4] == 1)
            {
                MessageBox.Show($"Error: the square root of '{results[2]} - {results[3]}' returns an imaginary number.");
                result1 = "Imaginary number";
                result2 = result1;
            }

            finalData.Text = $"x': {result1}\n" +
                             $"x'': {result2}\n" + 
                             $"A: {a}\n" +
                             $"B: {b}\n" +
                             $"C: {c}";
        }
    }
}