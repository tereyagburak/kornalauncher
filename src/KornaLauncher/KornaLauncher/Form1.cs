using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KornaLauncher
{
    public partial class Form1 : Form
    {
        public backgroundRunner backgroundRunner;
        RPCinit discordRPC;
        public Form1()
        {
            InitializeComponent();
            discordRPC = new RPCinit();
        }
        public static string username;


        private void Form1_Load(object sender, EventArgs e)
        {
            EnableDarkMode(this.Handle, true);
            if (!IsJavaInstalled())
            {
                MessageBox.Show("Java yüklü değil hocam. Git indir bi zahmet.");
                Process.Start("https://www.java.com/tr/download/");
                Application.Exit();
            }
            username = Properties.Settings.Default.kullaniciAdi;
            if (username == "NullName")
            {
                username = $"ProOyuncu_{RandomString(5)}";
            }

            textBox1.Text = username;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 16)
            {
                MessageBox.Show("kullanıcı adın max 16 char uzunlukta olmalı");
                textBox1.Text = textBox1.Text.Substring(0, 16);
            }
            if (textBox1.Text.Contains(" "))
            {
                MessageBox.Show("boşluk koyma lan");
                textBox1.Text = textBox1.Text.Trim();
            }
            Properties.Settings.Default.kullaniciAdi = textBox1.Text;
            Properties.Settings.Default.Save();
        }







        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static bool IsJavaInstalled()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "java";
                process.StartInfo.Arguments = "-version";
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
                return process.ExitCode == 0;
            }
            catch
            {
                return false;
            }

        }


        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;
        [DllImport("dwmapi.dll", PreserveSig = true)]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);


        private void EnableDarkMode(IntPtr hwnd, bool enable)
        {
            try
            {
                int useDarkMode = enable ? 1 : 0;
                DwmSetWindowAttribute(hwnd, DWMWA_USE_IMMERSIVE_DARK_MODE, ref useDarkMode, Marshal.SizeOf(typeof(int)));
            }
            catch (Exception)
            {
                return;
            }
        }

        private void playB_MouseEnter(object sender, EventArgs e)
        {
            playB.FlatAppearance.BorderColor = Color.White;
        }

        private void playB_MouseLeave(object sender, EventArgs e)
        {
            playB.FlatAppearance.BorderColor = Color.FromArgb(40, 36, 36);
        }

        private void playB_Click(object sender, EventArgs e)
        {
            backgroundRunner = new backgroundRunner(() =>
            {
                this.Invoke(new Action(() =>
                {
                    Application.Exit();
                }));
            },this);

            backgroundRunner.Show();
            backgroundRunner.StartJavaProcess(true);
            playB.Enabled = false;
            stopB.Enabled = true;
            stopB.Visible = true;
            showLogsB.Enabled = true;
            showLogsB.Visible = true;
            backgroundRunner.Visible = false;
        }

        private void stopB_Click(object sender, EventArgs e)
        {
            backgroundRunner.StopJavaProcess(); backgroundRunner = null;
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundRunner.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://michaelsoft1853.github.io/kornacraft/");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            credits credits = new credits();
            credits.ShowDialog();
        }
    }
}