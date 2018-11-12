namespace Sock
{
    partial class FUWU
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtDUAN = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnFa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(406, 57);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始监听";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(37, 57);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(166, 25);
            this.txtIP.TabIndex = 1;
            // 
            // txtDUAN
            // 
            this.txtDUAN.Location = new System.Drawing.Point(218, 58);
            this.txtDUAN.Name = "txtDUAN";
            this.txtDUAN.Size = new System.Drawing.Size(77, 25);
            this.txtDUAN.TabIndex = 2;
            this.txtDUAN.Text = "50000";
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(37, 106);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(594, 142);
            this.txtlog.TabIndex = 4;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(37, 273);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(594, 128);
            this.txtSend.TabIndex = 5;
            // 
            // btnFa
            // 
            this.btnFa.Location = new System.Drawing.Point(476, 440);
            this.btnFa.Name = "btnFa";
            this.btnFa.Size = new System.Drawing.Size(75, 23);
            this.btnFa.TabIndex = 6;
            this.btnFa.Text = "发送";
            this.btnFa.UseVisualStyleBackColor = true;
            this.btnFa.Click += new System.EventHandler(this.btnFa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 487);
            this.Controls.Add(this.btnFa);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.txtDUAN);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtDUAN;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnFa;
    }
}

