using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_Project
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

        // Restrict input to numeric characters only
        private void Textbox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Allow only digits (0-9)
            e.Handled = !Regex.IsMatch(e.Text, @"^[0-9]+$");
        }

        // Handle the "Send Data" button click
        private void SendDataButton_Click(object sender, RoutedEventArgs e)
        {
            string inputData = Textbox1.Text;

            // Check if the input is valid (exactly 16 digits)
            if (inputData.Length == 16 && long.TryParse(inputData, out _))
            {
                // Simulate sending data to Hercules and receiving the response
                string responseFromHercules = "Data Sent: " + inputData;

                // Display the response in Textbox2 (for now, we're just simulating)
                Textbox2.Text = responseFromHercules;
            }
            else
            {
                MessageBox.Show("Please enter a valid 16-digit number.");
            }
        }

        // Handle the "Receive Data" button click
        private void ReceiveDataButton_Click(object sender, RoutedEventArgs e)
        {
            // Simulate receiving data from Hercules (for now, returning a test string)
            string receivedData = "Received Data from Hercules";

            // Display the received data in Textbox2
            Textbox2.Text = receivedData;



        }
    }
}
