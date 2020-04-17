using System.Windows;
using Microsoft.EntityFrameworkCore;

namespace WpfApp2_PracticeBInding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User _user = new User(); 
        public MainWindow()
        {
            InitializeComponent();
            uxContainer.DataContext = _user;
            var sample = new SampleContext();
            sample.User.Load();
            var users = sample.User.Local.ToObservableCollection();
            uxList.ItemsSource = users;
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);

            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }
    }
}
