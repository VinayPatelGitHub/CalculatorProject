using CalculatorLib;
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
using CalculatorLib;

namespace Calculator_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainControlClass MainController;

        public MainWindow()
        {
            InitializeComponent();
            MainController = new MainControlClass();
        }

        private void UserInputText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string[] output = MainController.Store(UserInputText.Text);
            UserInputText.Text = output[0];
            Output.Text = output[1];

        }

        private void Output_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

         /* plan - this is gonna be a typing calculator
          * it will ignore take in letters that define functions, there will be a list of function on the side
          * it will recognice operators and create objects to store values between values*/

        

     


    }
}
