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
    public partial class FrmSongPath : Form
    {
        public FrmSongPath()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 保存按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Kong())
            {
              
                addPath();
            }
            else
            {
                MessageBox.Show("不能保存空的地址，请选择地址！","温馨提示");
            }
        }
       /// <summary>
       /// 保存数据
       /// </summary>
        private void addPath()
        {
            string newPath = lalNewPath.Text;
            string sql = string.Format("update  dbo.resource_path set resource_path='{0}' where resource_type='Song'",newPath);
            SqlCommand cmd = new SqlCommand(sql,DBHelper.Connection);
            try
            {
                DBHelper.OpenConnection();
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                    MessageBox.Show("修改成功！", "温馨提示");
                }
                else
                {
                    MessageBox.Show("修改失败！","温馨提示");
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
        /// 判断是否有新数据
        /// </summary>
        /// <returns></returns>
        private bool Kong()
        {
            bool flag = true;
            if (txtNewPath.Text.Trim().Equals(string.Empty))
            {
                flag = false;

            }


            return flag;
        }

        /// <summary>
        /// 取消按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 单击浏览按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLook_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog(); //是调用文件浏览器控件
            if (dr == System.Windows.Forms.DialogResult.OK) //是判断文件浏览器控件是否返回ok，即用户是否确定选择
            {
                txtNewPath.Text = folderBrowserDialog1.SelectedPath;//获取浏览器中的地址
            }
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongPath_Load(object sender, EventArgs e)
        {
            showLalPath();
        }
        /// <summary>
        /// 显示lal数据
        /// </summary>
        private void showLalPath()
        {
            string sql = "select resource_path from dbo.resource_path where resource_type='Song'";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
            try
            {
                DBHelper.OpenConnection();
                txtPath.Text = cmd.ExecuteScalar().ToString();
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
