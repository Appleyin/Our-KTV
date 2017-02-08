namespace KTV程序后台管理
{
    partial class FrmSongPath
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lalNewPath = new System.Windows.Forms.Label();
            this.lalPath = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(585, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(435, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "保存";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(152, 171);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(82, 30);
            this.btnLook.TabIndex = 9;
            this.btnLook.Text = "浏览";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // txtNewPath
            // 
            this.txtNewPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPath.Location = new System.Drawing.Point(152, 115);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.Size = new System.Drawing.Size(526, 25);
            this.txtNewPath.TabIndex = 5;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(152, 42);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(526, 25);
            this.txtPath.TabIndex = 6;
            // 
            // lalNewPath
            // 
            this.lalNewPath.AutoSize = true;
            this.lalNewPath.Location = new System.Drawing.Point(87, 118);
            this.lalNewPath.Name = "lalNewPath";
            this.lalNewPath.Size = new System.Drawing.Size(67, 15);
            this.lalNewPath.TabIndex = 3;
            this.lalNewPath.Text = "新路径：";
            // 
            // lalPath
            // 
            this.lalPath.AutoSize = true;
            this.lalPath.Location = new System.Drawing.Point(72, 45);
            this.lalPath.Name = "lalPath";
            this.lalPath.Size = new System.Drawing.Size(82, 15);
            this.lalPath.TabIndex = 4;
            this.lalPath.Text = "当前路径：";
            // 
            // FrmSongPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 307);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lalNewPath);
            this.Controls.Add(this.lalPath);
            this.Name = "FrmSongPath";
            this.Text = "设置歌曲路径";
            this.Load += new System.EventHandler(this.FrmSongPath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lalNewPath;
        private System.Windows.Forms.Label lalPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}