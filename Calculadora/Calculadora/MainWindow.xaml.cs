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

namespace Calculadora
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

        public void Suma()
        {
            var num1 = double.Parse(Num1.Text);
            var num2 = double.Parse(Num2.Text);

            var suma = num1 + num2;
            MessageBox.Show($"la suma es {suma}");
        }
        public void Resta()
        {
            var num1 = double.Parse(Num1.Text);
            var num2 = double.Parse(Num2.Text);

            var suma = num1 - num2;
            MessageBox.Show($"la resta es {suma}");
        }
        public void División()
        {
            var num1 = double.Parse(Num1.Text);
            var num2 = double.Parse(Num2.Text);

            var suma = num1 / num2;
            MessageBox.Show($"la división es {suma}");
        }
        public void Multiplicación()
        {
            var num1 = double.Parse(Num1.Text);
            var num2 = double.Parse(Num2.Text);

            var suma = num1 * num2;
            MessageBox.Show($"la multiplicación es {suma}");
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Suma();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Resta();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Multiplicación();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            División();
        }
    }
}
