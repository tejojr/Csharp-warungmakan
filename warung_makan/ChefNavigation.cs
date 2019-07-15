using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warung_makan
{
    public partial class ChefNavigation : Form
    {
        public ChefNavigation()
        {
            InitializeComponent();
        }

        private void ChefNavigation_Load(object sender, EventArgs e)
        {
            string nama = Login.getNama();
            t_nama.Text = nama;
        }
    }
}
