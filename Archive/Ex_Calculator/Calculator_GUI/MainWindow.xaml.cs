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

namespace Calculator_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        
        public MainWindow()
        {
            InitializeComponent();
            value1.Text="";
            value2.Text="";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserInputText.Text = UserInputText.Text + "=";         
        }

        private void UserInputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (char item in UserInputText.Text) 
            {
                if (item == '+' || item == '-' || item == '/' || item == '*' || item == '=')
                {
                    string data = UserInputText.Text;
                    string num = data.Remove(data.Length - 1);
                    char opp = data[data.Length - 1];

                    //add exception if letters are input

                    if (opperator.Text == "")
                    {
                        opperator.Text = char.ToString(opp);
                    }
                    else
                    {
                        op.Text = char.ToString(opp);
                    }
                    

                    if (num != "" & value1.Text == "")
                    {
                        value1.Text = num;
                    }
                    else if (num != "")
                    {
                        value2.Text = num;
                    }
                    UserInputText.Text = "";
                    
                }

                if (value2.Text != "")
                {
                    double num1 = Convert.ToDouble(value1.Text);
                    double num2 = Convert.ToDouble(value2.Text);
                    char opps1 = opperator.Text[0];

                    switch (opps1)
                    {
                        case '+':
                            double result = CalculatorLib.Class1.Addition(num1, num2);
                            ResultsTextBox.Text = $"{result}";
                            value1.Text = $"{result}";
                            value2.Text = "";
                            opperator.Text = op.Text;
                            op.Text = "";
                            break;
                        case '-':
                            double result1 = CalculatorLib.Class1.Subtraction(num1, num2);
                            ResultsTextBox.Text = $"{result1}";
                            value1.Text = $"{result1}";
                            value2.Text = "";
                            opperator.Text = op.Text;
                            op.Text = "";
                            break;
                        case '*':
                            double result2 = CalculatorLib.Class1.Multiplication(num1, num2);
                            ResultsTextBox.Text = $"{result2}";
                            value1.Text = $"{result2}";
                            value2.Text = "";
                            opperator.Text = op.Text;
                            op.Text = "";
                            break;
                        case '/':
                            double result3 = CalculatorLib.Class1.Division(num1, num2);
                            ResultsTextBox.Text = $"{result3}";
                            value1.Text = $"{result3}";
                            value2.Text = "";
                            opperator.Text = op.Text;
                            op.Text = "";
                            break;
                        default:
                            break;
                    }

                    if (opperator.Text != "")
                    {
                        if (opperator.Text[0] == '=')
                        {
                            value1.Text = "";
                            value2.Text = "";
                            opperator.Text = "";
                            op.Text = "";
                        }
                    }
                }
            }       
        }       
        


        private void ResultsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void value1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void opperator_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

         private void value2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void op_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
