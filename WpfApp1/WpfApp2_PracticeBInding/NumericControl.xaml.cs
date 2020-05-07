using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2_PracticeBInding
{
    /// <summary>
    /// Interaction logic for NumericControl.xaml
    /// </summary>
    public partial class NumericControl : UserControl
    {
        public NumericControl()
        {
            InitializeComponent();
        }
        public int Value { get; private set; }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);        }
        private bool IsValidNumber(string text)
        {
            foreach (var ch in text)
            {
                if(!char.IsDigit(ch))
                {
                    return false;
                }
            }
            int result;

            return true;
        }
    }
}
