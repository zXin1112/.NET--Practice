namespace Gongzi
{
    partial class Form1
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
            this.BTNtianjia = new System.Windows.Forms.Button();
            this.CMBxiangmu = new System.Windows.Forms.ComboBox();
            this.TXTjine = new System.Windows.Forms.TextBox();
            this.BTNzongji = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNtianjia
            // 
            this.BTNtianjia.Location = new System.Drawing.Point(432, 53);
            this.BTNtianjia.Name = "BTNtianjia";
            this.BTNtianjia.Size = new System.Drawing.Size(75, 23);
            this.BTNtianjia.TabIndex = 1;
            this.BTNtianjia.Text = "添加";
            this.BTNtianjia.UseVisualStyleBackColor = true;
            this.BTNtianjia.Click += new System.EventHandler(this.BTNtianjia_Click_1);
            // 
            // CMBxiangmu
            // 
            this.CMBxiangmu.FormattingEnabled = true;
            this.CMBxiangmu.Location = new System.Drawing.Point(177, 53);
            this.CMBxiangmu.Name = "CMBxiangmu";
            this.CMBxiangmu.Size = new System.Drawing.Size(121, 23);
            this.CMBxiangmu.TabIndex = 2;
            // 
            // TXTjine
            // 
            this.TXTjine.Location = new System.Drawing.Point(177, 142);
            this.TXTjine.Name = "TXTjine";
            this.TXTjine.Size = new System.Drawing.Size(121, 25);
            this.TXTjine.TabIndex = 3;
            // 
            // BTNzongji
            // 
            this.BTNzongji.Location = new System.Drawing.Point(432, 144);
            this.BTNzongji.Name = "BTNzongji";
            this.BTNzongji.Size = new System.Drawing.Size(75, 23);
            this.BTNzongji.TabIndex = 4;
            this.BTNzongji.Text = "总计";
            this.BTNzongji.UseVisualStyleBackColor = true;
            this.BTNzongji.Click += new System.EventHandler(this.BTNzongji_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 202);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 267);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 512);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNzongji);
            this.Controls.Add(this.TXTjine);
            this.Controls.Add(this.CMBxiangmu);
            this.Controls.Add(this.BTNtianjia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNtianjia;
        private System.Windows.Forms.ComboBox CMBxiangmu;
        private System.Windows.Forms.TextBox TXTjine;
        private System.Windows.Forms.Button BTNzongji;
        private System.Windows.Forms.TextBox textBox1;
    }
}

