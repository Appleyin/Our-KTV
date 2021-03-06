﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace KTV程序后台管理
{
    public partial class FrmSingerPath : Form
    {
        public FrmSingerPath()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSingerPath_Load(object sender, EventArgs e)
        {
          
            addData();
        }
        /// <summary>
        /// 显示原来的资源路径
        /// </summary>
        private void addData()
        {
            string sql = "select resource_path from resource_path where resource_type='Song'";
            SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
            try
            {
                DBHelper.OpenConnection();//打开数据库
                txtPath.Text = cmd.ExecuteScalar().ToString();//获取数据信息转换为string类型
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBHelper.ClosedConnection();//关闭数据库
            }
        }

        /// <summary>
        /// 浏览按钮点击事件
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
        /// 保存按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtNewPath.Text.Trim().Equals(string.Empty))
            {
                string newPath = txtNewPath.Text;
                string sql = string.Format("update  resource_path set resource_path='{0}' where resource_type='Song'", newPath);
                SqlCommand cmd = new SqlCommand(sql, DBHelper.Connection);
                try
                {
                    DBHelper.OpenConnection();
                    int a = cmd.ExecuteNonQuery();
                    if (a == 1)
                    {
                        Directory.Move(txtPath.Text,txtNewPath.Text);//移动文件里的内容到另一个文件
                        KTVUtil.singerphotoPath = txtNewPath.Text;
                        MessageBox.Show("修改成功！", "温馨提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "温馨提示");
                    }
                    addData();
                    txtNewPath.Text = "";
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
            else
            {
                MessageBox.Show("不能保存空的地址，请选择地址！", "温馨提示");
            }
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
    }
}
