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
        public  int singerytpeid;//全局变量
        public  string singername;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("select singer_name,singertype_name,singer_sex,singer_word,t.singertype_id from singer_info i,singer_type t where i.singertype_id=t.singertype_id");
            int id = (int)cboSingerType.SelectedValue;//获取歌手类型id
            if (id>0)
            {
                sb.AppendLine(" and i.singer_name like '%"+txtSingerName.Text+"%' and t.singertype_name='"+cboSingerType.Text+"'");
            }
            SqlDataAdapter adapter = new SqlDataAdapter(sb.ToString(),DBHelper.Connection);
            DataSet ds = new DataSet();
           
            if (ds.Tables["AS"]!=null)
            {
                ds.Tables["AS"].Clear();
            }
            adapter.Fill(ds, "AS");
            dataGridView1.DataSource = ds.Tables["AS"];
            singerytpeid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["singertypeid"].Value);
            singername = Convert.ToString(dataGridView1.SelectedRows[0].Cells["SingerName"].Value);
        }

        /// <summary>
        /// 当歌手类型为全部时，不需要显示歌手名字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboSingerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSingerType.SelectedIndex == 0)
            {
                txtSingerName.Enabled = false;
            }
            else
            {
                txtSingerName.Enabled = true;
            }
        }
    }
}
