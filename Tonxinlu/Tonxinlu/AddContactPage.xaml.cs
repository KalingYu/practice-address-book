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


namespace Tonxinlu
{
    /// <summary>
    /// AddContactPage.xaml 的交互逻辑
    /// </summary>
    public partial class AddContactPage : Page
    {

        private string name;
        private string phone;
        private string sex;
        private string email;
        private string address;

        public AddContactPage()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AddContact();
        }

        private void AddContact()
        {
            name = nameBox.Text.ToString();
            sex = sexBox.Text.ToString();
            phone = phoneBox.Text.ToString();
            email = emailBox.Text.ToString();
            address = addressBox.Text.ToString();

            try
            {

                MySqlConnection conn = new MySqlConnection(CommonValue.MYSQL_CONN);
                conn.Open();
                String cmd = "insert into list( name, sex, phone, email, address) values('" + name + "','" + sex + "','" + phone + "','" + email + "','" + address + "')";
                MySqlCommand mycmd = new MySqlCommand(cmd, conn);
                if (mycmd.ExecuteNonQuery() > 0)
                {
                    resultBox.Text = "添加成功!请继续";
                    ClearInput();
                    conn.Close();
                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("对不起，添加失败！" + e.Message);
            }
        }

        private void ClearInput()
        {
            nameBox.Text = "";
            sexBox.Text = "";
            phoneBox.Text = "";
            emailBox.Text = "";
            addressBox.Text = "";
        }
    }
}
