﻿namespace Fridend_Book
{
    partial class FrmModify
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
            this.PicHead = new System.Windows.Forms.PictureBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.LBLbirthday = new System.Windows.Forms.Label();
            this.cmbdiqu = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.Btncancle = new System.Windows.Forms.Button();
            this.BTNxiu = new System.Windows.Forms.Button();
            this.txtWX = new System.Windows.Forms.TextBox();
            this.comboBoxXB = new System.Windows.Forms.ComboBox();
            this.txtPY = new System.Windows.Forms.TextBox();
            this.txtSJH = new System.Windows.Forms.TextBox();
            this.txtDZ = new System.Windows.Forms.TextBox();
            this.txtEMAIL = new System.Windows.Forms.TextBox();
            this.txtQQ = new System.Windows.Forms.TextBox();
            this.lblPY = new System.Windows.Forms.Label();
            this.lblPHOTO = new System.Windows.Forms.Label();
            this.lblWX = new System.Windows.Forms.Label();
            this.lblQQ = new System.Windows.Forms.Label();
            this.lblJG = new System.Windows.Forms.Label();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.lblDZ = new System.Windows.Forms.Label();
            this.lblSJH = new System.Windows.Forms.Label();
            this.lblXB = new System.Windows.Forms.Label();
            this.txtXM = new System.Windows.Forms.TextBox();
            this.lblXM = new System.Windows.Forms.Label();
            this.OFDphoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PicHead)).BeginInit();
            this.SuspendLayout();
            // 
            // PicHead
            // 
            this.PicHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicHead.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.PicHead.Location = new System.Drawing.Point(404, 112);
            this.PicHead.Name = "PicHead";
            this.PicHead.Size = new System.Drawing.Size(112, 135);
            this.PicHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicHead.TabIndex = 54;
            this.PicHead.TabStop = false;
            this.PicHead.Click += new System.EventHandler(this.PicHead_Click);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(199, 145);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(180, 25);
            this.dtpBirthday.TabIndex = 53;
            // 
            // LBLbirthday
            // 
            this.LBLbirthday.AutoSize = true;
            this.LBLbirthday.Location = new System.Drawing.Point(104, 151);
            this.LBLbirthday.Name = "LBLbirthday";
            this.LBLbirthday.Size = new System.Drawing.Size(67, 15);
            this.LBLbirthday.TabIndex = 52;
            this.LBLbirthday.Text = "出生日期";
            // 
            // cmbdiqu
            // 
            this.cmbdiqu.FormattingEnabled = true;
            this.cmbdiqu.Location = new System.Drawing.Point(418, 305);
            this.cmbdiqu.Name = "cmbdiqu";
            this.cmbdiqu.Size = new System.Drawing.Size(121, 23);
            this.cmbdiqu.TabIndex = 51;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(287, 305);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 23);
            this.cmbCity.TabIndex = 50;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(147, 305);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(121, 23);
            this.cmbProvince.TabIndex = 49;
            this.cmbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvince_SelectedIndexChanged);
            // 
            // Btncancle
            // 
            this.Btncancle.Location = new System.Drawing.Point(431, 492);
            this.Btncancle.Name = "Btncancle";
            this.Btncancle.Size = new System.Drawing.Size(75, 23);
            this.Btncancle.TabIndex = 48;
            this.Btncancle.Text = "取消";
            this.Btncancle.UseVisualStyleBackColor = true;
            // 
            // BTNxiu
            // 
            this.BTNxiu.Location = new System.Drawing.Point(94, 492);
            this.BTNxiu.Name = "BTNxiu";
            this.BTNxiu.Size = new System.Drawing.Size(75, 23);
            this.BTNxiu.TabIndex = 47;
            this.BTNxiu.Text = "修改";
            this.BTNxiu.UseVisualStyleBackColor = true;
            this.BTNxiu.Click += new System.EventHandler(this.BTNxiu_Click);
            // 
            // txtWX
            // 
            this.txtWX.Location = new System.Drawing.Point(199, 378);
            this.txtWX.Name = "txtWX";
            this.txtWX.Size = new System.Drawing.Size(121, 25);
            this.txtWX.TabIndex = 46;
            // 
            // comboBoxXB
            // 
            this.comboBoxXB.FormattingEnabled = true;
            this.comboBoxXB.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBoxXB.Location = new System.Drawing.Point(199, 111);
            this.comboBoxXB.Name = "comboBoxXB";
            this.comboBoxXB.Size = new System.Drawing.Size(121, 23);
            this.comboBoxXB.TabIndex = 45;
            this.comboBoxXB.Text = "男";
            // 
            // txtPY
            // 
            this.txtPY.Location = new System.Drawing.Point(199, 409);
            this.txtPY.Multiline = true;
            this.txtPY.Name = "txtPY";
            this.txtPY.Size = new System.Drawing.Size(290, 61);
            this.txtPY.TabIndex = 44;
            // 
            // txtSJH
            // 
            this.txtSJH.Location = new System.Drawing.Point(199, 176);
            this.txtSJH.Name = "txtSJH";
            this.txtSJH.Size = new System.Drawing.Size(121, 25);
            this.txtSJH.TabIndex = 43;
            // 
            // txtDZ
            // 
            this.txtDZ.Location = new System.Drawing.Point(199, 222);
            this.txtDZ.Name = "txtDZ";
            this.txtDZ.Size = new System.Drawing.Size(121, 25);
            this.txtDZ.TabIndex = 42;
            // 
            // txtEMAIL
            // 
            this.txtEMAIL.Location = new System.Drawing.Point(199, 258);
            this.txtEMAIL.Name = "txtEMAIL";
            this.txtEMAIL.Size = new System.Drawing.Size(121, 25);
            this.txtEMAIL.TabIndex = 41;
            // 
            // txtQQ
            // 
            this.txtQQ.Location = new System.Drawing.Point(199, 342);
            this.txtQQ.Name = "txtQQ";
            this.txtQQ.Size = new System.Drawing.Size(121, 25);
            this.txtQQ.TabIndex = 40;
            // 
            // lblPY
            // 
            this.lblPY.AutoSize = true;
            this.lblPY.Location = new System.Drawing.Point(107, 426);
            this.lblPY.Name = "lblPY";
            this.lblPY.Size = new System.Drawing.Size(37, 15);
            this.lblPY.TabIndex = 39;
            this.lblPY.Text = "评语";
            // 
            // lblPHOTO
            // 
            this.lblPHOTO.AutoSize = true;
            this.lblPHOTO.Location = new System.Drawing.Point(371, 64);
            this.lblPHOTO.Name = "lblPHOTO";
            this.lblPHOTO.Size = new System.Drawing.Size(37, 15);
            this.lblPHOTO.TabIndex = 38;
            this.lblPHOTO.Text = "头像";
            // 
            // lblWX
            // 
            this.lblWX.AutoSize = true;
            this.lblWX.Location = new System.Drawing.Point(104, 389);
            this.lblWX.Name = "lblWX";
            this.lblWX.Size = new System.Drawing.Size(37, 15);
            this.lblWX.TabIndex = 37;
            this.lblWX.Text = "微信";
            // 
            // lblQQ
            // 
            this.lblQQ.AutoSize = true;
            this.lblQQ.Location = new System.Drawing.Point(104, 352);
            this.lblQQ.Name = "lblQQ";
            this.lblQQ.Size = new System.Drawing.Size(23, 15);
            this.lblQQ.TabIndex = 36;
            this.lblQQ.Text = "QQ";
            // 
            // lblJG
            // 
            this.lblJG.AutoSize = true;
            this.lblJG.Location = new System.Drawing.Point(104, 313);
            this.lblJG.Name = "lblJG";
            this.lblJG.Size = new System.Drawing.Size(37, 15);
            this.lblJG.TabIndex = 35;
            this.lblJG.Text = "籍贯";
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Location = new System.Drawing.Point(101, 268);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(55, 15);
            this.lblEMAIL.TabIndex = 34;
            this.lblEMAIL.Text = "E-mail";
            // 
            // lblDZ
            // 
            this.lblDZ.AutoSize = true;
            this.lblDZ.Location = new System.Drawing.Point(104, 232);
            this.lblDZ.Name = "lblDZ";
            this.lblDZ.Size = new System.Drawing.Size(37, 15);
            this.lblDZ.TabIndex = 33;
            this.lblDZ.Text = "地址";
            // 
            // lblSJH
            // 
            this.lblSJH.AutoSize = true;
            this.lblSJH.Location = new System.Drawing.Point(101, 186);
            this.lblSJH.Name = "lblSJH";
            this.lblSJH.Size = new System.Drawing.Size(52, 15);
            this.lblSJH.TabIndex = 32;
            this.lblSJH.Text = "手机号";
            // 
            // lblXB
            // 
            this.lblXB.AutoSize = true;
            this.lblXB.Location = new System.Drawing.Point(104, 111);
            this.lblXB.Name = "lblXB";
            this.lblXB.Size = new System.Drawing.Size(37, 15);
            this.lblXB.TabIndex = 31;
            this.lblXB.Text = "性别";
            // 
            // txtXM
            // 
            this.txtXM.Location = new System.Drawing.Point(199, 64);
            this.txtXM.Name = "txtXM";
            this.txtXM.Size = new System.Drawing.Size(121, 25);
            this.txtXM.TabIndex = 30;
            // 
            // lblXM
            // 
            this.lblXM.AutoSize = true;
            this.lblXM.Location = new System.Drawing.Point(104, 67);
            this.lblXM.Name = "lblXM";
            this.lblXM.Size = new System.Drawing.Size(37, 15);
            this.lblXM.TabIndex = 29;
            this.lblXM.Text = "姓名";
            // 
            // OFDphoto
            // 
            this.OFDphoto.FileName = "openFileDialog1";
            this.OFDphoto.Filter = "图片文件(*.png,*.jpg,*.gif)|*.png;*.jpg;*.gif";
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 579);
            this.Controls.Add(this.PicHead);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.LBLbirthday);
            this.Controls.Add(this.cmbdiqu);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbProvince);
            this.Controls.Add(this.Btncancle);
            this.Controls.Add(this.BTNxiu);
            this.Controls.Add(this.txtWX);
            this.Controls.Add(this.comboBoxXB);
            this.Controls.Add(this.txtPY);
            this.Controls.Add(this.txtSJH);
            this.Controls.Add(this.txtDZ);
            this.Controls.Add(this.txtEMAIL);
            this.Controls.Add(this.txtQQ);
            this.Controls.Add(this.lblPY);
            this.Controls.Add(this.lblPHOTO);
            this.Controls.Add(this.lblWX);
            this.Controls.Add(this.lblQQ);
            this.Controls.Add(this.lblJG);
            this.Controls.Add(this.lblEMAIL);
            this.Controls.Add(this.lblDZ);
            this.Controls.Add(this.lblSJH);
            this.Controls.Add(this.lblXB);
            this.Controls.Add(this.txtXM);
            this.Controls.Add(this.lblXM);
            this.Name = "FrmModify";
            this.Text = "FrmModify";
            this.Load += new System.EventHandler(this.FrmModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicHead;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label LBLbirthday;
        private System.Windows.Forms.ComboBox cmbdiqu;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Button Btncancle;
        private System.Windows.Forms.Button BTNxiu;
        private System.Windows.Forms.TextBox txtWX;
        private System.Windows.Forms.ComboBox comboBoxXB;
        private System.Windows.Forms.TextBox txtPY;
        private System.Windows.Forms.TextBox txtSJH;
        private System.Windows.Forms.TextBox txtDZ;
        private System.Windows.Forms.TextBox txtEMAIL;
        private System.Windows.Forms.TextBox txtQQ;
        private System.Windows.Forms.Label lblPY;
        private System.Windows.Forms.Label lblPHOTO;
        private System.Windows.Forms.Label lblWX;
        private System.Windows.Forms.Label lblQQ;
        private System.Windows.Forms.Label lblJG;
        private System.Windows.Forms.Label lblEMAIL;
        private System.Windows.Forms.Label lblDZ;
        private System.Windows.Forms.Label lblSJH;
        private System.Windows.Forms.Label lblXB;
        private System.Windows.Forms.TextBox txtXM;
        private System.Windows.Forms.Label lblXM;
        private System.Windows.Forms.OpenFileDialog OFDphoto;
    }
}