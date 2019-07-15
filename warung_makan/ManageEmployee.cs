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
    public partial class ManageEmployee : Form
    {
        SqlCommand cmd;
        Config con = new Config();
        //SqlCommand cmd;
        SqlDataAdapter adapter;
        string id;
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tampil("");
            b_insert.Enabled = false;
        }
        private void tampil(string cari)
        {
            if (t_cari.TextLength == 0)
            {
                cmd = new SqlCommand("SELECT * FROM tb_employee",con.buka());
            }
            else
            {
                cmd = new SqlCommand("SELECT * FROM tb_employee where Name like '%"+cari+ "%'or Email like '%" + cari + "%'or Position like '%" + cari + "%' or Hp like '%" + cari + "%' ", con.buka());
            }
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void t_cari_TextChanged(object sender, EventArgs e)
        {
            tampil(t_cari.Text);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow dr = dataGridView1.SelectedRows[0];
            t_id.Text = dr.Cells[0].Value.ToString();
            t_nama.Text = dr.Cells[1].Value.ToString();
            t_email.Text = dr.Cells[2].Value.ToString();
            t_pass.Text = dr.Cells[3].Value.ToString();
            t_hp.Text = dr.Cells[4].Value.ToString();
            c_pos.Text = dr.Cells[5].Value.ToString();
            b_insert.Enabled = false;
            b_add.Enabled = true;
            t_id.Enabled = false;
        }

        private void b_insert_Click(object sender, EventArgs e)
        {
            b_insert.Enabled = false;
            b_add.Enabled = true;
            con.cud("INSERT INTO tb_employee values('" + t_id.Text + "','" + t_nama.Text + "','" + t_email.Text + "', '" + t_pass.Text + "','" + t_hp.Text + "','" + c_pos.Text + "')","Data Berhasil Ditambahkan");
            tampil("");
            clear();
        }
        private void clear()
        {
            t_id.Clear();
            t_nama.Clear();
            t_pass.Clear();
            t_hp.Clear();
            t_id.Focus();
            t_email.Clear();
        }
        private void b_add_Click(object sender, EventArgs e)
        {
            b_insert.Enabled = true;
            t_id.Enabled = true;
            b_add.Enabled = false;
            clear();
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            con.cud("Update tb_employee set Name ='" + t_nama.Text + "', Email ='" + t_email.Text + "', Password = '" + t_pass.Text + "', Hp='" + t_hp.Text + "',Position ='" + c_pos.Text + "' where Id= '"+t_id.Text+"'", "Data Berhasil Ditambahkan");
            tampil("");
            clear();
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            con.cud("Delete from tb_employee where Id= '" + t_id.Text + "'", "Data Berhasil Ditambahkan");
            tampil("");
            clear();
        }
    }
}
