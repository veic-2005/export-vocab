using MySql.Data.MySqlClient;
using System.Data;


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
                "server={0}; user id={1}; password={2}; database={3}; pooling=false; Convert Zero Datetime=True",
                m_srv, m_usr, m_pwd, m_db);

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
                dataAdapter = new MySqlDataAdapter(m_sql, conn);

                // get 数据
                sqlCmdBuilder = new MySqlCommandBuilder(dataAdapter);

                // 填充数据到DataSet
                dataAdapter.Fill(ds);

                // 指定数据源
                dataGridView1.DataSource = ds.Tables[0];
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
    }
}
