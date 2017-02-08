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
    public partial class FrmEditSinger : Form
    {
        public FrmEditSinger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 浏览功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWatching_Click(object sender, EventArgs e)
        {
            OpenFileDialog tb = new OpenFileDialog();
            if (tb.ShowDialog()==DialogResult.OK) //打开浏览器
            {
                string path = tb.FileName; //获取路径
                pictureBox1.Image = Image.FromFile(path); //显示选取的图片
            }
        }
    }
}
