namespace Usersock
{
    partial class uSER
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSTART = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDUAN = new System.Windows.Forms.TextBox();
            this.txtLOG = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnFASONG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(458, 78);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(111, 23);
            this.btnSTART.TabIndex = 0;
            this.btnSTART.Text = "开始链接";
            this.btnSTART.UseVisualStyleBackColor = true;
            this.btnSTART.Click += new System.EventHandler(this.btnSTART_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(55, 76);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(151, 25);
            this.txtIP.TabIndex = 1;
            // 
            // txtDUAN
            // 
            this.txtDUAN.Location = new System.Drawing.Point(212, 76);
            this.txtDUAN.Name = "txtDUAN";
            this.txtDUAN.Size = new System.Drawing.Size(51, 25);
            this.txtDUAN.TabIndex = 2;
            this.txtDUAN.Text = "50000";
            // 
            // txtLOG
            // 
            this.txtLOG.Location = new System.Drawing.Point(31, 143);
            this.txtLOG.Multiline = true;
            this.txtLOG.Name = "txtLOG";
            this.txtLOG.Size = new System.Drawing.Size(669, 211);
            this.txtLOG.TabIndex = 3;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(31, 386);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(669, 128);
            this.txtSend.TabIndex = 4;
            // 
            // btnFASONG
            // 
            this.btnFASONG.Location = new System.Drawing.Point(669, 561);
            this.btnFASONG.Name = "btnFASONG";
            this.btnFASONG.Size = new System.Drawing.Size(75, 23);
            this.btnFASONG.TabIndex = 5;
            this.btnFASONG.Text = "发送";
            this.btnFASONG.UseVisualStyleBackColor = true;
            this.btnFASONG.Click += new System.EventHandler(this.btnFASONG_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 616);
            this.Controls.Add(this.btnFASONG);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtLOG);
            this.Controls.Add(this.txtDUAN);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSTART);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSTART;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtDUAN;
        private System.Windows.Forms.TextBox txtLOG;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnFASONG;
    }
}

