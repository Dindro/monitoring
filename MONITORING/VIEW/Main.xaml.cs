using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MONITORING
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void treeView_PreviewMouseRightButtonDown(object sender, RoutedEventArgs e)
        {
            ItemsControl r = sender as ItemsControl;
            r.Focus();
        }

        private void Rename_Click(object sender, RoutedEventArgs e)
        {
            //object Sel = treeView.SelectedItem;
            //int i = treeView.Items.IndexOf(Sel);
            //TextBox text = new TextBox();
            //text.Width = 100;
            //text.Height = 20;
            //text.Text = "HELLO";
            //treeView.Items[i] = text;
        }

        private void etb_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if((sender as TextBox).Visibility == Visibility.Visible)
            {
                (sender as TextBox).Focus();
                (sender as TextBox).SelectAll();
            }
        }

        private void etb_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
