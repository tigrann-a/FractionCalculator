using FractionLib;
using System.Windows;

namespace FractionCalculator_20260318;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnClear_Click(object sender, RoutedEventArgs e)
    {
        frNum1.Text = "0";
        frDen1.Text = "1";

        frNum2.Text = "0";
        frDen2.Text = "1";

        ans.Content = "ans";
    }

    private void btnCalculate_Click(object sender, RoutedEventArgs e)
    {
        Fraction fraction1 = new Fraction(Int32.Parse(frNum1.Text), Int32.Parse(frDen1.Text));
        Fraction fraction2 = new Fraction(Int32.Parse(frNum2.Text), Int32.Parse(frDen2.Text));

        switch(opr.Text)
        {
            case "+": ans.Content = fraction1 + fraction2; break;
            case "-": ans.Content = fraction1 - fraction2; break;
            case "*": ans.Content = fraction1 * fraction2; break;
            case "/": ans.Content = fraction1 / fraction2; break;
        }


        //MessageBox.Show(opr.Text);
    }
}