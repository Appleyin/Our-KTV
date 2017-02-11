namespace KTV程序后台管理
{
    partial class FrmEditSinger
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdbBoy = new System.Windows.Forms.RadioButton();
            this.rdbGril = new System.Windows.Forms.RadioButton();
            this.rdbGroup = new System.Windows.Forms.RadioButton();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtSingerWord = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnWatching = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaths = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "歌手类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "歌手描述：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 25);
            this.txtName.TabIndex = 1;
            // 
            // rdbBoy
            // 
            this.rdbBoy.AutoSize = true;
            this.rdbBoy.Location = new System.Drawing.Point(123, 100);
            this.rdbBoy.Name = "rdbBoy";
            this.rdbBoy.Size = new System.Drawing.Size(43, 19);
            this.rdbBoy.TabIndex = 2;
            this.rdbBoy.Text = "男";
            this.rdbBoy.UseVisualStyleBackColor = true;
            // 
            // rdbGril
            // 
            this.rdbGril.AutoSize = true;
            this.rdbGril.Location = new System.Drawing.Point(183, 100);
            this.rdbGril.Name = "rdbGril";
            this.rdbGril.Size = new System.Drawing.Size(43, 19);
            this.rdbGril.TabIndex = 2;
            this.rdbGril.Text = "女";
            this.rdbGril.UseVisualStyleBackColor = true;
            // 
            // rdbGroup
            // 
            this.rdbGroup.AutoSize = true;
            this.rdbGroup.Location = new System.Drawing.Point(232, 100);
            this.rdbGroup.Name = "rdbGroup";
            this.rdbGroup.Size = new System.Drawing.Size(58, 19);
            this.rdbGroup.TabIndex = 2;
            this.rdbGroup.Text = "组合";
            this.rdbGroup.UseVisualStyleBackColor = true;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(123, 158);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 23);
            this.cboType.TabIndex = 3;
            // 
            // txtSingerWord
            // 
            this.txtSingerWord.Location = new System.Drawing.Point(123, 242);
            this.txtSingerWord.Multiline = true;
            this.txtSingerWord.Name = "txtSingerWord";
            this.txtSingerWord.Size = new System.Drawing.Size(238, 128);
            this.txtSingerWord.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(211, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 27);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(349, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "取消";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnWatching
            // 
            this.btnWatching.Location = new System.Drawing.Point(368, 150);
            this.btnWatching.Name = "btnWatching";
            this.btnWatching.Size = new System.Drawing.Size(80, 31);
            this.btnWatching.TabIndex = 8;
            this.btnWatching.Text = "浏览";
            this.btnWatching.UseVisualStyleBackColor = true;
            this.btnWatching.Click += new System.EventHandler(this.btnWatching_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(87, 396);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(79, 27);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "清空";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KTV程序后台管理.Properties.Resources._20151025155034_Xn8cx;
            this.pictureBox1.Location = new System.Drawing.Point(368, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "图片路径：";
            // 
            // txtPaths
            // 
            this.txtPaths.Location = new System.Drawing.Point(123, 201);
            this.txtPaths.Name = "txtPaths";
            this.txtPaths.ReadOnly = true;
            this.txtPaths.Size = new System.Drawing.Size(261, 25);
            this.txtPaths.TabIndex = 12;
            // 
            // FrmEditSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 481);
            this.Controls.Add(this.txtPaths);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWatching);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSingerWord);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.rdbGroup);
            this.Controls.Add(this.rdbGril);
            this.Controls.Add(this.rdbBoy);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditSinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌手信息";
            this.Load += new System.EventHandler(this.FrmEditSinger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public  System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.RadioButton rdbBoy;
        public System.Windows.Forms.RadioButton rdbGril;
        public System.Windows.Forms.RadioButton rdbGroup;
        public System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.TextBox txtSingerWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnWatching;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label5;
        public  System.Windows.Forms.TextBox txtPaths;
    }
}