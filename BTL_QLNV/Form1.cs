using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNV
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=LAPTOP-3CLN13P2;Initial Catalog=QLCongTy;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();

        void loaddata1()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from ThongTinNhanVien";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgv1.DataSource = table1;
        }

        void loaddata2()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from ThongTinPhongBan";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgv2.DataSource = table2;
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata1();
            loaddata2();
        }
    }
}
