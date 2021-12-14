using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
namespace DesktopApp
{
    /// <summary>
    /// WpfUserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class WpfUserControl1 : UserControl
    {
        private ObservableCollection<string> Items { get; }
        public WpfUserControl1()
        {
            InitializeComponent();
            Items = new();
            listbox.ItemsSource = Items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Items.Add(DateTime.Now.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Items.Clear();
        }
    }
}
