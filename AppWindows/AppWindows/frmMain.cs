namespace AppWindows
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.btnTinhToan = new System.Windows.Forms.Button();
            this.btnXoSo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnVietLot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinhToan
            // 
            this.btnTinhToan.Location = new System.Drawing.Point(175, 41);
            this.btnTinhToan.Name = "btnTinhToan";
            this.btnTinhToan.Size = new System.Drawing.Size(130, 23);
            this.btnTinhToan.TabIndex = 0;
            this.btnTinhToan.Text = "Tính Toán";
            this.btnTinhToan.UseVisualStyleBackColor = true;
            this.btnTinhToan.Click += new System.EventHandler(this.btnTinhToan_Click);
            // 
            // btnXoSo
            // 
            this.btnXoSo.Location = new System.Drawing.Point(175, 84);
            this.btnXoSo.Name = "btnXoSo";
            this.btnXoSo.Size = new System.Drawing.Size(130, 23);
            this.btnXoSo.TabIndex = 1;
            this.btnXoSo.Text = "Xổ Số";
            this.btnXoSo.UseVisualStyleBackColor = true;
            this.btnXoSo.Click += new System.EventHandler(this.btnXoSo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnVietLot
            // 
            this.btnVietLot.Location = new System.Drawing.Point(175, 131);
            this.btnVietLot.Name = "btnVietLot";
            this.btnVietLot.Size = new System.Drawing.Size(130, 23);
            this.btnVietLot.TabIndex = 2;
            this.btnVietLot.Text = "Game xếp hình";
            this.btnVietLot.UseVisualStyleBackColor = true;
            this.btnVietLot.Click += new System.EventHandler(this.btnVietLot_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "NotePad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Server";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Client";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVietLot);
            this.Controls.Add(this.btnXoSo);
            this.Controls.Add(this.btnTinhToan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "DANH SÁCH BÀI TẬP LẬP TRÌNH WINDOWS";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTinhToan;
        private System.Windows.Forms.Button btnXoSo;
        private System.Windows.Forms.Timer timer1;

        private void btnVietLot_Click(object sender, System.EventArgs e)
        {
            frmGameXepHinh f3 = new frmGameXepHinh();
            f3.ShowDialog();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            frmNotepad f4 = new frmNotepad();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            frmServer server = new frmServer();
            server.Show();
            

        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            frmClient client = new frmClient();
            client.Show();
        }
    }
}

