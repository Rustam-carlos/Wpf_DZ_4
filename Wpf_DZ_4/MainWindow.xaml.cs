using System;
using System.Collections.Generic;
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

namespace Wpf_DZ_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        

        private void TabItem2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var items = TabControl1.Items;

            WebBrowser web = new WebBrowser();
            web.Navigate("https://www.google.kz/webhp?hl=ru&sa=X&ved=0ahUKEwinovWr4ZjiAhViposKHeh8AOgQPAgH");

            items.RemoveAt(items.Count - 1);

            items.Add(new TabItem
            {
                Header = new TextBlock { Text = "Google" },
                Content = web
            });

            TabItem item = new TabItem
            {
                Header = new TextBlock { Text = "+" }
            };
            item.PreviewMouseLeftButtonDown += TabItem2_PreviewMouseLeftButtonDown;
            items.Add(item);

            TabControl1.SelectedIndex = items.Count - 2;
        }

        
    }
}
