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
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace Tonxinlu
{
    /// <summary>
    /// BrowseAndEditPage.xaml 的交互逻辑
    /// </summary>
    public partial class BrowseAndEditPage : Page
    {

        private List<Contacts> contactsList;
        public BrowseAndEditPage()
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
                data.Columns.Add(new DataColumn("id", typeof(string)));
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
                    string id = reader["id"].ToString(); ;


                    memberData.Add(new Contacts()
                    {
                        id = int.Parse(id),
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

        public class Contacts
        {
            public int id { get; set; }
            public string name { get; set; }
            public string sex { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string address { get; set; }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string choice = btn.Content.ToString();
            switch (choice)
            {
                case "更新通讯录":
                    UpdateContact();
                    break;
                case "确认删除":
                    DeleteContact();
                    break;
            }

           
        }

        private void UpdateContact()
        {

            contactsList = new List<Contacts>();

            try
            {

                MySqlConnection conn = new MySqlConnection(CommonValue.MYSQL_CONN);
                conn.Open();

                foreach (Contacts contactTemp in dataGrid.Items)
                {
                    String cmd = "update list set name='" + contactTemp.name + "',sex='" + contactTemp.sex + "',phone='" + contactTemp.phone + "',email='" + contactTemp.email + "',address='" + contactTemp.address + "'where id='" + contactTemp.id + "'";
                    MySqlCommand mycmd = new MySqlCommand(cmd, conn);
                    if (mycmd.ExecuteNonQuery() > 0)
                    {
                        resultBox.Text = "通讯录修改成功,继续修改或退出";
                        conn.Close();
                        ShowAddress();

                    }
                }     
               
            }
            catch (Exception e)
            {
                resultBox.Text = "通讯录更新失败" + e.Message;
            }

            
        }

        private void DeleteContact()
        {
            int id = int.Parse(deleteBox.Text.ToString());
            try
            {
                MySqlConnection conn = new MySqlConnection(CommonValue.MYSQL_CONN);
                conn.Open();
                String cmd = "delete from list where id='" +id + "'";
                MySqlCommand myCmd = new MySqlCommand(cmd, conn);
                if (myCmd.ExecuteNonQuery() > 0)
                {
                    resultBox.Text = "删除联系人成功";
                    ShowAddress();
                    conn.Close();

                }

            }
            catch (Exception e)
            {
                resultBox.Text = "删除联系人失败" + e.Message;
            }
        }
    }
}
