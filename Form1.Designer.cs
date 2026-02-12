
namespace ExportVocab
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtUser = new System.Windows.Forms.TextBox();
            this.edtSrv = new System.Windows.Forms.TextBox();
            this.edtPwd = new System.Windows.Forms.TextBox();
            this.cBoxTables = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn2d = new System.Windows.Forms.Button();
            this.btnMb = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edtUser);
            this.groupBox1.Controls.Add(this.edtSrv);
            this.groupBox1.Controls.Add(this.edtPwd);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "连接服务器";
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(90, 160);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(161, 22);
            this.btnConn.TabIndex = 12;
            this.btnConn.Text = "Connect";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server(IP):";
            // 
            // edtUser
            // 
            this.edtUser.Location = new System.Drawing.Point(90, 75);
            this.edtUser.Name = "edtUser";
            this.edtUser.Size = new System.Drawing.Size(162, 20);
            this.edtUser.TabIndex = 2;
            // 
            // edtSrv
            // 
            this.edtSrv.Location = new System.Drawing.Point(90, 29);
            this.edtSrv.Name = "edtSrv";
            this.edtSrv.Size = new System.Drawing.Size(162, 20);
            this.edtSrv.TabIndex = 1;
            this.edtSrv.Text = "127.0.0.1";
            // 
            // edtPwd
            // 
            this.edtPwd.Location = new System.Drawing.Point(90, 120);
            this.edtPwd.Name = "edtPwd";
            this.edtPwd.PasswordChar = '*';
            this.edtPwd.Size = new System.Drawing.Size(162, 20);
            this.edtPwd.TabIndex = 3;
            // 
            // cBoxTables
            // 
            this.cBoxTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxTables.FormattingEnabled = true;
            this.cBoxTables.Location = new System.Drawing.Point(368, 17);
            this.cBoxTables.Name = "cBoxTables";
            this.cBoxTables.Size = new System.Drawing.Size(109, 21);
            this.cBoxTables.TabIndex = 5;
            this.cBoxTables.SelectedIndexChanged += new System.EventHandler(this.cBoxTables_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(322, 248);
            this.dataGridView1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Temp表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn2d);
            this.groupBox2.Controls.Add(this.btnMb);
            this.groupBox2.Location = new System.Drawing.Point(24, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 73);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Export Word";
            // 
            // btn2d
            // 
            this.btn2d.Location = new System.Drawing.Point(176, 32);
            this.btn2d.Name = "btn2d";
            this.btn2d.Size = new System.Drawing.Size(75, 23);
            this.btn2d.TabIndex = 1;
            this.btn2d.Text = "Array-2D";
            this.btn2d.UseVisualStyleBackColor = true;
            this.btn2d.Click += new System.EventHandler(this.btn2d_Click);
            // 
            // btnMb
            // 
            this.btnMb.Location = new System.Drawing.Point(30, 32);
            this.btnMb.Name = "btnMb";
            this.btnMb.Size = new System.Drawing.Size(75, 23);
            this.btnMb.TabIndex = 0;
            this.btnMb.Text = "Code table";
            this.btnMb.UseVisualStyleBackColor = true;
            this.btnMb.Click += new System.EventHandler(this.btnMb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 306);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxTables);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Exporting vocabulary from MySQL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn2d;
        private System.Windows.Forms.Button btnMb;
    }
}

