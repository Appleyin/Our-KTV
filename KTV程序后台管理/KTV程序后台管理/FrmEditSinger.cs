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
    public partial class FrmEditSinger : Form
    {
        public string path="";//歌手照片路径
        public string answer = "新增";//判断是新增歌手还是修改歌手
        public FrmSingerList singerlist;
        public string Sex="";//接受性别
        public int Sid;//接收歌手id
      
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
                 path = tb.FileName; //获取路径
                KTVUtil.singerphotoPath = path;//将路径传给KTVUtil辅助类
                pictureBox1.Image = Image.FromFile(path); //显示选取的图片
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmEditSinger_Load(object sender, EventArgs e)
        {
            BindSingerType();
            if (Sex == "男")
            {
                rdbBoy.Checked = true;
            }
            else if (Sex == "女")
            {
                rdbGril.Checked = true;
            }
            else if(Sex == "组合")
            {
                rdbGroup.Checked = true;
            }
        }

        /// <summary>
        /// 添加歌手类型
        /// </summary>
        private void BindSingerType()
        {
            string sql = "select singertype_id,singertype_name from singer_type";
            SqlDataAdapter adapter = new SqlDataAdapter(sql,DBHelper.Connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "singer_type");
            //添加请选择这一项
            DataRow row = ds.Tables["singer_type"].NewRow();
            row["singertype_id"] = -1;
            row["singertype_name"] = "请选择";
            ds.Tables["singer_type"].Rows.InsertAt(row,0);
            cboType.DataSource = ds.Tables["singer_type"];
            cboType.ValueMember = "singertype_id";
            cboType.DisplayMember = "singertype_name";
        }

        /// <summary>
        /// 取消按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Textinfo() && answer == "新增")
            {
                AddInfo();
            }
            else if (Textinfo() && answer == "修改")
            {
                reviseInfo();
            }
            else {
                MessageBox.Show("除歌手描述外，请输入完整信息！");
            }
        }

        /// <summary>
        /// 修改歌手信息
        /// </summary>
        private void reviseInfo()
        {
            string name = "";
            int id = (int)cboType.SelectedValue;
            if (rdbBoy.Checked)
            {
                name = "男";
            }
            if (rdbGril.Checked)
            {
                name = "女";
            }
            if (rdbGroup.Checked)
            {
                name = "组合";
            }
            string sql =string.Format(@"update singer_info set singer_name='{0}',singer_sex='{1}',singer_word='{2}',siinger_photo_url='{3},singertype_id='{4}''
                                         where singer_id='{5}'", txtName.Text,name,txtSingerWord.Text,path,id,Sid);
            try
            {
                DBHelper.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql,DBHelper.Connection);
                int result=cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("修改成功！");
                    DeleteInfo();
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
        /// 添加歌手
        /// </summary>
        private void AddInfo()
        {
            string name="";
            int id = (int)cboType.SelectedValue;
            if (rdbBoy.Checked)
            {
                 name = "男";
            }
            if (rdbGril.Checked)
            {
                name = "女";
            }
            if (rdbGroup.Checked)
            {
                name = "组合";
            }
            string sql =string.Format( "insert singer_info values('{0}','{1}','{2}','{3}','{4}')",txtName.Text,id,name,path,txtSingerWord.Text);
            try
            {
                DBHelper.OpenConnection();
                SqlCommand cmd = new SqlCommand(sql,DBHelper.Connection);
                int result =(int) cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("添加成功！");
                    DeleteInfo();
                }
                else {
                    MessageBox.Show("添加失败！");
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
        /// 检查文本框是否为空
        /// </summary>
        /// <returns></returns>
        private bool Textinfo()
        {
            bool isRight = true;
            if (txtName.Text.Trim() == null)
            {
                isRight = false;
            }
             if (rdbBoy.Checked||rdbGril.Checked||rdbGroup.Checked)
            {
                isRight = true;
            }
             if ((int)cboType.SelectedValue==-1) {
                isRight = false;
            }
            return isRight;
        }

        /// <summary>
        /// 单击清空事件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btndelete_Click(object sender, EventArgs e)
        {
            DeleteInfo();
        }

        /// <summary>
        /// 清空事件
        /// </summary>
        private void DeleteInfo()
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
                if (control is RadioButton)
                {
                    rdbBoy.Checked = true;
                }
                pictureBox1.Image = Properties.Resources._20151025155034_Xn8cx;

            }
        }
    }
}
