using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KornaLauncher
{
    public partial class backgroundRunner: Form
    {
        private Process process;
        private Action onProcessExit; // Çıkış işlemi için bir callback fonksiyonu
        private Form1 form1;

        public backgroundRunner(Action onExitAction, Form1 form1)
        {
            InitializeComponent();
            onProcessExit = onExitAction; // Process exit olunca çağrılacak fonksiyon
            this.form1 = form1;
            
        }

        public void StartJavaProcess(bool showlogs)
        {
            string workingDir = Path.Combine(Directory.GetCurrentDirectory(), "korncraft"); // korncraft klasörüne gir

            process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "java",
                    Arguments = $"-Xmx1024M -Xms1024M -cp korncraft.jar -Djava.library.path=./natives Start --username {Properties.Settings.Default.kullaniciAdi}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDir // Çalışma dizinini korncraft klasörüne ayarla!
                },
                EnableRaisingEvents = true
            };

            process.OutputDataReceived += (sender, e) => LogOutput(e.Data);
            process.ErrorDataReceived += (sender, e) => LogOutput(e.Data);
            process.Exited += (sender, e) => OnProcessExit(); // Çıkış olayını yakala

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
        }

        private void LogOutput(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                Console.WriteLine(text);
                addlog(text);
            }
        }

        private void addlog(string text)
        {
            if (listBox1.InvokeRequired)
            {
                listBox1.Invoke(new Action(() => listBox1.Items.Add(text)));
            }
            else
            {
                listBox1.Items.Add(text);
            }
        }

        private void OnProcessExit()
        {
            onProcessExit?.Invoke(); // Tanımlanan callback fonksiyonunu çağır
        }

        public void StopJavaProcess()
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
                process.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(listBox1.SelectedItem.ToString());
            }
            catch
            {
                return;
            }
        }
    }
}
