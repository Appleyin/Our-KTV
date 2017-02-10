namespace KTV程序后台管理
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.歌手管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增歌手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询歌手ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌曲管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询歌曲信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置资源路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置歌手照片路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置歌曲路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.歌手管理ToolStripMenuItem,
            this.歌曲管理ToolStripMenuItem,
            this.设置资源路径ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(803, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 歌手管理ToolStripMenuItem
            // 
            this.歌手管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增歌手ToolStripMenuItem,
            this.查询歌手ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.退出ToolStripMenuItem});
            this.歌手管理ToolStripMenuItem.Name = "歌手管理ToolStripMenuItem";
            this.歌手管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.歌手管理ToolStripMenuItem.Text = "歌手管理";
            // 
            // 新增歌手ToolStripMenuItem
            // 
            this.新增歌手ToolStripMenuItem.Name = "新增歌手ToolStripMenuItem";
            this.新增歌手ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.新增歌手ToolStripMenuItem.Text = "新增歌手";
            this.新增歌手ToolStripMenuItem.Click += new System.EventHandler(this.新增歌手ToolStripMenuItem_Click);
            // 
            // 查询歌手ToolStripMenuItem
            // 
            this.查询歌手ToolStripMenuItem.Name = "查询歌手ToolStripMenuItem";
            this.查询歌手ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.查询歌手ToolStripMenuItem.Text = "查询歌手";
            this.查询歌手ToolStripMenuItem.Click += new System.EventHandler(this.查询歌手ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 歌曲管理ToolStripMenuItem
            // 
            this.歌曲管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增歌曲ToolStripMenuItem,
            this.查询歌曲信息ToolStripMenuItem});
            this.歌曲管理ToolStripMenuItem.Name = "歌曲管理ToolStripMenuItem";
            this.歌曲管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.歌曲管理ToolStripMenuItem.Text = "歌曲管理";
            // 
            // 新增歌曲ToolStripMenuItem
            // 
            this.新增歌曲ToolStripMenuItem.Name = "新增歌曲ToolStripMenuItem";
            this.新增歌曲ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.新增歌曲ToolStripMenuItem.Text = "新增歌曲";
            this.新增歌曲ToolStripMenuItem.Click += new System.EventHandler(this.新增歌曲ToolStripMenuItem_Click);
            // 
            // 查询歌曲信息ToolStripMenuItem
            // 
            this.查询歌曲信息ToolStripMenuItem.Name = "查询歌曲信息ToolStripMenuItem";
            this.查询歌曲信息ToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.查询歌曲信息ToolStripMenuItem.Text = "查询歌曲信息";
            this.查询歌曲信息ToolStripMenuItem.Click += new System.EventHandler(this.查询歌曲信息ToolStripMenuItem_Click);
            // 
            // 设置资源路径ToolStripMenuItem
            // 
            this.设置资源路径ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置歌手照片路径ToolStripMenuItem,
            this.设置歌曲路径ToolStripMenuItem});
            this.设置资源路径ToolStripMenuItem.Name = "设置资源路径ToolStripMenuItem";
            this.设置资源路径ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.设置资源路径ToolStripMenuItem.Text = "设置资源路径";
            // 
            // 设置歌手照片路径ToolStripMenuItem
            // 
            this.设置歌手照片路径ToolStripMenuItem.Name = "设置歌手照片路径ToolStripMenuItem";
            this.设置歌手照片路径ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.设置歌手照片路径ToolStripMenuItem.Text = "设置歌手照片路径";
            this.设置歌手照片路径ToolStripMenuItem.Click += new System.EventHandler(this.设置歌手照片路径ToolStripMenuItem_Click);
            // 
            // 设置歌曲路径ToolStripMenuItem
            // 
            this.设置歌曲路径ToolStripMenuItem.Name = "设置歌曲路径ToolStripMenuItem";
            this.设置歌曲路径ToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.设置歌曲路径ToolStripMenuItem.Text = "设置歌曲路径";
            this.设置歌曲路径ToolStripMenuItem.Click += new System.EventHandler(this.设置歌曲路径ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(178, 6);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 481);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV后台管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 歌手管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增歌手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询歌手ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌曲管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增歌曲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询歌曲信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置资源路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置歌手照片路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置歌曲路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}