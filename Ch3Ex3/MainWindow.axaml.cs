using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;

namespace MoveEstimatorGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCalculateButtonClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(hoursTextBox.Text, out double value1) && double.TryParse(milesTextBox.Text, out double value2))
            {
                double result = 200 + (value1 * 150) + (value2 * 2);
                ResultLabel.Text = $"Moving Fee: {result:C}";
            }
            else
            {
                ResultLabel.Text = "Please enter valid numbers.";
            }
        }
    }
}
