using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
    /// Interaction logic for member.xaml
    /// </summary>
    public partial class member : Window
    {
        UpdataMember openUpdatedatamember = new UpdataMember();
        OleDbDataReader rd;
        OleDbCommand _cmd;

        public member()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            update();
            openUpdatedatamember.Show();
            this.Close();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Delete();
        }
        
        public void LoadData()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Databass.accdb;");
            conn.Open();

            string strSQL = @"SELECT mem_id,mem_name,mem_st_id, mem_class,mem_gmail,mem_telephonenumber FROM member ORDER BY mem_id,mem_name,mem_st_id,mem_class,mem_gmail,mem_telephonenumber DESC"; /*ดึงข้อมมูล*/
            _cmd = new OleDbCommand(strSQL, conn);
            _cmd.CommandText = strSQL;
            _cmd.Connection = conn;

            rd = _cmd.ExecuteReader();

            datashow.ItemsSource = rd;

            datashow.Columns[0].Header = "ลำดับ";
            datashow.Columns[1].Header = "ชื่อ-นามสกุล";
            datashow.Columns[2].Header = "รหัสนักเรียน";
            datashow.Columns[3].Header = "ระดับชั้น";
            datashow.Columns[4].Header = "Email";
            datashow.Columns[5].Header = "เบอร์โทร";

        }

        private void Delete()
        {

            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\\Users\\tamsu\\Desktop\\WordDatabass\\WordDatabass\\Databass.accdb;");
            conn.Open();

            string txt = @"DELETE From member WHERE mem_st_id='" + txt_search.Text + "'";
            OleDbCommand cmd = new OleDbCommand(txt, conn);
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void update()
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabassConnectionString);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM member WHERE mem_st_id='" + txt_search.Text + "'";
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                openUpdatedatamember.txt1.Text = Convert.ToInt32(reader["mem_id"]).ToString("#000");
                openUpdatedatamember.txt2.Text = reader["mem_name"].ToString();
                openUpdatedatamember.txt3.Text = reader["mem_sername"].ToString();
                openUpdatedatamember.txt5.Text = reader["mem_gmail"].ToString();
                openUpdatedatamember.txt4.Text = reader["mem_st_id"].ToString();
                openUpdatedatamember.txt6.Text = reader["mem_telephonenumber"].ToString();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabassConnectionString);
            conn.Open();
            LoadData();
        }
    }
}
