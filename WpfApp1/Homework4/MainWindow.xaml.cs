using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace Homework4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string _usZipRegEx = @"^\d{5}(?:[-\s]\d{4})?$";
        public static string _caZipRegEx = @"^([ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ])\ {0,1}(\d[ABCEGHJKLMNPRSTVWXYZ]\d)$";
        public MainWindow()
        {
            InitializeComponent();
            uxButton.IsEnabled = false;
        }
        private void uxZipcode_TextChanged(object sender, TextChangedEventArgs e)
        {
            uxButton.IsEnabled = ConditionallyEnableSubmitButton();
        }
        private bool ConditionallyEnableSubmitButton()
        {
            return (!string.IsNullOrWhiteSpace(uxZipcode.Text) && ZipcodeValidator(uxZipcode.Text));
        }
        //Validation Logic
        public static bool ZipcodeValidator(string input)
        {
            var validZipCode = true;
            if((!Regex.Match(input, _usZipRegEx).Success)&&(!Regex.Match(input, _caZipRegEx).Success))
            {
                validZipCode = false;
            }
            return validZipCode;
        }
    }
}
