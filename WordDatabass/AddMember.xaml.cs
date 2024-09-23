using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace WordDatabass
{
    /// <summary>
    /// Interaction logic for AddMember.xaml
    /// </summary>
    /// 
    public partial class AddMember : Window
    {

        public AddMember()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabassConnectionString);
            conn.Open();
            combobox();
            AutoID();
        }

        private void btn_openmember(object sender, RoutedEventArgs e)
        {
            member openmember = new member();
            openmember.Show();
            this.Close();
        }

        private void btn_Add(object sender, RoutedEventArgs e)
        {
            AddData();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddData()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabassConnectionString);
            string strconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\\Users\\tamsu\\Desktop\\WordDatabass\\WordDatabass\\Databass.accdb;";
            conn = new OleDbConnection(strconn);
            conn.Open();
            ///////////////////////////////////////////////////////////
            string sgladd = "INSERT INTO member(mem_id, mem_n, mem_name, mem_sername, mem_st_id, mem_class, mem_room, mem_gmail, mem_telephonenumber) " +
                "VALUES(@mem_id, @mem_n, @mem_name, @mem_sername, @mem_st_id, @mem_class, @mem_room, @mem_gmail, @mem_telephonenumber)";
            OleDbCommand cmdadd = new OleDbCommand(sgladd, conn);
            cmdadd.Parameters.Add("@mem_id", OleDbType.VarChar).Value = txt1.Text;
            cmdadd.Parameters.Add("@mem_n", OleDbType.VarChar).Value = combobox1.Text;
            cmdadd.Parameters.Add("@mem_name", OleDbType.VarChar).Value = txt2.Text;
            cmdadd.Parameters.Add("@mem_sername", OleDbType.VarChar).Value = txt3.Text;
            cmdadd.Parameters.Add("@mem_st_id", OleDbType.VarChar).Value = txt4.Text;
            cmdadd.Parameters.Add("@mem_class", OleDbType.VarChar).Value = combobox2.Text;
            cmdadd.Parameters.Add("@mem_room", OleDbType.VarChar).Value = combobox3.Text;
            cmdadd.Parameters.Add("@mem_gmail", OleDbType.VarChar).Value = txt5.Text;
            cmdadd.Parameters.Add("@mem_telephonenumber", OleDbType.VarChar).Value = txt6.Text;

            cmdadd.ExecuteNonQuery();
            MessageBox.Show("Connect true");
            AutoID();
            ClearText();
        }

        /// รันเลขIDอัตโนมัติ ///
       
        private void AutoID()
        {
            int num;    /*เก็บค่ารหัส*/
            int numberID;
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabassConnectionString);
            conn.Open();
            string strSQL = "SELECT mem_id FROM member ORDER BY mem_id DESC"; /*ดึงข้อมมูล*/
            OleDbCommand stcom = new OleDbCommand(strSQL, conn);
            OleDbDataReader dr = stcom.ExecuteReader();

            /////////////////////////////////////////////////////////
            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    num = Convert.ToInt32(dr["mem_id"]);
                    numberID = num + 1;

                }
                else
                {
                    numberID = 1;

                }
                txt1.Text = numberID.ToString("#000");

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void combobox()
        {
            combobox1.Items.Add("นาย");
            combobox1.Items.Add("นาง");
            combobox1.Items.Add("นางสาว");
            combobox1.Items.Add("เด็กชาย");
            combobox1.Items.Add("เด็กหญิง");

            combobox2.Items.Add("มัธยมศึกษาปีที่1");
            combobox2.Items.Add("มัธยมศึกษาปีที่2");
            combobox2.Items.Add("มัธยมศึกษาปีที่3");
            combobox2.Items.Add("มัธยมศึกษาปีที่4");
            combobox2.Items.Add("มัธยมศึกษาปีที่5");
            combobox2.Items.Add("มัธยมศึกษาปีที่6");
            combobox2.Items.Add("ประกาศนียบัตรวิชาชีพปีที่1");
            combobox2.Items.Add("ประกาศนียบัตรวิชาชีพปีที่2");
            combobox2.Items.Add("ประกาศนียบัตรวิชาชีพปีที่3");

            combobox3.Items.Add("1");
            combobox3.Items.Add("2");
            combobox3.Items.Add("3");
        }

        private void ClearText()
        {
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";

            combobox1.Text = "";
            combobox2.Text = "";
            combobox3.Text = "";

            txt2.Focus();
        }
    }
}
