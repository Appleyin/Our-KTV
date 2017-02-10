using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KTV程序后台管理
{
    public partial class FrmSingerList : Form
    {
        public FrmEditSong song;

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public string answer = "";
        public FrmSingerList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSingerList_Load(object sender, EventArgs e)
        {
            
            SingerTypeInfo();      
        }

        /// <summary>
        /// 传数据
        /// </summary>
        public void TextInfo()
        {
            if (answer == "查询")
            {
                if (dataGridView1.RowCount > 0)
                {
                    song.singertypeids = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["singerid"].Value);
                    song.txtSinger.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["SingerName"].Value);
                }
            }

        }


        /// <summary>
        /// 歌手类型添加
        /// </summary>
        private void SingerTypeInfo()
        {
            string sql = "select singertype_id,singertype_name from singer_type";
            adapter = new SqlDataAdapter(sql, DBHelper.Connection);
             ds = new DataSet();
            adapter.Fill(ds, "singer_type");
            //添加请选择这一项
            DataRow row = ds.Tables["singer_type"].NewRow();
            row["singertype_id"] = -1;
            row["singertype_name"] = "全部";
            ds.Tables["singer_type"].Rows.InsertAt(row, 0);
            cboSingerType.DataSource = ds.Tables["singer_type"];
            cboSingerType.ValueMember = "singertype_id";
            cboSingerType.DisplayMember = "singertype_name";
        }

        /// <summary>
        /// 单击查询按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnSearch_Click(object sender, EventArgs e)
        {
            Info();
        }

        /// <summary>
        /// 查询数据后绑定
        /// </summary>
        public void Info() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select i.singer_id,singer_name,singertype_name,singer_sex,singer_word,siinger_photo_url from singer_info i,singer_type t where i.singertype_id=t.singertype_id");
            int id = (int)cboSingerType.SelectedValue;//获取歌手类型id
            if (id > 0)
            {
                sb.AppendLine(" and i.singer_name like '%" + txtSingerName.Text + "%' and t.singertype_name='" + cboSingerType.Text + "'");
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sb.ToString(), DBHelper.Connection);
            DataSet ds = new DataSet();

            if (ds.Tables["AS"] != null)
            {
                ds.Tables["AS"].Clear();
            }
            adapter.Fill(ds, "AS");
            dataGridView1.DataSource = ds.Tables["AS"];
            TextInfo();
        }

        /// <summary>
        /// 当歌手类型为全部时，不需要显示歌手名字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSingerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSingerType.SelectedIndex==0)
            {
                txtSingerName.Enabled = false;
            }
            else
            {
                txtSingerName.Enabled = true;
            }
        }

        /// <summary>
        /// 赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextInfo();
        }

        /// <summary>
        /// 歌手修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditSinger editsinger = new FrmEditSinger();
            editsinger.singerlist = this;
            this.Hide();
            editsinger.Show();
            editsinger.txtName.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["SingerName"].Value);
            editsinger.txtSingerWord.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells["SingerWord"].Value);
            editsinger.cboType.Text= Convert.ToString(dataGridView1.SelectedRows[0].Cells["SingerType"].Value);
            editsinger.Sid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["singerid"].Value);
            editsinger.Sex= Convert.ToString(dataGridView1.SelectedRows[0].Cells["SingerSex"].Value);
            if (editsinger.Sex == "男")
            {
                editsinger.rdbBoy.Checked = true;
            }
            else if (editsinger.Sex == "女")
            {
                editsinger.rdbGril.Checked = true;
            }
            else if(editsinger.Sex == "组合")
            {
                editsinger.rdbGroup.Checked = true;
            }
           // editsinger.pictureBox1.Image= Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);

        }

        /// <summary>
        /// 单击歌手删除事件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否删除？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result==DialogResult.Yes)
            {
                isDelete();
            }
        }

        /// <summary>
        /// 删除事件
        /// </summary>
        public void isDelete() {
            int singerid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["singerid"].Value);
            string sql = "delete song_info where singer_id='" + singerid + "'";
            try
            {
                DBHelper.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
                cmd.ExecuteNonQuery();
                //删主表数据
                sql = "delete singer_info where singer_id='" + singerid + "'";
                cmd.CommandText = sql;
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
                Info();
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

    }
}
