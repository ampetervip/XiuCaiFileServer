using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Dcp_FileServer
{
    public partial class Form_Main : Form
    {
        #region 字段

        private WebFileServer server;

        // 程序目录下的config.ini
        string iniPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DConfig.ini");
        #endregion

        public Form_Main()
        {
            InitializeComponent();
            initver();
            DLoadIni();
        }

        //获取本机IP地址
        private string GetLocalIPAddress()
        {
            try
            {
                var interfaces = NetworkInterface.GetAllNetworkInterfaces()
                    .Where(ni => ni.OperationalStatus == OperationalStatus.Up)
                    .OrderByDescending(ni =>
                    {
                        if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                            ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                            return 2;
                        return 1;
                    });

                foreach (var ni in interfaces)
                {
                    var properties = ni.GetIPProperties();
                    foreach (var addr in properties.UnicastAddresses)
                    {
                        if (addr.Address.AddressFamily == AddressFamily.InterNetwork &&
                            !IPAddress.IsLoopback(addr.Address) &&
                            properties.GatewayAddresses.Any())
                        {
                            return addr.Address.ToString();
                        }
                    }
                }
                return "未找到可用的局域网IP地址";
            }
            catch (Exception ex)
            {
                return $"获取IP地址时出错: {ex.Message}";
            }
        }

        #region 初始化
        private void initver()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.Text += "_Ver" + fvi.FileVersion;
        }

        // 开机启动设置
        private void SetAutoStart(bool enable)
        {
            string appName = Process.GetCurrentProcess().ProcessName;
            string appPath = Process.GetCurrentProcess().MainModule.FileName;

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (enable)
                {
                    key.SetValue(appName, $"\"{appPath}\"");
                }
                else
                {
                    key.DeleteValue(appName, false);
                }
            }
        }

        private bool IsAutoStartEnabled()
        {
            string appName = Process.GetCurrentProcess().ProcessName;
            string appPath = Process.GetCurrentProcess().MainModule.FileName;
            string expectedValue = $"\"{appPath}\"";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Run", false))
            {
                if (key == null)
                    return false;

                object registryValue = key.GetValue(appName);
                return registryValue != null && registryValue.ToString() == expectedValue;
            }
        }

        private void DLoadIni()
        {
            chk_开机启动.Checked = IsAutoStartEnabled();

            IniFileHelper ini = new IniFileHelper(iniPath);

            bool autoMin = ini.ReadBool("文件服务器设置", "启动最小化", false);
            chk_启动最小化窗口.Checked = autoMin;

            // 文件服务器设置（保持不变）
            string programDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string webDirectory = Path.Combine(programDirectory, "SerFile");
            Tbx_网站目录.Text = ini.ReadString("文件服务器设置", "文件目录", webDirectory);
            Num_网站端口.Text = ini.ReadString("文件服务器设置", "网站端口", "1314");

            string DGetPassword = ini.ReadString("文件服务器设置", "上传密码", "MTIzNDU2");
            if (DGetPassword.Length > 0)
            {
                DGetPassword = DecodeFromBase64(DGetPassword);
            }
            Tbx_上传密码.Text = DGetPassword;
            Num_限制上传大小.Text = ini.ReadString("文件服务器设置", "限制上传大小", "1024");
            Chk_启动运行文件服务.Checked = ini.ReadBool("文件服务器设置", "启动服务", false);
        }

        private void DSaveIni()
        {
            IniFileHelper ini = new IniFileHelper(iniPath);
            ini.WriteString("文件服务器设置", "文件目录", Tbx_网站目录.Text.Trim());
            ini.WriteString("文件服务器设置", "网站端口", Num_网站端口.Text.Trim());
            ini.WriteString("文件服务器设置", "上传密码", EncodeToBase64(Tbx_上传密码.Text.Trim()));
            ini.WriteString("文件服务器设置", "限制上传大小", Num_限制上传大小.Text.Trim());
            ini.WriteBool("文件服务器设置", "启动最小化", chk_启动最小化窗口.Checked);
            ini.WriteBool("文件服务器设置", "启动服务", Chk_启动运行文件服务.Checked);
        }

        // 将字符串编码为Base64
        private string EncodeToBase64(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(bytes);
        }

        // 从Base64解码字符串
        private string DecodeFromBase64(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            byte[] bytes = Convert.FromBase64String(input);
            return System.Text.Encoding.UTF8.GetString(bytes);
        }
        #endregion

        private void Form_Main_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetAutoStart(chk_开机启动.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设置失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chk_开机启动.Checked = !chk_开机启动.Checked;
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "确定要退出程序吗？",
                "确认退出",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            DSaveIni();
        }

        #region 文件服务器相关（保持不变）
        private void Btn_浏览目录_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Tbx_网站目录.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void Btn_默认目录_Click(object sender, EventArgs e)
        {
            Tbx_网站目录.Text = DGetDir_Web();
        }

        private void Btn_预览_Click(object sender, EventArgs e)
        {
            string host = $"http://{GetLocalIPAddress()}";
            string port = Num_网站端口.Text;
            string url = host + ":" + port;

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开网址时出现错误: " + ex.Message);
            }
        }

        private void Btn_启动文件服务_Click(object sender, EventArgs e)
        {
            rich_web_info.Clear();
            if (Btn_启动停止文件服务.Text=="启动")
            {
                string baseFolder = Tbx_网站目录.Text;
                int port = int.Parse(Num_网站端口.Text.Trim());
                if (!DirectoryExists(baseFolder))
                {
                    MessageBox.Show("目录不存在，请输入有效的目录路径", "提示");
                    Btn_启动停止文件服务.Enabled = true;
                    return;
                }
                if (IsPortInUse(port))
                {
                    MessageBox.Show("端口已被占用，请选择另一个端口", "提示");
                    Btn_启动停止文件服务.Enabled = true;
                    return;
                }
                Btn_启动停止文件服务.Text = "停止";
                Btn_启动停止文件服务.BackColor = Color.Crimson;
                Tbx_网站目录.Enabled = false;
                Btn_浏览目录.Enabled = false;
                Btn_浏览目录.BackColor = Color.Silver;
                Btn_默认目录.Enabled = false;
                Btn_默认目录.BackColor = Color.Silver;
                Num_网站端口.Enabled = false;
                Tbx_上传密码.Enabled = false;
                Num_限制上传大小.Enabled = false;
                Btn_预览.Enabled = true;
                Btn_预览.BackColor = Color.RoyalBlue;

                server = new WebFileServer(baseFolder, port);
                server.SetUploadPassword(Tbx_上传密码.Text.Trim());
                server.SetMaxFileSize(((long)Num_限制上传大小.Value));
                server.StartServer();
                rich_web_info.AppendText("[" + DateTime.Now.ToString() + "]: " + "文件服务器已启动...\n");
                rich_web_info.AppendText("[" + DateTime.Now.ToString() + "]: " + "访问地址: " + $"http://{GetLocalIPAddress()}:" + port + "\n");
            }
            else
            {
                    if (server != null)
                    {
                        rich_web_info.AppendText("[" + DateTime.Now.ToString() + "]: " + "文件服务器已停止...\n");
                        server.StopServer();
                        server = null;
                    }
                    else
                    {
                        rich_web_info.AppendText("[" + DateTime.Now.ToString() + "]: " + "文件服务器尚未启动或已经停止...\n");
                    }
                    Btn_启动停止文件服务.Text = "启动";
                    Btn_启动停止文件服务.BackColor = Color.SeaGreen;
                    Tbx_网站目录.Enabled = true;
                    Btn_浏览目录.Enabled = true;
                    Btn_浏览目录.BackColor = Color.SeaGreen;
                    Btn_默认目录.Enabled = true;
                    Btn_默认目录.BackColor = Color.SeaGreen;
                    Num_网站端口.Enabled = true;
                    Tbx_上传密码.Enabled = true;
                    Num_限制上传大小.Enabled = true;
                    Btn_预览.Enabled = false;
                    Btn_预览.BackColor = Color.Silver;
            }
        }
        private string DGetDir_Web()
        {
            string programDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string webDirectory = Path.Combine(programDirectory, "SerFile");

            if (!Directory.Exists(webDirectory))
            {
                Directory.CreateDirectory(webDirectory);
            }

            return webDirectory;
        }
        private bool DirectoryExists(string path)
        {
            return Directory.Exists(path);
        }
        private bool IsPortInUse(int port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] endPoints = ipGlobalProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endPoint in endPoints)
            {
                if (endPoint.Port == port)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        private void chk_开机启动_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetAutoStart(chk_开机启动.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设置失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chk_开机启动.Checked = !chk_开机启动.Checked;
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            if (Chk_启动运行文件服务.Checked)
            {
                this.BeginInvoke(new Action(() =>
                {
                    Btn_启动文件服务_Click(Btn_启动停止文件服务, EventArgs.Empty);
                }));
            }
            if (chk_启动最小化窗口.Checked)
            {
                this.BeginInvoke(new Action(() =>
                {
                    this.WindowState = FormWindowState.Minimized;
                    this.ShowInTaskbar = false;
                }));
            }
        }
    }
}