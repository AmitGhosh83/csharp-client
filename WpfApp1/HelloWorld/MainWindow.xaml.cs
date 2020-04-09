using System.Windows;
using System.Windows.Controls;

namespace HelloWorld
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled = false;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(string.Format("Submitting password", uxPassword.Text));
        }

        private void uxUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConditionallyEnableSubmitButton();
        }

        private void uxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            ConditionallyEnableSubmitButton();
        }
        private void ConditionallyEnableSubmitButton()
        {
            uxSubmit.IsEnabled = (!string.IsNullOrWhiteSpace(uxName.Text) &&
                       !string.IsNullOrWhiteSpace(uxPassword.Text));
        }
    }
}
