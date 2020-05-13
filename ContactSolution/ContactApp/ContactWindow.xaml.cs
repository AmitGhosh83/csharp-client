using ContactApp.Models;
using System;
using System.Windows;

namespace ContactApp
{
    public partial class ContactWindow : Window
    {
        public ContactModel Contact { get; set; }
        public ContactWindow()
        {
            InitializeComponent();
            // Don't show this window in the task bar
            ShowInTaskbar = false;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Contact != null)
            {
                //var value = (Contact.PhoneType == "Home" ? uxHome.IsChecked : uxMobile.IsChecked);

                uxSubmit.Content = "Update";
            }
            else
            {
                Contact = new ContactModel();
                Contact.CreatedDate = DateTime.Now;
            }

                uxGrid.DataContext = Contact;
        }
        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (uxHome.IsChecked.Value)
            {
                Contact.PhoneType = "Home";
            }
            else
            {
                Contact.PhoneType = "Mobile";
            }
            // This is the return value of ShowDialog( ) below
            DialogResult = true;
            Close();
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            // This is the return value of ShowDialog( ) below
            DialogResult = false;
            Close();
        }


    }
}
