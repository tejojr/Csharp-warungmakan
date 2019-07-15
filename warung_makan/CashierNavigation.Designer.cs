namespace warung_makan
{
    partial class CashierNavigation
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
            this.b_pay = new System.Windows.Forms.Button();
            this.t_nama = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 101);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashier Navigation";
            // 
            // b_logout
            // 
            this.b_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_logout.Location = new System.Drawing.Point(80, 242);
            this.b_logout.Name = "b_logout";
            this.b_logout.Size = new System.Drawing.Size(195, 31);
            this.b_logout.TabIndex = 20;
            this.b_logout.Text = "Logout";
            this.b_logout.UseVisualStyleBackColor = true;
            // 
            // b_pass
            // 
            this.b_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pass.Location = new System.Drawing.Point(80, 194);
            this.b_pass.Name = "b_pass";
            this.b_pass.Size = new System.Drawing.Size(195, 31);
            this.b_pass.TabIndex = 19;
            this.b_pass.Text = "Change Password";
            this.b_pass.UseVisualStyleBackColor = true;
            // 
            // b_pay
            // 
            this.b_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_pay.Location = new System.Drawing.Point(80, 144);
            this.b_pay.Name = "b_pay";
            this.b_pay.Size = new System.Drawing.Size(195, 31);
            this.b_pay.TabIndex = 18;
            this.b_pay.Text = "Paymnet";
            this.b_pay.UseVisualStyleBackColor = true;
            // 
            // t_nama
            // 
            this.t_nama.AutoSize = true;
            this.t_nama.Location = new System.Drawing.Point(8, 116);
            this.t_nama.Name = "t_nama";
            this.t_nama.Size = new System.Drawing.Size(35, 13);
            this.t_nama.TabIndex = 17;
            this.t_nama.Text = "label2";
            // 
            // CashierNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 387);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.b_logout);
            this.Controls.Add(this.b_pass);
            this.Controls.Add(this.b_pay);
            this.Controls.Add(this.t_nama);
            this.Name = "CashierNavigation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierNavigation";
            this.Load += new System.EventHandler(this.CashierNavigation_Load);
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
        private System.Windows.Forms.Button b_pay;
        private System.Windows.Forms.Label t_nama;
    }
}