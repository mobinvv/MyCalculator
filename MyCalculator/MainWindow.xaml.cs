using System.Windows;
using System.Windows.Controls;


namespace CalculatorApp
{
    public partial class MainWindow : Window
    {

        double firstNumber;
        string operation;


        public MainWindow()
        {
            InitializeComponent();
        }



        // numbers` buttons
        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            txtDisplay.Text += button.Content.ToString();
        }



        // + - / *
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;


            firstNumber = double.Parse(txtDisplay.Text);

            operation = button.Content.ToString();


            txtDisplay.Text = "";
        }



        // =
        private void Equal_Click(object sender, RoutedEventArgs e)
        {

            double secondNumber =
                double.Parse(txtDisplay.Text);


            double result = 0;


            switch (operation)
            {

                case "+":
                    result = firstNumber + secondNumber;
                    break;


                case "-":
                    result = firstNumber - secondNumber;
                    break;


                case "*":
                    result = firstNumber * secondNumber;
                    break;


                case "/":

                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;

                    else
                    {
                        MessageBox.Show("Cannot divide by zero!");
                        return;
                    }

                    break;
            }


            txtDisplay.Text = result.ToString();

        }



        // Clear button
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "";
            firstNumber = 0;
            operation = "";
        }


    }
}