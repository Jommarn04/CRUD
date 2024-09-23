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
    /// Interaction logic for UpdataMember.xaml
    /// </summary>
    public partial class UpdataMember : Window
    {
        public UpdataMember()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.DatabassConnectionString);
            conn.Open();
        }

        private void btn_openmember(object sender, RoutedEventArgs e)
        {
            member openmember = new member();
            openmember.Show();
            this.Close();
            
        }

        private void btn_Add(object sender, RoutedEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=A:\\Users\\tamsu\\Desktop\\WordDatabass\\WordDatabass\\Databass.accdb;");
            conn.Open();

            string sgladd = @"UPDATE  member SET mem_id='" + txt1.Text + "', mem_n='" + combobox1.Text + "', mem_name='" + txt2.Text + "', mem_sername='" + txt3.Text + "', mem_st_id='" + txt5.Text + "', mem_class='" + combobox2.Text + "', mem_room='" + combobox3.Text + "', mem_gmail='" + txt4.Text + "', mem_telephonenumber='" + txt6.Text + "'";
            OleDbCommand cmdadd = new OleDbCommand(sgladd, conn);

            cmdadd.ExecuteNonQuery();
            MessageBox.Show("Connect true");
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
