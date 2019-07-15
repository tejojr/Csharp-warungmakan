using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace warung_makan
{
    public partial class ManageMember : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adapter;
        Config con = new Config();
        public ManageMember()
        {
            InitializeComponent();
        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tampil("");
        }
        public void tampil(string cari)
        {
          if(t_cari.TextLength == 0)
            {
                cmd = new SqlCommand("SELECT * FROM tb_member", con.buka());
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM tb_member where '", con.buka());
            }
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();  
        }
    }
}
