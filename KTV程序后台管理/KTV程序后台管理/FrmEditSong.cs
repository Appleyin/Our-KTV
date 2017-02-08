using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV程序后台管理
{
    public partial class FrmEditSong : Form
    {
        public FrmEditSong()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 浏览事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWatching_Click(object sender, EventArgs e)
        {
            DialogResult tb = folderBrowserDialog1.ShowDialog();//调用文件浏览器控件
            if (tb==System.Windows.Forms.DialogResult.OK)//判断文件浏览器控件是否返回
            {
                txtSongTxtName.Text = folderBrowserDialog1.SelectedPath;//获取浏览器中的地址
            }
        }
    }
}
