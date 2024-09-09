using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;

namespace ProjectedRaisesGUI
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
                double result = value1 * 1.04f;
                ResultLabel.Text = $"Next Year's Salary (4% increase): {result:C}";
            }
            else
            {
                ResultLabel.Text = "Please enter valid numbers.";
            }
        }
    }
}
