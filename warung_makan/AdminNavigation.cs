﻿using System;
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
    public partial class AdminNavigation : Form
    {
        public AdminNavigation()
        {
            InitializeComponent();
        }

        private void AdminNavigation_Load(object sender, EventArgs e)
        {
            string nama = Login.getNama();
            t_nama.Text = nama;
        }
    }
}
