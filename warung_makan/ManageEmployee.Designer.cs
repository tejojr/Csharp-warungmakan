namespace warung_makan
{
    partial class ManageEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_hp = new System.Windows.Forms.TextBox();
            this.c_pos = new System.Windows.Forms.ComboBox();
            this.b_insert = new System.Windows.Forms.Button();
            this.b_update = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.b_add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 93);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 207);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(687, 93);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(131, 20);
            this.t_cari.TabIndex = 3;
            this.t_cari.TextChanged += new System.EventHandler(this.t_cari_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Employee Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Handphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Position";
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(334, 350);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(177, 20);
            this.t_id.TabIndex = 10;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(334, 384);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(177, 20);
            this.t_nama.TabIndex = 11;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(334, 416);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(177, 20);
            this.t_email.TabIndex = 12;
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(334, 475);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(177, 20);
            this.t_hp.TabIndex = 13;
            // 
            // c_pos
            // 
            this.c_pos.FormattingEnabled = true;
            this.c_pos.Items.AddRange(new object[] {
            "Cashier",
            "Chef",
            "Admin"});
            this.c_pos.Location = new System.Drawing.Point(334, 504);
            this.c_pos.Name = "c_pos";
            this.c_pos.Size = new System.Drawing.Size(177, 21);
            this.c_pos.TabIndex = 14;
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(227, 535);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(75, 23);
            this.b_insert.TabIndex = 15;
            this.b_insert.Text = "Insert";
            this.b_insert.UseVisualStyleBackColor = true;
            this.b_insert.Click += new System.EventHandler(this.b_insert_Click);
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(320, 535);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 23);
            this.b_update.TabIndex = 16;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = true;
            this.b_update.Click += new System.EventHandler(this.b_update_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(412, 535);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 17;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // t_pass
            // 
            this.t_pass.Location = new System.Drawing.Point(334, 444);
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(179, 20);
            this.t_pass.TabIndex = 19;
            this.t_pass.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(265, 451);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Password";
            // 
            // b_add
            // 
            this.b_add.Location = new System.Drawing.Point(503, 535);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(75, 23);
            this.b_add.TabIndex = 20;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 570);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.t_pass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.c_pos);
            this.Controls.Add(this.t_hp);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.ComboBox c_pos;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button b_add;
    }
}