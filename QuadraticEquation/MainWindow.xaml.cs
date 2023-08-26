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

namespace QuadraticEquation
{
    public partial class MainWindow : Window
    {
        private double a;
        private double b;
        private double c;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButtonClick(object sender, RoutedEventArgs e)
        {
            if (AValueField == null ||
                BValueField == null ||
                CValueField == null)
            {
                AnswerField.Text = "Specify a & b & c values";
                return;
            }

            try
            {
                a = Convert.ToDouble(AValueField.Text);
                b = Convert.ToDouble(BValueField.Text);
                c = Convert.ToDouble(CValueField.Text);
            }
            catch
            {
                AnswerField.Text = "Specify a & b & c values as doubles";
                return;
            }

            double delta = (b * b) - 4 * (a) * (c);
            if (delta < 0)
            {
                AnswerField.Text = "No real roots.";
                return;
            }

            double q = -(b * b) + Math.Sqrt(delta);
            double p = -(b * b) - Math.Sqrt(delta);

            AnswerField.Text = $"{a}x^2 + ({b})x + ({c}) = {q} & {p}";
        }

        private void ResetButtonClick(object sender, RoutedEventArgs e)
        {
            AValueField.Text = BValueField.Text = CValueField.Text = AnswerField.Text = "";
        }
    }
}
