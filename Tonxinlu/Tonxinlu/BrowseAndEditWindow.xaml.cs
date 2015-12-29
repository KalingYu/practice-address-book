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
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace Tonxinlu
{
    /// <summary>
    /// BrowseAndEditWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BrowseAndEditWindow : Window
    {
        public BrowseAndEditWindow()
        {
            InitializeComponent();
            ShowAddress();
        }

        private void ShowAddress()
        {
            try
            {
                //获取表格
                DataTable data = new DataTable("addressbook");
                data.Columns.Add(new DataColumn("name", typeof(string)));
                data.Columns.Add(new DataColumn("sex", typeof(string)));
                data.Columns.Add(new DataColumn("phone", typeof(string)));
                data.Columns.Add(new DataColumn("email", typeof(string)));
                data.Columns.Add(new DataColumn("address", typeof(string)));

                MySqlConnection conn = new MySqlConnection(CommonValue.MYSQL_CONN);
                conn.Open();
                string cmd = "select * from list";
                MySqlCommand myCmd = new MySqlCommand(cmd, conn);
                MySqlDataAdapter mda = new MySqlDataAdapter(cmd, conn);
                MySqlDataReader reader = myCmd.ExecuteReader();
                ObservableCollection<Contacts> memberData = new ObservableCollection<Contacts>();
                while (reader.Read())
                {

                    string name = reader["name"].ToString();
                    string phone = reader["phone"].ToString();
                    string sex = reader["sex"].ToString();
                    string email = reader["email"].ToString();
                    string address = reader["address"].ToString();


                    memberData.Add(new Contacts()
                    {
                        name = name,
                        phone = phone,
                        sex = sex,
                        email = email,
                        address = address
                    });

                }
                dataGrid.DataContext = memberData;
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("联系人获取失败:" + e.Message);
            }

            
        }

        public  class Contacts
        {
            public string name { get; set; }
            public string sex { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string address { get; set; }
        }
    }
}
