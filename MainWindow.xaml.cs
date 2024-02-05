using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace solodkaya_lab2
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
        private void Rational_Checked(object sender, RoutedEventArgs e)
        {
            Rational rational1 = new Rational() { A = double.Parse(FirstRational.Text), B = double.Parse(SecondRational.Text) };
            Rational rational2 = new Rational() { A = double.Parse(FirstComplex.Text), B = double.Parse(SecondComplex.Text) };
            Res.Text = rational1.Add(rational2).ToString() + '\n' +
                        rational1.Sub(rational2).ToString() + "\n" +
                        rational1.Mul(rational2).ToString() + "\n" +
                        rational1.Div(rational2).ToString() + "\n" +
                        rational1.Equals(rational2).ToString() + "\n" +
                        rational1.Greate(rational2).ToString() + "\n" +
                        rational1.Less(rational2).ToString();
        }

        private void Comlex_Checked(object sender, RoutedEventArgs e)
        {
            Complex rational1 = new Complex() { A = double.Parse(FirstRational.Text), B = double.Parse(SecondRational.Text) };
            Complex rational2 = new Complex() { A = double.Parse(FirstComplex.Text), B = double.Parse(SecondComplex.Text) };
            Res.Text = rational1.Add(rational2).ToString() + '\n' +
                        rational1.Sub(rational2).ToString() + "\n" +
                        rational1.Mul(rational2).ToString() + "\n" +
                        rational1.Div(rational2).ToString() + "\n" +
                        rational1.Equals(rational2).ToString() + "\n" +
                        rational1.Equ(rational2).ToString() + "\n" +
                        rational1.Conj(rational2).ToString();
        }
    }
}