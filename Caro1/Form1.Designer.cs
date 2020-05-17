namespace Caro1
{
    partial class Form1
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
            this.pnlBanCo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBanCo
            // 
            this.pnlBanCo.Location = new System.Drawing.Point(12, 12);
            this.pnlBanCo.Name = "pnlBanCo";
            this.pnlBanCo.Size = new System.Drawing.Size(810, 689);
            this.pnlBanCo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Luật chơi:";
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(836, 432);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(377, 45);
            this.btn_Restart.TabIndex = 3;
            this.btn_Restart.Text = "Chơi lại";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "-Nếu bạn thua trong 5 lượt đấu, bạn nên google cách chơi",
            "-Nếu bạn thua trong 6 - 10 lượt đấu, xin lỗi, trình 2 bên quá chênh lệch.",
            "-Từ 10 - 50 lượt đấu, được đấy !!!",
            "-Từ 50 - 100 lượt đấu, 2 bên là kỳ phùng địch thủ (đúng chính tả không nhỉ?)",
            "-Từ 100 lượt trở lên....... Chúng ta nên dừng ở đây thôi, sắp hết chỗ đánh rồi"});
            this.listBox1.Location = new System.Drawing.Point(0, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 199);
            this.listBox1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(836, 483);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 218);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Caro1.Properties.Resources._77265869_494024501469799_7345323769075859456_o;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(836, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 414);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1225, 711);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBanCo);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahihi";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBanCo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel3;
    }
}

