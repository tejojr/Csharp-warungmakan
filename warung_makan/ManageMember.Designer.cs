namespace warung_makan
{
    partial class ManageMember
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
            this.b_update = new System.Windows.Forms.Button();
            this.b_insert = new System.Windows.Forms.Button();
            this.t_hp = new System.Windows.Forms.TextBox();
            this.t_email = new System.Windows.Forms.TextBox();
            this.t_nama = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_cari = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_delete = new System.Windows.Forms.Button();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(260, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Manage Member";
            // 
            // b_update
            // 
            this.b_update.Location = new System.Drawing.Point(549, 447);
            this.b_update.Name = "b_update";
            this.b_update.Size = new System.Drawing.Size(75, 23);
            this.b_update.TabIndex = 53;
            this.b_update.Text = "Update";
            this.b_update.UseVisualStyleBackColor = true;
            // 
            // b_insert
            // 
            this.b_insert.Location = new System.Drawing.Point(456, 447);
            this.b_insert.Name = "b_insert";
            this.b_insert.Size = new System.Drawing.Size(75, 23);
            this.b_insert.TabIndex = 52;
            this.b_insert.Text = "Insert";
            this.b_insert.UseVisualStyleBackColor = true;
            // 
            // t_hp
            // 
            this.t_hp.Location = new System.Drawing.Point(539, 404);
            this.t_hp.Name = "t_hp";
            this.t_hp.Size = new System.Drawing.Size(177, 20);
            this.t_hp.TabIndex = 51;
            // 
            // t_email
            // 
            this.t_email.Location = new System.Drawing.Point(539, 375);
            this.t_email.Name = "t_email";
            this.t_email.Size = new System.Drawing.Size(177, 20);
            this.t_email.TabIndex = 50;
            // 
            // t_nama
            // 
            this.t_nama.Location = new System.Drawing.Point(539, 346);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(177, 20);
            this.t_nama.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Handphone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cari";
            // 
            // t_cari
            // 
            this.t_cari.Location = new System.Drawing.Point(76, 319);
            this.t_cari.Name = "t_cari";
            this.t_cari.Size = new System.Drawing.Size(131, 20);
            this.t_cari.TabIndex = 41;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(806, 207);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 93);
            this.panel1.TabIndex = 39;
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(641, 447);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 54;
            this.b_delete.Text = "Delete";
            this.b_delete.UseVisualStyleBackColor = true;
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(539, 312);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(177, 20);
            this.t_id.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Member Id";
            // 
            // ManageMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 482);
            this.Controls.Add(this.b_delete);
            this.Controls.Add(this.b_update);
            this.Controls.Add(this.b_insert);
            this.Controls.Add(this.t_hp);
            this.Controls.Add(this.t_email);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.t_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_cari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageMember";
            this.Text = "ManageMember";
            this.Load += new System.EventHandler(this.ManageMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_update;
        private System.Windows.Forms.Button b_insert;
        private System.Windows.Forms.TextBox t_hp;
        private System.Windows.Forms.TextBox t_email;
        private System.Windows.Forms.TextBox t_nama;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_cari;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label3;
    }
}