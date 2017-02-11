namespace KTV程序后台管理
{
    partial class FrmEditSong
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.txtSongWord = new System.Windows.Forms.TextBox();
            this.txtSinger = new System.Windows.Forms.TextBox();
            this.txtSongTxtName = new System.Windows.Forms.TextBox();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnWatching = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌曲名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "拼音缩写：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(52, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "歌曲类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(52, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "歌手：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(52, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "歌曲文件名：";
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(151, 24);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(251, 25);
            this.txtSongName.TabIndex = 1;
            // 
            // txtSongWord
            // 
            this.txtSongWord.Location = new System.Drawing.Point(151, 69);
            this.txtSongWord.Name = "txtSongWord";
            this.txtSongWord.Size = new System.Drawing.Size(251, 25);
            this.txtSongWord.TabIndex = 2;
            // 
            // txtSinger
            // 
            this.txtSinger.Location = new System.Drawing.Point(151, 143);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(204, 25);
            this.txtSinger.TabIndex = 3;
            // 
            // txtSongTxtName
            // 
            this.txtSongTxtName.Location = new System.Drawing.Point(79, 234);
            this.txtSongTxtName.Name = "txtSongTxtName";
            this.txtSongTxtName.Size = new System.Drawing.Size(335, 25);
            this.txtSongTxtName.TabIndex = 4;
            // 
            // cboSongType
            // 
            this.cboSongType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.Location = new System.Drawing.Point(151, 108);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(232, 23);
            this.cboSongType.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(409, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 31);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnWatching
            // 
            this.btnWatching.Location = new System.Drawing.Point(393, 290);
            this.btnWatching.Name = "btnWatching";
            this.btnWatching.Size = new System.Drawing.Size(91, 30);
            this.btnWatching.TabIndex = 7;
            this.btnWatching.Text = "浏览";
            this.btnWatching.UseVisualStyleBackColor = true;
            this.btnWatching.Click += new System.EventHandler(this.btnWatching_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 364);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(461, 364);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(90, 28);
            this.btnCancle.TabIndex = 9;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(224, 365);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(79, 27);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "清空";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // FrmEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 481);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnWatching);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.txtSongTxtName);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.txtSongWord);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑歌曲信息";
            this.Load += new System.EventHandler(this.FrmEditSong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public  System.Windows.Forms.TextBox txtSongName;
        public System.Windows.Forms.TextBox txtSongWord;
        public System.Windows.Forms.TextBox txtSinger;
        public System.Windows.Forms.TextBox txtSongTxtName;
        public System.Windows.Forms.ComboBox cboSongType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnWatching;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btndelete;
    }
}