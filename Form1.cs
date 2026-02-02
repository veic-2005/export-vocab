using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportVocab
{
    public partial class Form1 : Form
    {
        private MySqlConnection conn = new MySqlConnection();
        private DataTable table = new DataTable();
        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        private MySqlCommandBuilder sqlCmdBuilder = new MySqlCommandBuilder();
        // db name
        private string m_db = "mysql";
        private Dictionary<string, string> m_kbd = new Dictionary<string, string>();
        private List<Pinyin> m_kbdWord = new List<Pinyin>();

        // stackoverflow.com/a/39096892
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            string connStr = string.Format(
                "server={0}; user id={1}; password={2}; database={3}; pooling=false; Convert Zero Datetime=True",
                edtSrv.Text, edtUser.Text, edtPwd.Text, m_db);
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                // 获得数据库列表
                List<string> cmd = new List<string>();
                cmd.Add("SHOW DATABASES");
                List<string> list = getDataList(cmd);

                if (AllocConsole())
                {
                    Console.WriteLine("Connect Ok.");
                    Console.WriteLine("cmd: SHOW DATABASES.");
                    //FreeConsole();
                }

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

        private void btnMb_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> myWord;
            myWord = new Dictionary<int, string>();

            string strSql1 = "SELECT oem.sn,oem.letter FROM kbd_oem AS oem WHERE oem.name = 'ru'";
            string strSql2 = "SELECT az.key101,az.letter FROM kbd_az AS az WHERE az.name = 'ru'";
            string strSql3 = " UNION ALL ";
            string strSql = strSql1 + strSql3 + strSql2;
            string strTmp = "";
            string strTmp2 = "";

            if (conn.Ping())
            {
                m_db = "carnumber";
                conn.ChangeDatabase(m_db);
            }

            using (conn)
            {
                MySqlCommand command = new MySqlCommand(
                  "SELECT * FROM words2;",
                  conn);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        myWord.Add(reader.GetInt32(0), reader.GetString(2));
                    }
                }

                reader.Close();

                MySqlCommand command2 = new MySqlCommand(
                  strSql,
                  conn);

                MySqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        strTmp = itostr(reader2.GetString(0));
                        m_kbd.Add(reader2.GetString(1), strTmp);
                    }
                }

                reader2.Close();
            }

            int i = 1;

            foreach (var item in myWord)
            {
                strTmp2 = getDirionary(item.Value);
                if (!string.IsNullOrEmpty(strTmp2))
                {
                    m_kbdWord.Add(new Pinyin { AzStr = strTmp2, Letter = item.Value });
                    i++;
                }

            }
            foreach (var item in m_kbdWord)
            {
                System.Diagnostics.Debug.WriteLine(item.AzStr + "," + item.Letter);
            }
        }
        string itostr(string val)
        {
            string result = "";
            int iVal = 0;

            if (Int32.TryParse(val, out iVal))
            {
                val = "_" + val;
            }

            result = val;

            return result;
        }

        string getDirionary(string sub)
        {
            string result = "";

            char[] chSubs = sub.ToArray();

            foreach (char c in chSubs)
            {
                foreach (var kbd in m_kbd)
                {
                    char[] chKeys = kbd.Key.ToArray();
                    if (c.Equals(chKeys[0]))
                    {
                        result += m_kbd.GetValueOrDefault(kbd.Key);
                    }
                }

            }

            return result;
        }

        private void btn2d_Click(object sender, EventArgs e)
        {
            string strFmt = "{{ {0}, \"{1}\", \"{2}\" }},";

            printCol0hash(strFmt);
        }

        private void printCol0hash(string format)
        {
            int iHash = 0;

            if (conn.Ping())
            {
                m_db = "carnumber";
                conn.ChangeDatabase(m_db);
            }

            using (conn)
            {
                MySqlCommand command = new MySqlCommand(
                  "SELECT * FROM vocab_ru;",
                  conn);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        iHash = StrExt.StringExtension.GetStableHashCode(reader.GetString(0), 5229);

                        System.Diagnostics.Debug.WriteLine(
                            format,
                            iHash,
                            reader.GetString(0),
                            reader.GetString(1)
                            );
                    }
                }

                reader.Close();
            }
        }
    }
}
