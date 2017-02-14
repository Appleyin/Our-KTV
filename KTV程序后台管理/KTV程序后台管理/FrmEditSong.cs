using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace KTV程序后台管理
{
    public partial class FrmEditSong : Form
    {
        public int singertypeids;//歌手类型编号
        public int singerid;//歌手编号
        public int songsid;//歌曲序号
        public  string Rights = "新增";//判断是修改还是新增
        public FrmSongList songlist;
      
        public FrmEditSong()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (TextInfo()&&Rights=="新增")
            {               
                AddInfo();
            }
            else if(TextInfo() && Rights == "修改")
            {
                ReviseInfo();
            }
            else
            {
                MessageBox.Show("请输入完整信息！");
            }
        }

        /// <summary>
        /// 修改信息
        /// </summary>
        private void ReviseInfo()
        {
            int sum = txtSongName.Text.Trim().Length;
            int id = (int)cboSongType.SelectedValue;
            string paths = txtSongTxtName.Text.Substring(txtSongTxtName.Text.LastIndexOf("\\") + 1);//取文件后缀名
            string sql =string.Format(@"update song_info set song_name='{0}',song_ab='{1}',song_word_count='{2}',songtype_id='{3}',singer_id='{4}',song_url='{5}'
                                        where song_id='{6}'",txtSongName.Text,txtSongWord.Text,sum,id, singerid,paths, songsid);
            try
            {
                DBHelper.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql,DBHelper.Connection);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("修改成功！");
                   // File.Copy(txtSongTxtName.Text,KTVUtil.songPath + paths);
                    deleteinfo();
                }
                else {
                    MessageBox.Show("修改失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                DBHelper.ClosedConnection();
            }
        }

        /// <summary>
        /// 添加歌曲数据
        /// </summary>
        private void AddInfo()
        {
            int sum = txtSongName.Text.Trim().Length;//获取歌曲名字长度
            int id = (int)cboSongType.SelectedValue;//获取歌曲类型id
            string paths = txtSongTxtName.Text.Substring(txtSongTxtName.Text.LastIndexOf("\\") + 1);//取文件后缀名
            string sql = string.Format("insert song_info values('{0}','{1}','{2}','{3}','{4}','{5}','')",txtSongName.Text, txtSongWord.Text, sum, id, singertypeids,paths);
            try
            {
                DBHelper.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
                int result = (int)cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("添加成功！");
                    deleteinfo();
                }

                else
                {
                    MessageBox.Show("添加失败！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.ClosedConnection();
            }
        }

        /// <summary>
        /// 检查文本框是否为空
        /// </summary>
        /// <returns></returns>
        private bool TextInfo()
        {
            bool isRight = true;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == null)
                    {
                        isRight = false;
                    }
                }
                if (control is ComboBox)
                {
                    if (control.Text == "请选择")
                    {
                        isRight = false;
                    }
                }
            }
            return isRight;
        }

        /// <summary>
        /// 浏览事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWatching_Click(object sender, EventArgs e)
        {

            OpenFileDialog tb = new OpenFileDialog();
            if (tb.ShowDialog() == DialogResult.OK) //打开浏览器
            {
                txtSongTxtName.Text = tb.FileName; //获取路径              
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditSong_Load(object sender, EventArgs e)
        {
          
            Bindsongtype();
        }

        /// <summary>
        /// 展示歌曲类型
        /// </summary>
        private void Bindsongtype()
        {
            string sql = "select songtype_id,songtype_name from song_type";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DBHelper.Connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "song_type");
            //添加请选择这一项
            DataRow row = ds.Tables["song_type"].NewRow();
            row["songtype_id"] = -1;
            row["songtype_name"] = "请选择";
            ds.Tables["song_type"].Rows.InsertAt(row, 0);
            cboSongType.DataSource = ds.Tables["song_type"];
            cboSongType.ValueMember = "songtype_id";
            cboSongType.DisplayMember = "songtype_name";
        }

        /// <summary>
        /// 取消事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查询歌手方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
          
            FrmSingerList message = new FrmSingerList();
            message.answer = "查询";
            message.song = this;
            message.Show();
        }

        /// <summary>
        /// 单击清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            deleteinfo();
        }

        /// <summary>
        /// 清空事件
        /// </summary>
        private void deleteinfo()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    control.Text = "请选择";
                }
            }
        }
    }
}
