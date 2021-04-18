using MedicalInventoryLauncher.Resources;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MedicalInventoryLauncher
{
    public partial class Form1 : Form
    {

        CommandLineExecution cmd = new CommandLineExecution();
        ConfigurationLoader loader = ConfigurationLoader.Instance();
        public Form1()
        {
            InitializeComponent();
            textIPAddress.Text = loader.localAddress;
            
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit Application?",
                "Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                e.Cancel = false;
            } else
            {
                e.Cancel = true;
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void button1_Click(object sender, EventArgs e)
        {
            getSetting().Show();
        }

        private Settings getSetting()
        {
            return new Settings();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            cmd.StartServer();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            cmd.StopServer();
        }

        private void btnStartDatabase_Click(object sender, EventArgs e)
        {
            cmd.StartDatabase();
        }

        private void btnStopDatabase_Click(object sender, EventArgs e)
        {
            cmd.StopDatabase();
        }
    }
}
