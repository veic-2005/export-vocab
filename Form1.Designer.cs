namespace ExportVocab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnConn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            edtUser = new TextBox();
            edtSrv = new TextBox();
            edtPwd = new TextBox();
            cBoxTables = new ComboBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btn2d = new Button();
            btnMb = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConn);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(edtUser);
            groupBox1.Controls.Add(edtSrv);
            groupBox1.Controls.Add(edtPwd);
            groupBox1.Location = new Point(28, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 211);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "连接服务器";
            // 
            // btnConn
            // 
            btnConn.Location = new Point(105, 185);
            btnConn.Name = "btnConn";
            btnConn.Size = new Size(188, 20);
            btnConn.TabIndex = 12;
            btnConn.Text = "连接";
            btnConn.UseVisualStyleBackColor = true;
            btnConn.Click += btnConn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 141);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 9;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 89);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 8;
            label2.Text = "User:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 35);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "Server(IP):";
            // 
            // edtUser
            // 
            edtUser.Location = new Point(105, 86);
            edtUser.Name = "edtUser";
            edtUser.Size = new Size(188, 23);
            edtUser.TabIndex = 2;
            // 
            // edtSrv
            // 
            edtSrv.Location = new Point(105, 33);
            edtSrv.Name = "edtSrv";
            edtSrv.Size = new Size(188, 23);
            edtSrv.TabIndex = 1;
            edtSrv.Text = "127.0.0.1";
            // 
            // edtPwd
            // 
            edtPwd.Location = new Point(105, 139);
            edtPwd.Name = "edtPwd";
            edtPwd.PasswordChar = '*';
            edtPwd.Size = new Size(188, 23);
            edtPwd.TabIndex = 3;
            // 
            // cBoxTables
            // 
            cBoxTables.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxTables.FormattingEnabled = true;
            cBoxTables.Location = new Point(421, 20);
            cBoxTables.Name = "cBoxTables";
            cBoxTables.Size = new Size(126, 23);
            cBoxTables.TabIndex = 5;
            cBoxTables.SelectedIndexChanged += cBoxTables_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(376, 323);
            dataGridView1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(366, 23);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 11;
            label5.Text = "Temp表";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn2d);
            groupBox2.Controls.Add(btnMb);
            groupBox2.Location = new Point(28, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 130);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Export Word";
            // 
            // btn2d
            // 
            btn2d.Location = new Point(180, 47);
            btn2d.Name = "btn2d";
            btn2d.Size = new Size(113, 23);
            btn2d.TabIndex = 1;
            btn2d.Text = "Two-dimensional array";
            btn2d.UseVisualStyleBackColor = true;
            btn2d.Click += btn2d_Click;
            // 
            // btnMb
            // 
            btnMb.Location = new Point(17, 47);
            btnMb.Name = "btnMb";
            btnMb.Size = new Size(75, 23);
            btnMb.TabIndex = 0;
            btnMb.Text = "Code table";
            btnMb.UseVisualStyleBackColor = true;
            btnMb.Click += btnMb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 395);
            Controls.Add(groupBox2);
            Controls.Add(label5);
            Controls.Add(cBoxTables);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Exporting vocabulary from MySQL";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtUser;
        private System.Windows.Forms.TextBox edtSrv;
        private System.Windows.Forms.TextBox edtPwd;
        private System.Windows.Forms.ComboBox cBoxTables;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConn;
        private GroupBox groupBox2;
        private Button btnMb;
        private Button btn2d;
    }
}

