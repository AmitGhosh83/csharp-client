using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2_PracticeBInding
{
    /// <summary>
    /// Interaction logic for ComboWindow.xaml
    /// </summary>
    public partial class ComboWindow : Window
    {
        public ComboWindow()
        {
            InitializeComponent();
            var sample = new SampleContext();
            sample.User.Load();
            var users = sample.User.Local.ToObservableCollection();
            uxListBox.ItemsSource = users;
        }


        private void uxListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            uxGrid.DataContext = e.AddedItems[0];
        }
    }
}
