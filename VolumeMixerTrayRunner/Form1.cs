using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VolumeMixerTrayRunner.Recources;

namespace VolumeMixerTrayRunner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "sndvol.exe";
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();
            }
        }
    }
}
