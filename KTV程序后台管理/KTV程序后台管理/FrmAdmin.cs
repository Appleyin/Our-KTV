using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KTV程序后台管理
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }


        private void 新增歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditSinger editsinger = new KTV程序后台管理.FrmEditSinger();
            editsinger.MdiParent = this;
            editsinger.Show();
        }

        private void 查询歌手ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSingerList singerlist = new KTV程序后台管理.FrmSingerList();
            singerlist.MdiParent = this;
            singerlist.Show();
        }

        private void 新增歌曲ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditSong editsong = new KTV程序后台管理.FrmEditSong();
            editsong.MdiParent = this;
            editsong.Show();
        }

        private void 查询歌曲信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSongList songlist = new KTV程序后台管理.FrmSongList();
            songlist.MdiParent = this;
            songlist.Show();
        }

        private void 设置歌手照片路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhotoPath photo = new KTV程序后台管理.FrmPhotoPath();
            photo.MdiParent = this;
            photo.Show();
        }

        private void 设置歌曲路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSingerPath singerpath = new KTV程序后台管理.FrmSingerPath();
            singerpath.MdiParent = this;
            singerpath.Show();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new KTV程序后台管理.FrmAbout();
            about.MdiParent = this;
            about.Show();
        }
    }
}
