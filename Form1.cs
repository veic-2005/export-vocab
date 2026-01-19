using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExportVocab
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn = new MySqlConnection();
        private DataTable table = new DataTable();
        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        private MySqlCommandBuilder sqlCmdBuilder = new MySqlCommandBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            //
            string connStr = string.Format(
                "server={0}; user id={1}; password={2}; database=mysql; pooling=false; Convert Zero Datetime=True",
                edtSrv.Text, edtUser.Text, edtPwd.Text);
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                // 获得数据库列表
                List<string> cmd = new List<string>();
                cmd.Add("SHOW DATABASES");
                List<string> list = getDataList(cmd);

                // 清空下拉框
                cBoxDBs.Items.Clear();
                // 增加下拉框列表
                foreach (string str in list)
                    cBoxDBs.Items.Add(str);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("没有找到数据库: " + ex.Message);
            }
        }

        private List<string> getDataList(List<string> cmdList)
        {
            List<string> result = new List<string>();

            // SQL数据读取器
            MySqlDataReader dataReader = null;

            // SQL命令执行器
            MySqlCommand sqlCmd = new MySqlCommand();

            // 设置SQL命令执行器的连接
            sqlCmd.Connection = conn;

            try
            {
                // 执行的SQL命令
                foreach (string cmd in cmdList)
                {
                    sqlCmd.CommandText = cmd;
                    sqlCmd.ExecuteNonQuery();
                }
                //   
                dataReader = sqlCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    string strDbName = dataReader.GetString(0);

                    result.Add(strDbName);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("读取数据失败: " + ex.Message);
            }
            finally
            {
                if (dataReader != null)
                    dataReader.Close();
            }
            return result;
        }

        private void cBoxDBs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获得数据库列表
            List<string> cmdList = new List<string>();
            cmdList.Add("USE " + cBoxDBs.SelectedItem.ToString());
            cmdList.Add("SHOW TABLES");
            List<string> list = getDataList(cmdList);

            // 清空数据库列表
            cBoxTables.Items.Clear();
            // 增加下拉框列表
            foreach (string str in list)
                cBoxTables.Items.Add(str);
        }

        private void cBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 获得数据表名称
            string tableName = cBoxTables.SelectedItem.ToString();
            // 设置数据桥
            dataAdapter = new MySqlDataAdapter("Select * from " + tableName, conn);

            // DataSet
            sqlCmdBuilder = new MySqlCommandBuilder(dataAdapter);
            // 建立数据表
            table = new DataTable(tableName);
            // 填充数据表到数据桥
            dataAdapter.Fill(table);

            // 指定数据源
            dataGridView1.DataSource = table;
        }
    }
}
