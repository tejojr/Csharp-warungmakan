namespace warung_makan
{
    partial class ChefNavigation
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
            this.b_logout = new System.Windows.Forms.Button();
            this.b_pass = new System.Windows.Forms.Button();
            this.b_order = new System.Windows.Forms.Button();
            this.t_nama = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 101);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chef Navigation";
            // 
            // b_logout
            // 
            this.b_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logout.Location = new System.Drawing.Point(84, 243);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(195, 31);
            this.b_logout.TabIndex = 15;
            this.b_logout.Text = "Logout";
            this.b_logout.UseVisualStyleBackColor = true;
            // 
            // b_pass
            // 
            this.b_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pass.Location = new System.Drawing.Point(84, 195);
            this.b_pass.Name = "b_pass";
            this.b_pass.Size = new System.Drawing.Size(195, 31);
            this.b_pass.TabIndex = 14;
            this.b_pass.Text = "Change Password";
            this.b_pass.UseVisualStyleBackColor = true;
            // 
            // b_order
            // 
            this.b_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_order.Location = new System.Drawing.Point(84, 145);
            this.b_order.Name = "b_order";
            this.b_order.Size = new System.Drawing.Size(195, 31);
            this.b_order.TabIndex = 10;
            this.b_order.Text = "View Order";
            this.b_order.UseVisualStyleBackColor = true;
            // 
            // t_nama
            // 
            this.t_nama.AutoSize = true;
            this.t_nama.Location = new System.Drawing.Point(12, 117);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(35, 13);
            this.t_nama.TabIndex = 9;
            this.t_nama.Text = "label2";
            // 
            // ChefNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 396);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.b_pass);
            this.Controls.Add(this.b_order);
            this.Controls.Add(this.t_nama);
            this.Name = "ChefNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefNavigation";
            this.Load += new System.EventHandler(this.ChefNavigation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_logout;
        private System.Windows.Forms.Button b_pass;
        private System.Windows.Forms.Button b_order;
        private System.Windows.Forms.Label t_nama;
    }
}