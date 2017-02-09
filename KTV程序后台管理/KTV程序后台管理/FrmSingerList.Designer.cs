namespace KTV程序后台管理
{
    partial class FrmSingerList
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
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.cboSingerType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singertypeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "歌手姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "歌手类型：";
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(100, 30);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(122, 25);
            this.txtSingerName.TabIndex = 1;
            // 
            // cboSingerType
            // 
            this.cboSingerType.FormattingEnabled = true;
            this.cboSingerType.Location = new System.Drawing.Point(334, 33);
            this.cboSingerType.Name = "cboSingerType";
            this.cboSingerType.Size = new System.Drawing.Size(116, 23);
            this.cboSingerType.TabIndex = 2;
            this.cboSingerType.SelectedIndexChanged += new System.EventHandler(this.cboSingerType_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(499, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerName,
            this.SingerType,
            this.SingerSex,
            this.SingerWord,
            this.singertypeid});
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 425);
            this.dataGridView1.TabIndex = 4;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "singer_name";
            this.SingerName.HeaderText = "歌手姓名";
            this.SingerName.Name = "SingerName";
            // 
            // SingerType
            // 
            this.SingerType.DataPropertyName = "singertype_name";
            this.SingerType.HeaderText = "歌手类别";
            this.SingerType.Name = "SingerType";
            // 
            // SingerSex
            // 
            this.SingerSex.DataPropertyName = "singer_sex";
            this.SingerSex.HeaderText = "歌手性别";
            this.SingerSex.Name = "SingerSex";
            // 
            // SingerWord
            // 
            this.SingerWord.DataPropertyName = "singer_word";
            this.SingerWord.HeaderText = "歌手描述";
            this.SingerWord.Name = "SingerWord";
            // 
            // singertypeid
            // 
            this.singertypeid.DataPropertyName = "singertype_id";
            this.singertypeid.HeaderText = "singertypeid";
            this.singertypeid.Name = "singertypeid";
            this.singertypeid.Visible = false;
            // 
            // FrmSingerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSingerType);
            this.Controls.Add(this.txtSingerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSingerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询歌手信息";
            this.Load += new System.EventHandler(this.FrmSingerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.ComboBox cboSingerType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn singertypeid;
    }
}