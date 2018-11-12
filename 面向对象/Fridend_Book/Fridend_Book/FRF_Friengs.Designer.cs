namespace Fridend_Book
{
    partial class FRF_Friengs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRF_Friengs));
            this.DGV_Friends = new System.Windows.Forms.DataGridView();
            this.CLA_XM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_QQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_JG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_DZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_WX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_XB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_SJH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLA_PY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BUT_ADD = new System.Windows.Forms.Button();
            this.BUT_DEL = new System.Windows.Forms.Button();
            this.BTNrz = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.ppdfriend = new System.Windows.Forms.PrintPreviewDialog();
            this.BTNxiugai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Friends)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Friends
            // 
            this.DGV_Friends.AllowUserToAddRows = false;
            this.DGV_Friends.AllowUserToDeleteRows = false;
            this.DGV_Friends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Friends.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLA_XM,
            this.DTPBirthday,
            this.age,
            this.CLA_QQ,
            this.CLA_JG,
            this.CLA_DZ,
            this.CLA_Email,
            this.CLA_WX,
            this.CLA_XB,
            this.CLA_SJH,
            this.CLA_PY});
            this.DGV_Friends.Location = new System.Drawing.Point(12, 12);
            this.DGV_Friends.MultiSelect = false;
            this.DGV_Friends.Name = "DGV_Friends";
            this.DGV_Friends.ReadOnly = true;
            this.DGV_Friends.RowTemplate.Height = 27;
            this.DGV_Friends.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Friends.Size = new System.Drawing.Size(953, 723);
            this.DGV_Friends.TabIndex = 0;
            this.DGV_Friends.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGV_Friends_KeyPress);
            // 
            // CLA_XM
            // 
            this.CLA_XM.DataPropertyName = "XM";
            this.CLA_XM.HeaderText = "姓名";
            this.CLA_XM.Name = "CLA_XM";
            this.CLA_XM.ReadOnly = true;
            // 
            // DTPBirthday
            // 
            this.DTPBirthday.DataPropertyName = "Birthday";
            this.DTPBirthday.HeaderText = "出生日期";
            this.DTPBirthday.Name = "DTPBirthday";
            this.DTPBirthday.ReadOnly = true;
            // 
            // age
            // 
            this.age.DataPropertyName = "Age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // CLA_QQ
            // 
            this.CLA_QQ.DataPropertyName = "QQ";
            this.CLA_QQ.HeaderText = "QQ";
            this.CLA_QQ.Name = "CLA_QQ";
            this.CLA_QQ.ReadOnly = true;
            // 
            // CLA_JG
            // 
            this.CLA_JG.DataPropertyName = "JG";
            this.CLA_JG.HeaderText = "籍贯";
            this.CLA_JG.Name = "CLA_JG";
            this.CLA_JG.ReadOnly = true;
            // 
            // CLA_DZ
            // 
            this.CLA_DZ.DataPropertyName = "DZ";
            this.CLA_DZ.HeaderText = "地址";
            this.CLA_DZ.Name = "CLA_DZ";
            this.CLA_DZ.ReadOnly = true;
            // 
            // CLA_Email
            // 
            this.CLA_Email.DataPropertyName = "Email";
            this.CLA_Email.HeaderText = "E-mail";
            this.CLA_Email.Name = "CLA_Email";
            this.CLA_Email.ReadOnly = true;
            // 
            // CLA_WX
            // 
            this.CLA_WX.DataPropertyName = "WX";
            this.CLA_WX.HeaderText = "微信";
            this.CLA_WX.Name = "CLA_WX";
            this.CLA_WX.ReadOnly = true;
            // 
            // CLA_XB
            // 
            this.CLA_XB.DataPropertyName = "XB";
            this.CLA_XB.HeaderText = "性别";
            this.CLA_XB.Name = "CLA_XB";
            this.CLA_XB.ReadOnly = true;
            // 
            // CLA_SJH
            // 
            this.CLA_SJH.DataPropertyName = "SJH";
            this.CLA_SJH.HeaderText = "手机号";
            this.CLA_SJH.Name = "CLA_SJH";
            this.CLA_SJH.ReadOnly = true;
            // 
            // CLA_PY
            // 
            this.CLA_PY.DataPropertyName = "PY";
            this.CLA_PY.HeaderText = "评语";
            this.CLA_PY.Name = "CLA_PY";
            this.CLA_PY.ReadOnly = true;
            // 
            // BUT_ADD
            // 
            this.BUT_ADD.Location = new System.Drawing.Point(1118, 46);
            this.BUT_ADD.Name = "BUT_ADD";
            this.BUT_ADD.Size = new System.Drawing.Size(119, 52);
            this.BUT_ADD.TabIndex = 1;
            this.BUT_ADD.Text = "添加";
            this.BUT_ADD.UseVisualStyleBackColor = true;
            this.BUT_ADD.Click += new System.EventHandler(this.BUT_ADD_Click);
            // 
            // BUT_DEL
            // 
            this.BUT_DEL.Location = new System.Drawing.Point(1109, 255);
            this.BUT_DEL.Name = "BUT_DEL";
            this.BUT_DEL.Size = new System.Drawing.Size(119, 52);
            this.BUT_DEL.TabIndex = 2;
            this.BUT_DEL.Text = "删除";
            this.BUT_DEL.UseVisualStyleBackColor = true;
            this.BUT_DEL.Click += new System.EventHandler(this.BUT_DEL_Click);
            // 
            // BTNrz
            // 
            this.BTNrz.Location = new System.Drawing.Point(1118, 382);
            this.BTNrz.Name = "BTNrz";
            this.BTNrz.Size = new System.Drawing.Size(119, 52);
            this.BTNrz.TabIndex = 3;
            this.BTNrz.Text = "查看日志";
            this.BTNrz.UseVisualStyleBackColor = true;
            this.BTNrz.Click += new System.EventHandler(this.BTNrz_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(1118, 528);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(119, 50);
            this.btnprint.TabIndex = 4;
            this.btnprint.Text = "打印";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // ppdfriend
            // 
            this.ppdfriend.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdfriend.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdfriend.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdfriend.Enabled = true;
            this.ppdfriend.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdfriend.Icon")));
            this.ppdfriend.Name = "ppdfriend";
            this.ppdfriend.Visible = false;
            // 
            // BTNxiugai
            // 
            this.BTNxiugai.Location = new System.Drawing.Point(1118, 138);
            this.BTNxiugai.Name = "BTNxiugai";
            this.BTNxiugai.Size = new System.Drawing.Size(119, 50);
            this.BTNxiugai.TabIndex = 5;
            this.BTNxiugai.Text = "修改";
            this.BTNxiugai.UseVisualStyleBackColor = true;
            this.BTNxiugai.Click += new System.EventHandler(this.BTNxiugai_Click);
            // 
            // FRF_Friengs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 757);
            this.Controls.Add(this.BTNxiugai);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.BTNrz);
            this.Controls.Add(this.BUT_DEL);
            this.Controls.Add(this.BUT_ADD);
            this.Controls.Add(this.DGV_Friends);
            this.Name = "FRF_Friengs";
            this.Text = "FRF_Friengs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRF_Friengs_FormClosing);
            this.Load += new System.EventHandler(this.FRF_Friengs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Friends)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Friends;
        private System.Windows.Forms.Button BUT_ADD;
        private System.Windows.Forms.Button BUT_DEL;
        private System.Windows.Forms.Button BTNrz;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.PrintPreviewDialog ppdfriend;
        private System.Windows.Forms.Button BTNxiugai;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_XM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTPBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_QQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_JG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_DZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_WX;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_XB;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_SJH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLA_PY;
    }
}