namespace Dcp_FileServer
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rich_web_info = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_启动最小化窗口 = new System.Windows.Forms.CheckBox();
            this.chk_开机启动 = new System.Windows.Forms.CheckBox();
            this.Chk_启动运行文件服务 = new System.Windows.Forms.CheckBox();
            this.Num_网站端口 = new System.Windows.Forms.NumericUpDown();
            this.Num_限制上传大小 = new System.Windows.Forms.NumericUpDown();
            this.Lab_限制上传大小 = new System.Windows.Forms.Label();
            this.Lab_上传密码 = new System.Windows.Forms.Label();
            this.Tbx_上传密码 = new System.Windows.Forms.TextBox();
            this.Btn_默认目录 = new System.Windows.Forms.Button();
            this.Btn_预览 = new System.Windows.Forms.Button();
            this.Btn_启动停止文件服务 = new System.Windows.Forms.Button();
            this.Btn_浏览目录 = new System.Windows.Forms.Button();
            this.Lab_目录 = new System.Windows.Forms.Label();
            this.Tbx_网站目录 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_网站端口)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_限制上传大小)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(739, 523);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 489);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "文件服务器";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Azure;
            this.groupBox5.Controls.Add(this.rich_web_info);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(3, 221);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(725, 265);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "日志";
            // 
            // rich_web_info
            // 
            this.rich_web_info.BackColor = System.Drawing.Color.SeaShell;
            this.rich_web_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rich_web_info.ForeColor = System.Drawing.Color.DarkGreen;
            this.rich_web_info.Location = new System.Drawing.Point(4, 26);
            this.rich_web_info.Margin = new System.Windows.Forms.Padding(4);
            this.rich_web_info.Name = "rich_web_info";
            this.rich_web_info.Size = new System.Drawing.Size(717, 235);
            this.rich_web_info.TabIndex = 0;
            this.rich_web_info.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Azure;
            this.groupBox3.Controls.Add(this.chk_启动最小化窗口);
            this.groupBox3.Controls.Add(this.chk_开机启动);
            this.groupBox3.Controls.Add(this.Chk_启动运行文件服务);
            this.groupBox3.Controls.Add(this.Num_网站端口);
            this.groupBox3.Controls.Add(this.Num_限制上传大小);
            this.groupBox3.Controls.Add(this.Lab_限制上传大小);
            this.groupBox3.Controls.Add(this.Lab_上传密码);
            this.groupBox3.Controls.Add(this.Tbx_上传密码);
            this.groupBox3.Controls.Add(this.Btn_默认目录);
            this.groupBox3.Controls.Add(this.Btn_预览);
            this.groupBox3.Controls.Add(this.Btn_启动停止文件服务);
            this.groupBox3.Controls.Add(this.Btn_浏览目录);
            this.groupBox3.Controls.Add(this.Lab_目录);
            this.groupBox3.Controls.Add(this.Tbx_网站目录);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(725, 218);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "设置(文件服务器)";
            // 
            // chk_启动最小化窗口
            // 
            this.chk_启动最小化窗口.AutoSize = true;
            this.chk_启动最小化窗口.Location = new System.Drawing.Point(73, 148);
            this.chk_启动最小化窗口.Name = "chk_启动最小化窗口";
            this.chk_启动最小化窗口.Size = new System.Drawing.Size(141, 25);
            this.chk_启动最小化窗口.TabIndex = 36;
            this.chk_启动最小化窗口.Text = "启动最小化窗口";
            this.chk_启动最小化窗口.UseVisualStyleBackColor = true;
            // 
            // chk_开机启动
            // 
            this.chk_开机启动.AutoSize = true;
            this.chk_开机启动.Location = new System.Drawing.Point(73, 117);
            this.chk_开机启动.Name = "chk_开机启动";
            this.chk_开机启动.Size = new System.Drawing.Size(93, 25);
            this.chk_开机启动.TabIndex = 35;
            this.chk_开机启动.Text = "开机启动";
            this.chk_开机启动.UseVisualStyleBackColor = true;
            this.chk_开机启动.CheckedChanged += new System.EventHandler(this.chk_开机启动_CheckedChanged);
            // 
            // Chk_启动运行文件服务
            // 
            this.Chk_启动运行文件服务.AutoSize = true;
            this.Chk_启动运行文件服务.Location = new System.Drawing.Point(73, 178);
            this.Chk_启动运行文件服务.Name = "Chk_启动运行文件服务";
            this.Chk_启动运行文件服务.Size = new System.Drawing.Size(157, 25);
            this.Chk_启动运行文件服务.TabIndex = 34;
            this.Chk_启动运行文件服务.Text = "启动运行文件服务";
            this.Chk_启动运行文件服务.UseVisualStyleBackColor = true;
            // 
            // Num_网站端口
            // 
            this.Num_网站端口.BackColor = System.Drawing.Color.Linen;
            this.Num_网站端口.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Num_网站端口.Location = new System.Drawing.Point(73, 72);
            this.Num_网站端口.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.Num_网站端口.Name = "Num_网站端口";
            this.Num_网站端口.Size = new System.Drawing.Size(108, 29);
            this.Num_网站端口.TabIndex = 32;
            this.Num_网站端口.Tag = "1314";
            this.Num_网站端口.Value = new decimal(new int[] {
            1314,
            0,
            0,
            0});
            // 
            // Num_限制上传大小
            // 
            this.Num_限制上传大小.BackColor = System.Drawing.Color.Linen;
            this.Num_限制上传大小.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Num_限制上传大小.Location = new System.Drawing.Point(346, 72);
            this.Num_限制上传大小.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Num_限制上传大小.Name = "Num_限制上传大小";
            this.Num_限制上传大小.Size = new System.Drawing.Size(98, 29);
            this.Num_限制上传大小.TabIndex = 30;
            this.Num_限制上传大小.Tag = "10000";
            this.Num_限制上传大小.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // Lab_限制上传大小
            // 
            this.Lab_限制上传大小.AutoSize = true;
            this.Lab_限制上传大小.Location = new System.Drawing.Point(194, 76);
            this.Lab_限制上传大小.Name = "Lab_限制上传大小";
            this.Lab_限制上传大小.Size = new System.Drawing.Size(146, 21);
            this.Lab_限制上传大小.TabIndex = 29;
            this.Lab_限制上传大小.Text = "上传限制大小(MB):";
            // 
            // Lab_上传密码
            // 
            this.Lab_上传密码.AutoSize = true;
            this.Lab_上传密码.Location = new System.Drawing.Point(471, 76);
            this.Lab_上传密码.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_上传密码.Name = "Lab_上传密码";
            this.Lab_上传密码.Size = new System.Drawing.Size(78, 21);
            this.Lab_上传密码.TabIndex = 28;
            this.Lab_上传密码.Text = "上传密码:";
            // 
            // Tbx_上传密码
            // 
            this.Tbx_上传密码.BackColor = System.Drawing.Color.Linen;
            this.Tbx_上传密码.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Tbx_上传密码.Location = new System.Drawing.Point(555, 72);
            this.Tbx_上传密码.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx_上传密码.Name = "Tbx_上传密码";
            this.Tbx_上传密码.Size = new System.Drawing.Size(133, 29);
            this.Tbx_上传密码.TabIndex = 27;
            this.Tbx_上传密码.Text = "123456";
            // 
            // Btn_默认目录
            // 
            this.Btn_默认目录.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_默认目录.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_默认目录.FlatAppearance.BorderSize = 0;
            this.Btn_默认目录.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_默认目录.ForeColor = System.Drawing.Color.Lime;
            this.Btn_默认目录.Location = new System.Drawing.Point(610, 30);
            this.Btn_默认目录.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_默认目录.Name = "Btn_默认目录";
            this.Btn_默认目录.Size = new System.Drawing.Size(82, 29);
            this.Btn_默认目录.TabIndex = 26;
            this.Btn_默认目录.Text = "默认";
            this.Btn_默认目录.UseVisualStyleBackColor = false;
            this.Btn_默认目录.Click += new System.EventHandler(this.Btn_默认目录_Click);
            // 
            // Btn_预览
            // 
            this.Btn_预览.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_预览.BackColor = System.Drawing.Color.RoyalBlue;
            this.Btn_预览.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_预览.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.Btn_预览.ForeColor = System.Drawing.Color.White;
            this.Btn_预览.Location = new System.Drawing.Point(523, 117);
            this.Btn_预览.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Btn_预览.Name = "Btn_预览";
            this.Btn_预览.Size = new System.Drawing.Size(165, 81);
            this.Btn_预览.TabIndex = 25;
            this.Btn_预览.Text = "预览";
            this.Btn_预览.UseVisualStyleBackColor = false;
            this.Btn_预览.Click += new System.EventHandler(this.Btn_预览_Click);
            // 
            // Btn_启动停止文件服务
            // 
            this.Btn_启动停止文件服务.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_启动停止文件服务.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_启动停止文件服务.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_启动停止文件服务.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.Btn_启动停止文件服务.ForeColor = System.Drawing.Color.White;
            this.Btn_启动停止文件服务.Location = new System.Drawing.Point(346, 117);
            this.Btn_启动停止文件服务.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Btn_启动停止文件服务.Name = "Btn_启动停止文件服务";
            this.Btn_启动停止文件服务.Size = new System.Drawing.Size(165, 81);
            this.Btn_启动停止文件服务.TabIndex = 23;
            this.Btn_启动停止文件服务.Text = "启动";
            this.Btn_启动停止文件服务.UseVisualStyleBackColor = false;
            this.Btn_启动停止文件服务.Click += new System.EventHandler(this.Btn_启动文件服务_Click);
            // 
            // Btn_浏览目录
            // 
            this.Btn_浏览目录.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_浏览目录.BackColor = System.Drawing.Color.SeaGreen;
            this.Btn_浏览目录.FlatAppearance.BorderSize = 0;
            this.Btn_浏览目录.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_浏览目录.ForeColor = System.Drawing.Color.Lime;
            this.Btn_浏览目录.Location = new System.Drawing.Point(527, 30);
            this.Btn_浏览目录.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Btn_浏览目录.Name = "Btn_浏览目录";
            this.Btn_浏览目录.Size = new System.Drawing.Size(82, 29);
            this.Btn_浏览目录.TabIndex = 9;
            this.Btn_浏览目录.Text = "浏览...";
            this.Btn_浏览目录.UseVisualStyleBackColor = false;
            this.Btn_浏览目录.Click += new System.EventHandler(this.Btn_浏览目录_Click);
            // 
            // Lab_目录
            // 
            this.Lab_目录.AutoSize = true;
            this.Lab_目录.Location = new System.Drawing.Point(21, 33);
            this.Lab_目录.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lab_目录.Name = "Lab_目录";
            this.Lab_目录.Size = new System.Drawing.Size(46, 21);
            this.Lab_目录.TabIndex = 5;
            this.Lab_目录.Text = "目录:";
            // 
            // Tbx_网站目录
            // 
            this.Tbx_网站目录.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tbx_网站目录.BackColor = System.Drawing.Color.Linen;
            this.Tbx_网站目录.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Tbx_网站目录.Location = new System.Drawing.Point(73, 30);
            this.Tbx_网站目录.Margin = new System.Windows.Forms.Padding(4);
            this.Tbx_网站目录.Name = "Tbx_网站目录";
            this.Tbx_网站目录.Size = new System.Drawing.Size(435, 29);
            this.Tbx_网站目录.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "端口:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(731, 489);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "关于";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Azure;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(725, 483);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "\nby：晨露流星\nVx：51529502";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 523);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "秀才文件服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.Resize += new System.EventHandler(this.Form_Main_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_网站端口)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_限制上传大小)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox rich_web_info;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_默认目录;
        private System.Windows.Forms.Button Btn_预览;
        private System.Windows.Forms.Button Btn_启动停止文件服务;
        private System.Windows.Forms.Button Btn_浏览目录;
        private System.Windows.Forms.Label Lab_目录;
        private System.Windows.Forms.TextBox Tbx_网站目录;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label Lab_上传密码;
        private System.Windows.Forms.TextBox Tbx_上传密码;
        private System.Windows.Forms.NumericUpDown Num_限制上传大小;
        private System.Windows.Forms.Label Lab_限制上传大小;
        private System.Windows.Forms.NumericUpDown Num_网站端口;
        private System.Windows.Forms.CheckBox Chk_启动运行文件服务;
        private System.Windows.Forms.CheckBox chk_开机启动;
        private System.Windows.Forms.CheckBox chk_启动最小化窗口;
    }
}

