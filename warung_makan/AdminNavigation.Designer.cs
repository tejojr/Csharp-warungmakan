namespace warung_makan
{
    partial class AdminNavigation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.t_nama = new System.Windows.Forms.Label();
            this.b_order = new System.Windows.Forms.Button();
            this.b_employee = new System.Windows.Forms.Button();
            this.b_menu = new System.Windows.Forms.Button();
            this.b_member = new System.Windows.Forms.Button();
            this.b_pass = new System.Windows.Forms.Button();
            this.b_logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 101);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Navigation";
            // 
            // t_nama
            // 
            this.t_nama.AutoSize = true;
            this.t_nama.Location = new System.Drawing.Point(12, 112);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(35, 13);
            this.t_nama.TabIndex = 1;
            this.t_nama.Text = "label2";
            // 
            // b_order
            // 
            this.b_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_order.Location = new System.Drawing.Point(87, 147);
            this.b_order.Name = "b_order";
            this.b_order.Size = new System.Drawing.Size(195, 31);
            this.b_order.TabIndex = 2;
            this.b_order.Text = "Order";
            this.b_order.UseVisualStyleBackColor = true;
            // 
            // b_employee
            // 
            this.b_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_employee.Location = new System.Drawing.Point(87, 184);
            this.b_employee.Name = "b_employee";
            this.b_employee.Size = new System.Drawing.Size(195, 31);
            this.b_employee.TabIndex = 3;
            this.b_employee.Text = "Manage Employee";
            this.b_employee.UseVisualStyleBackColor = true;
            // 
            // b_menu
            // 
            this.b_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_menu.Location = new System.Drawing.Point(87, 221);
            this.b_menu.Name = "b_menu";
            this.b_menu.Size = new System.Drawing.Size(195, 31);
            this.b_menu.TabIndex = 4;
            this.b_menu.Text = "Manage Menu";
            this.b_menu.UseVisualStyleBackColor = true;
            // 
            // b_member
            // 
            this.b_member.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_member.Location = new System.Drawing.Point(87, 258);
            this.b_member.Name = "b_member";
            this.b_member.Size = new System.Drawing.Size(195, 31);
            this.b_member.TabIndex = 5;
            this.b_member.Text = "Manage Member";
            this.b_member.UseVisualStyleBackColor = true;
            // 
            // b_pass
            // 
            this.b_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pass.Location = new System.Drawing.Point(87, 295);
            this.b_pass.Name = "b_pass";
            this.b_pass.Size = new System.Drawing.Size(195, 31);
            this.b_pass.TabIndex = 6;
            this.b_pass.Text = "Change Password";
            this.b_pass.UseVisualStyleBackColor = true;
            // 
            // b_logout
            // 
            this.b_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logout.Location = new System.Drawing.Point(87, 332);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(195, 31);
            this.b_logout.TabIndex = 7;
            this.b_logout.Text = "Logout";
            this.b_logout.UseVisualStyleBackColor = true;
            // 
            // AdminNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 375);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.b_pass);
            this.Controls.Add(this.b_member);
            this.Controls.Add(this.b_menu);
            this.Controls.Add(this.b_employee);
            this.Controls.Add(this.b_order);
            this.Controls.Add(this.t_nama);
            this.Controls.Add(this.panel1);
            this.Name = "AdminNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminNavigation";
            this.Load += new System.EventHandler(this.AdminNavigation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label t_nama;
        private System.Windows.Forms.Button b_order;
        private System.Windows.Forms.Button b_employee;
        private System.Windows.Forms.Button b_menu;
        private System.Windows.Forms.Button b_member;
        private System.Windows.Forms.Button b_pass;
        private System.Windows.Forms.Button b_logout;
    }
}