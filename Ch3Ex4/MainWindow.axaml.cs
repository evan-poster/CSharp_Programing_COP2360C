using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Input;

namespace EggsInteractiveGUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCalculateButtonClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TextBox1.Text, out int value1)
                && int.TryParse(TextBox2.Text, out int value2)
                && int.TryParse(TextBox3.Text, out int value3)
                && int.TryParse(TextBox4.Text, out int value4)
                && int.TryParse(TextBox5.Text, out int value5))
            {
                int total = value1 + value2 + value3 + value4 + value5;
                int dozens = total / 12;
                int eggs = total % 12;
                ResultLabel.Text = $"{total} eggs is {dozens} dozen and {eggs} eggs.";
            }
            else
            {
                ResultLabel.Text = "Please enter valid numbers.";
            }
        }
    }
}

