using Homework3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Homework3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            var users = new List<User>();
            users.Add(new User { Name = "Dave", Password = "1DavePwd" });
            users.Add(new User { Name = "Steve", Password = "2StevePwd" });
            users.Add(new User { Name = "Lisa", Password = "3LisaPwd" });
            //SortByPassword(users);
            uxList.ItemsSource = users;
            

        }
        GridViewColumnHeader _lastHeaderClicked = null;
        ListSortDirection _lastDirection = ListSortDirection.Ascending;

        //private void SortByPassword( List<User> userList)
        //{
        //    CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(userList);
        //    view.SortDescriptions.Add(new SortDescription("Password", ListSortDirection.Descending));
        //}

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader headerClicked = e.OriginalSource as GridViewColumnHeader;
            ListSortDirection direction;

            if (headerClicked != null)
            {

                if (headerClicked != _lastHeaderClicked)
                {
                    direction = ListSortDirection.Ascending;
                }
                else
                {
                    if (_lastDirection == ListSortDirection.Ascending)
                    {
                        direction = ListSortDirection.Descending;
                    }
                    else
                    {
                        direction = ListSortDirection.Ascending;
                    }
                }

                string header = headerClicked.Tag.ToString();
                Short(header, direction);

                _lastHeaderClicked = headerClicked;
                _lastDirection = direction;

            }
        }
        private void Short(string sortBy, ListSortDirection direction)
        {
            CollectionView dataView =
              (CollectionView)CollectionViewSource.GetDefaultView(uxList.ItemsSource);

            dataView.SortDescriptions.Clear();
            dataView.SortDescriptions.Add(new SortDescription(sortBy, direction));
            dataView.Refresh();
        }

    }
}
