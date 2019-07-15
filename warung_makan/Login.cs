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
    public partial class Login : Form
    {
        Config con = new Config();
        SqlCommand cmd;
        SqlDataReader reader;
        string id, pos;
        static string nama;
        public Login()
        {
            InitializeComponent();
        }
        public void clear()
        {
            t_uname.Clear();
            t_pass.Clear();
            t_uname.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            clear();
        }
        public static string getNama()
        {
            return nama;

        }
        private void b_login_Click(object sender, EventArgs e)
        {
            if (t_uname.TextLength==0 || t_pass.TextLength==0 || !t_uname.Text.Contains('@') || !t_uname.Text.Contains('.') )
            {
                MessageBox.Show("Mohon Isi data dengan benar!","Informasi");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("SELECT * FROM tb_employee where Email = '"+t_uname.Text+"' and Password = '"+t_pass.Text+"'",con.buka());
                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id = (string)reader["Id"];
                                nama = (string)reader["Name"];
                                pos = (string)reader["Position"];
                            }
                            if (pos.Equals("cashier"))
                            {
                                MessageBox.Show("Login Berhasil", "status login");
                                new CashierNavigation().Show();
                                this.Hide();
                            } else if (pos.Equals("chef"))
                            {
                                MessageBox.Show("Login Berhasil", "status login");
                                new ChefNavigation().Show();
                                this.Hide();
                            }else if (pos.Equals("admin"))
                            {
                                MessageBox.Show("Login Berhasil", "status login");
                                new AdminNavigation().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Login gagal", "status login");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Gaggal");
                        }
                    }
                }
                catch (Exception E)
                {

                    MessageBox.Show(E.ToString());
                }
                finally
                {
                    con.tutup();
                    clear();
                }
            }
        }
    }
}
