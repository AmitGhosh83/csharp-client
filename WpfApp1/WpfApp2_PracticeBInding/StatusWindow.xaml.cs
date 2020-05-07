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
    /// Interaction logic for StatusWindow.xaml
    /// </summary>
    public partial class StatusWindow : Window
    {
        public StatusWindow()
        {
            InitializeComponent();
            uxTextEditor_SelectionChanged(null, null);
        }

        private void uxTextEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = uxTextEditor.GetLineIndexFromCharacterIndex(uxTextEditor.CaretIndex);
            int col = uxTextEditor.CaretIndex - uxTextEditor.GetCharacterIndexFromLineIndex(row);
            uxStatus.Text = "Line " + (row + 1) + ", Char " + (col + 1);
            if(uxTextEditor.CaretIndex==0)
            {
                row = 0;
                col = 0;
            }
            uxProgressBar.Value = uxTextEditor.Text.Length;
            int percentage = 100 * uxTextEditor.Text.Length / uxTextEditor.MaxLength;
            uxComplete.Text = string.Format("{0}%", percentage);
        }
    }
}
