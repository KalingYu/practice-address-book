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

namespace Tonxinlu
{
    /// <summary>
    /// SearchPage.xaml 的交互逻辑
    /// </summary>
    public partial class SearchPage : Page
    {
        public SearchPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SearchContact();
        }

        private void SearchContact()
        {
            string name =idBox.Text.ToString();

            try
            {
                MySqlConnection conn = new MySqlConnection(CommonValue.MYSQL_CONN);
                conn.Open();
                string cmd = "select * from list where name='" + name + "'";
                MySqlCommand myCmd = new MySqlCommand(cmd, conn);
                MySqlDataReader reader = myCmd.ExecuteReader();
                reader.Read();
                resultID.Text = "编号：" + reader["id"].ToString();
                resultName.Text = "姓名： " + reader["name"].ToString();
                resultSex.Text = "性别："  + reader["sex"].ToString();
                resultPhone.Text = "电话：" + reader["phone"].ToString();
                resultEmail.Text = "邮箱： " + reader["email"].ToString();
                resultAddress.Text = "地址： " + reader["address"].ToString();

                idBox.Text = "";
                conn.Close();
            }

            catch (Exception e)
            {
                String msg = e.Message;
                resultBox.Text = "查询失败" + msg;
            }
        }
    }
}
