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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登录按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Kong())
            {
                Yanzheng();//验证登录信息
            }
            else
            {
                MessageBox.Show("账户密码不能为空！", "温馨提示");
            }
        }
        /// <summary>
        /// 验证登录信息方法
        /// </summary>
        private void Yanzheng()
        {
            string name = txtName.Text;
            string pwd = txtPwd.Text;
            string sql = string.Format("select COUNT(*) from dbo.admin_info where admin_name='{0}' and admin_pwd='{1}'", name, pwd);
            SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
            try
            {
                DBHelper.OpenConnection();
                int a = (int)cmd.ExecuteScalar();
                if (a == 1)
                {
                    MessageBox.Show("登录成功！","温馨提示");
                    
                    FrmAdmin frm = new FrmAdmin();
                    frm.Show();
                    this.Hide();
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
        /// 判断非空
        /// </summary>
        /// <returns></returns>
        private bool Kong()
        {
            bool flag = true;
            if (txtName.Text.Trim().Equals(string.Empty))
            {
                flag = false;
                txtName.Focus();
            }
            else if (txtPwd.Text.Trim().Equals(string.Empty))
            {
                flag = false;
                txtPwd.Focus();
            }

            return flag;
        }
        /// <summary>
        /// 取消按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
