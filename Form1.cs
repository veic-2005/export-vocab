using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportVocab
{
    public partial class Form1 : Form
    {
        private MySqlConnection m_conn = new MySqlConnection();

        /// <summary>
        /// db info
        /// </summary>
        private string m_db = "";
        private string m_srv = "localhost";
        private string m_usr = "DBAdmin";
        private string m_pwd = "";
        private string m_connStr = "";
        private string m_sql = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            m_srv = edtSrv.Text;
            m_usr = edtUser.Text;
            m_pwd = edtPwd.Text;
            m_db = "carnumber";

            m_connStr = string.Format(
                "server={0}; user id={1}; password={2}; database={3}; " +
                "pooling=false; Convert Zero Datetime=True",
                m_srv, m_usr, m_pwd, m_db);

            WinConsole.Initialize(false);

            cBoxTables.Items.Add("Temp Table 1");
            cBoxTables.Items.Add("Temp Table 2");
        }

        private void cBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSql1 = "SELECT oem.letter,oem.sn FROM kbd_oem AS oem WHERE oem.name = 'ru'";
            string strSql2 = "SELECT az.letter,az.key101 FROM kbd_az AS az WHERE az.name = 'ru'";
            string strSql3 = " UNION ALL ";
            string strSql = strSql1 + strSql3 + strSql2;

            string strSqlWord = "SELECT id, bare FROM words2;";

            if (cBoxTables.SelectedIndex == 0)
            {
                m_sql = strSqlWord;
            }
            else
            {
                m_sql = strSql;
            }

            if (isConnect(m_connStr, m_db))
            {
                SetDataSource(m_sql, m_conn);
            }
        }

        private void SetDataSource(string sql, MySqlConnection conn)
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            MySqlCommandBuilder sqlCmdBuilder = new MySqlCommandBuilder();
            DataSet ds = new DataSet();

            using (conn)
            {
                // 设置数据桥
                dataAdapter = new MySqlDataAdapter(sql, conn);

                // get 数据
                sqlCmdBuilder = new MySqlCommandBuilder(dataAdapter);

                // 填充数据到DataSet
                dataAdapter.Fill(ds);

                // 指定数据源
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnMb_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> myWord = null;
            Dictionary<string, string> myKbd = null;
            List<Pinyin> myKbdWord = new List<Pinyin>();

            string strSql1 = "SELECT oem.letter,oem.sn FROM kbd_oem AS oem WHERE oem.name = 'ru'";
            string strSql2 = "SELECT az.letter,az.key101 FROM kbd_az AS az WHERE az.name = 'ru'";
            string strSql3 = " UNION ALL ";
            string strSql = strSql1 + strSql3 + strSql2;

            string strSqlWord = "SELECT id, bare FROM words2;";
            string strTmp2 = "";

            m_db = "carnumber";
            if (isConnect(m_connStr, m_db))
            {
                myWord = new Dictionary<int, string>(
                    (IDictionary<int, string>)GetDictionaryData(m_conn, strSqlWord, true));
				Console.WriteLine("db: " + m_db);
            }

            if (isConnect(m_connStr, m_db))
            {
                myKbd = new Dictionary<string, string>(
                    (IDictionary<string, string>)GetDictionaryData(m_conn, strSql, false));
				Console.WriteLine("table: cross");
            }

            foreach (var item in myWord)
            {
                strTmp2 = getDirionary(item.Value, myKbd);
                if (!string.IsNullOrEmpty(strTmp2))
                {
                    myKbdWord.Add(new Pinyin { AzStr = strTmp2, Letter = item.Value });
                }

            }

            foreach (var item in myKbdWord)
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

        string getDirionary(string sub, Dictionary<string, string> inKdb)
        {
            string result = "";

            char[] chSubs = sub.ToArray();

            foreach (char c in chSubs)
            {
                foreach (var kbd in inKdb)
                {
                    char[] chKeys = kbd.Key.ToArray();
                    if (c.Equals(chKeys[0]))
                    {
                        // fx
                        ////result += inKdb.TryGetValue(kbd.Key, out var value) ? value : null;
                        // .net core
                        result += inKdb.GetValueOrDefault(kbd.Key);
                    }
                }

            }

            return result;
        }

        private void btn2d_Click(object sender, EventArgs e)
        {
            string strFmt = "{{ {0}, \"{1}\", \"{2}\" }},";
            m_db = "carnumber";

            printCol0hash(strFmt);
        }

        private void printCol0hash(string format)
        {
            int iHash = 0;

            if (isConnect(m_connStr, m_db))
            {
				Console.WriteLine("DB: " + m_db);
                using (m_conn)
                {
                    MySqlCommand command = new MySqlCommand(
                      "SELECT * FROM vocab_ru;",
                      m_conn);

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

        private bool isConnect(string strConn, string db)
        {
            bool bSuccess = false;

            try
            {
                m_conn = new MySqlConnection(strConn);
                m_conn.Open();

                m_conn.ChangeDatabase(db);

                bSuccess = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            return bSuccess;
        }

        private IDictionary GetDictionaryData(MySqlConnection conn, string sql, bool isNumOfKey)
        {
            IDictionary result = null;
            var key = (dynamic) null;

            if (isNumOfKey)
            {
                result = new Dictionary<int, string>();
            }
            else
            {
                result = new Dictionary<string, string>();
            }

            using (conn)
            {
                MySqlCommand command = new MySqlCommand(
                    sql,
                    conn);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (isNumOfKey)
                        {
                            key = reader.GetInt32(0);
                        }
                        else
                        {
                            key = itostr(reader.GetString(0));
                        }

                        result.Add(key, reader.GetString(1));
                    }
                }

                reader.Close();
            }

            return result;
        }

    }
}
