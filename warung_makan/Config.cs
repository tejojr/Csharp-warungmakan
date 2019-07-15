using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace warung_makan
{
    class Config
    {
        string strkoneksi = null;
        SqlConnection cnn;
        SqlCommand cmd;
        public SqlConnection buka()
        {
            strkoneksi = "Server=DESKTOP-A45DNAG\\SQLEXPRESS; Database=rumah_makan; Integrated Security=SSPI;";
            cnn = new SqlConnection(strkoneksi);
            try
            {
                cnn.Open();
                //MessageBox.Show("sukses");
            }
            catch (Exception e)
            {
                MessageBox.Show("Gagal " + e);

            }
            return cnn;
        }
        public SqlConnection tutup()
        {
            cnn.Close();
            return cnn;

        }
        public int cud( string query, string info)
        {
            try
            {
                cmd = new SqlCommand(query,buka());
                cmd.ExecuteNonQuery();
                MessageBox.Show(info);
            }
            catch (Exception e)
            {
                MessageBox.Show("Gagal" + e);
                
            }
            finally
            {
                tutup();
            }
            return 1;
        }
    }
}
