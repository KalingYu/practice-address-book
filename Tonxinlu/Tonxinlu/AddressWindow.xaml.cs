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
using System.Windows.Shapes;

namespace Tonxinlu
{
    /// <summary>
    /// AddressWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddressWindow : Window
    {
        public AddressWindow()
        {
            InitializeComponent();
            frame.Source = new Uri("BrowseAndEditPage.xaml", UriKind.Relative);
            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Add.Background = brush;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string choice = btn.Content.ToString();
            switch (choice)
            {
                case "添加联系人":
                    OpenAddContactPage();
                    break;
                case "浏览或编辑":
                    OpenBrowseAndEditPage();
                    break;
                case "搜索联系人":
                    OpenSearchPage();
                    break;
            }


        }

        private void OpenAddContactPage()
        {
            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Add.Background = brush;

            brush = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            btn_Browse.Background = brush;
            btn_Search.Background = brush;
            frame.Source = new Uri("AddContactPage.xaml", UriKind.Relative);
        }

        private void OpenBrowseAndEditPage()
        {

            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Browse.Background = brush;

            brush = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            btn_Add.Background = brush;
            btn_Search.Background = brush;
            frame.Source = new Uri("BrowseAndEditPage.xaml", UriKind.Relative);
        }

        private void OpenSearchPage()
        {

            Brush brush = new SolidColorBrush(Color.FromRgb(7, 136, 209));
            btn_Search.Background = brush;

            brush = new SolidColorBrush(Color.FromRgb(204, 204, 204));
            btn_Browse.Background = brush;
            btn_Add.Background = brush;
            frame.Source = new Uri("SearchPage.xaml", UriKind.Relative);
        }
    }
}
