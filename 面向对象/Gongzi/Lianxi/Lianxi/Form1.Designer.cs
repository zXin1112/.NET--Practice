namespace Lianxi
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
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNchongzhi = new System.Windows.Forms.Button();
            this.LBLNAME = new System.Windows.Forms.Label();
            this.LBLQUANTITY = new System.Windows.Forms.Label();
            this.LBLprice = new System.Windows.Forms.Label();
            this.LBLQRIGIN = new System.Windows.Forms.Label();
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.TXTSHULIANG = new System.Windows.Forms.TextBox();
            this.TXTDANJIA = new System.Windows.Forms.TextBox();
            this.TXTCHANDI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNADD
            // 
            this.BTNADD.Location = new System.Drawing.Point(59, 276);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(75, 23);
            this.BTNADD.TabIndex = 0;
            this.BTNADD.Text = "添加";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNchongzhi
            // 
            this.BTNchongzhi.Location = new System.Drawing.Point(358, 276);
            this.BTNchongzhi.Name = "BTNchongzhi";
            this.BTNchongzhi.Size = new System.Drawing.Size(75, 23);
            this.BTNchongzhi.TabIndex = 1;
            this.BTNchongzhi.Text = "重置";
            this.BTNchongzhi.UseVisualStyleBackColor = true;
            // 
            // LBLNAME
            // 
            this.LBLNAME.AutoSize = true;
            this.LBLNAME.Location = new System.Drawing.Point(125, 30);
            this.LBLNAME.Name = "LBLNAME";
            this.LBLNAME.Size = new System.Drawing.Size(52, 15);
            this.LBLNAME.TabIndex = 2;
            this.LBLNAME.Text = "商品名";
            // 
            // LBLQUANTITY
            // 
            this.LBLQUANTITY.AutoSize = true;
            this.LBLQUANTITY.Location = new System.Drawing.Point(125, 82);
            this.LBLQUANTITY.Name = "LBLQUANTITY";
            this.LBLQUANTITY.Size = new System.Drawing.Size(37, 15);
            this.LBLQUANTITY.TabIndex = 3;
            this.LBLQUANTITY.Text = "数量";
            // 
            // LBLprice
            // 
            this.LBLprice.AutoSize = true;
            this.LBLprice.Location = new System.Drawing.Point(125, 129);
            this.LBLprice.Name = "LBLprice";
            this.LBLprice.Size = new System.Drawing.Size(37, 15);
            this.LBLprice.TabIndex = 4;
            this.LBLprice.Text = "单价";
            // 
            // LBLQRIGIN
            // 
            this.LBLQRIGIN.AutoSize = true;
            this.LBLQRIGIN.Location = new System.Drawing.Point(125, 167);
            this.LBLQRIGIN.Name = "LBLQRIGIN";
            this.LBLQRIGIN.Size = new System.Drawing.Size(37, 15);
            this.LBLQRIGIN.TabIndex = 5;
            this.LBLQRIGIN.Text = "产地";
            // 
            // TXTNAME
            // 
            this.TXTNAME.Location = new System.Drawing.Point(284, 20);
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(100, 25);
            this.TXTNAME.TabIndex = 6;
            // 
            // TXTSHULIANG
            // 
            this.TXTSHULIANG.Location = new System.Drawing.Point(284, 72);
            this.TXTSHULIANG.Name = "TXTSHULIANG";
            this.TXTSHULIANG.Size = new System.Drawing.Size(100, 25);
            this.TXTSHULIANG.TabIndex = 7;
            // 
            // TXTDANJIA
            // 
            this.TXTDANJIA.Location = new System.Drawing.Point(284, 119);
            this.TXTDANJIA.Name = "TXTDANJIA";
            this.TXTDANJIA.Size = new System.Drawing.Size(100, 25);
            this.TXTDANJIA.TabIndex = 8;
            // 
            // TXTCHANDI
            // 
            this.TXTCHANDI.Location = new System.Drawing.Point(284, 167);
            this.TXTCHANDI.Name = "TXTCHANDI";
            this.TXTCHANDI.Size = new System.Drawing.Size(100, 25);
            this.TXTCHANDI.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 342);
            this.Controls.Add(this.TXTCHANDI);
            this.Controls.Add(this.TXTDANJIA);
            this.Controls.Add(this.TXTSHULIANG);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.LBLQRIGIN);
            this.Controls.Add(this.LBLprice);
            this.Controls.Add(this.LBLQUANTITY);
            this.Controls.Add(this.LBLNAME);
            this.Controls.Add(this.BTNchongzhi);
            this.Controls.Add(this.BTNADD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNchongzhi;
        private System.Windows.Forms.Label LBLNAME;
        private System.Windows.Forms.Label LBLQUANTITY;
        private System.Windows.Forms.Label LBLprice;
        private System.Windows.Forms.Label LBLQRIGIN;
        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.TextBox TXTSHULIANG;
        private System.Windows.Forms.TextBox TXTDANJIA;
        private System.Windows.Forms.TextBox TXTCHANDI;
    }
}

