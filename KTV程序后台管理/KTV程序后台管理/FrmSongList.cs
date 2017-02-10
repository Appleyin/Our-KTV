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
    public partial class FrmSongList : Form
    {
      
        public FrmSongList()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        DataSet ds;
        DataView dv;
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            addData();
            addDataGir();
        }
        /// <summary>
        /// 绑定data表里的信息
        /// </summary>
        private void addDataGir()
        {
            string sql = string.Format(@"select i.song_id,i.song_ab,i.singer_id,i.song_url,song_name,t.songtype_name,i.song_play_count,t.songtype_id,f.singer_name
                                                           from dbo.song_info i,dbo.song_type t,singer_info f
                                                           where t.songtype_id=i.songtype_id and i.singer_id=f.singer_id");
            sda = new SqlDataAdapter(sql,DBHelper.Connection);
            if (ds.Tables["shuju"]!=null)
            {
                ds.Tables["shuju"].Clear();
            }
            sda.Fill(ds,"shuju");
            dataGridView1.DataSource = ds.Tables["shuju"];
        }

        /// <summary>
        /// 绑定combox数据
        /// </summary>
        private void addData()
        {
            string sql = "select songtype_id,songtype_name from dbo.song_type";
            sda = new SqlDataAdapter(sql,DBHelper.Connection);
            ds = new DataSet();
            sda.Fill(ds,"data");
            cobType.DataSource = ds.Tables["data"];
            cobType.ValueMember = "songtype_id";
            cobType.DisplayMember = "songtype_name";
        }
        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            dv = new DataView(ds.Tables["shuju"]);
            if (txtName.Text.Trim().Equals(string.Empty)&&!cobType.Text.Equals(string.Empty))
            {
                int a=(int)cobType.SelectedValue;
                dv.RowFilter= string.Format("songtype_id={0}",a);
                dataGridView1.DataSource = dv;
            }
            else if (!txtName.Text.Trim().Equals(string.Empty)&&cobType.Text.Equals(string.Empty))
            {
               string name= txtName.Text;
                dv.RowFilter = string.Format("song_name like'%{0}%'", name);
                dataGridView1.DataSource = dv;

            }
            else if (!txtName.Text.Trim().Equals(string.Empty) && !cobType.Text.Equals(string.Empty))
            {
                string name = txtName.Text;
                int a = (int)cobType.SelectedValue;
                dv.RowFilter = string.Format("song_name like'%{0}%' and songtype_id={1}", name,a);
                dataGridView1.DataSource = dv;
            }
        }

        /// <summary>
        /// 单击快捷删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                isDelete();
            }
        }

        /// <summary>
        /// 删除事件
        /// </summary>
        public void isDelete() {
            int songid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column6"].Value);
            string sql = "delete song_info where song_id='" + songid + "'";
            try
            {
                DBHelper.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                addDataGir();
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
        /// 单击修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditSong editsong = new FrmEditSong();
            editsong.songlist = this;
            editsong.Show();
            editsong.Rights = "修改";
            editsong.txtSongName.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Column1"].Value);
            editsong.txtSongWord.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Column4"].Value);
            editsong.cboSongType.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Column2"].Value);
            editsong.txtSinger.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Column8"].Value);
            editsong.txtSongTxtName.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["Column7"].Value);
            editsong.songsid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column6"].Value);
            editsong.singerid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Column9"].Value);
            this.Hide();
        }

    }
}
