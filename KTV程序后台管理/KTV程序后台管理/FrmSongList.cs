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
            string sql = string.Format(@"select song_name,t.songtype_name,i.song_play_count,t.songtype_id 
                                                           from dbo.song_info i,dbo.song_type t 
                                                           where t.songtype_id=i.songtype_id");
            sda = new SqlDataAdapter(sql,DBHelper.Connection);
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

      
    }
}
