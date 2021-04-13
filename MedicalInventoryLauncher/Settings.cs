using MedicalInventoryLauncher.Resources;
using System;
using System.IO;
using System.Windows.Forms;

namespace MedicalInventoryLauncher
{
    public partial class Settings : Form
    {
        private ConfigurationLoader loader;

        public Settings()
        {
            loader = ConfigurationLoader.Instance();
            InitializeComponent();
            LoadValues();
        }

        private void LoadValues()
        {
            textBoxTomcatPth.Text = loader.tomcatHomePath;
            textBoxDataPath.Text = loader.postgreDataPath;
            textBoxPgHomePath.Text = loader.postgreHomePath;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectTomcatHome_Click(object sender, EventArgs e)
        {
            openDialog((string filePath) =>
            {
                loader.tomcatHomePath = filePath;
                LoadValues();
            });
        }

        private void btnSelectPgHome_Click(object sender, EventArgs e)
        {
            openDialog((string filePath) =>
            {
                loader.postgreHomePath = filePath;
                LoadValues();
            });
        }

        private void btnSelectPgData_Click(object sender, EventArgs e)
        {
            openDialog((string filePath) =>
            {
                loader.postgreDataPath = filePath;
                LoadValues();
            });
        }

        private void openDialog(Action<String> callback)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    callback(dialog.SelectedPath);
                    Console.WriteLine("Selected PATH: " + dialog.SelectedPath);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            loader.Save();
        }
    }

    
}
