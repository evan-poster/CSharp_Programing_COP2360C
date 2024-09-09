using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;

namespace InchesToCentimetersGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCalculateButtonClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TextBox1.Text, out double value1))
            {
                double result = value1 * 2.54f;
                ResultLabel.Text = $"Result: {result:F2} centimeters";
            }
            else
            {
                ResultLabel.Text = "Please enter valid numbers.";
            }
        }

    }
}
