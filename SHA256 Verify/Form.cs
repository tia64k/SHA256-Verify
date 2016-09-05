using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SHA256_Verify
{
    public partial class Form : System.Windows.Forms.Form
    {
        bool isFileSelected = false;
        bool isSh1256FileSelected = false;

        public Form()
        {
            InitializeComponent();
        }

        private void selectFile1_Click(object sender, EventArgs e)
        {
            isFileSelected = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileComboBox1.Text = openFileDialog1.FileName;
                isFileSelected = true;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (isFileSelected)
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Read);

                generateButton.Text = "Generating...";
                generateButton.Enabled = false;

                string sha256 = GetSha256(fileStream);
                generateChecksumBox.Text = sha256;

                File.WriteAllText(openFileDialog1.FileName + ".sha256", sha256);

                generateButton.Text = "Generate SHA256";
                generateButton.Enabled = true;

                MessageBox.Show("Checksum saved as: " + openFileDialog1.FileName + ".sha256");
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }
        private static string GetSha256(Stream stream)
        {
            SHA256Managed sha = new SHA256Managed();
            byte[] sum = sha.ComputeHash(stream);
            return BitConverter.ToString(sum).Replace("-", String.Empty).ToLower();
        }

        private void selectFile2_Click(object sender, EventArgs e)
        {
            isSh1256FileSelected = false;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                fileComboBox2.Text = openFileDialog2.FileName;
                isSh1256FileSelected = true;
            }
        }

        private void selectFile3_Click(object sender, EventArgs e)
        {
            isFileSelected = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileComboBox3.Text = openFileDialog1.FileName;
                isFileSelected = true;
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            if (isFileSelected && isSh1256FileSelected)
            {
                FileStream fileStream = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Read);

                FileInfo info = new FileInfo(openFileDialog2.FileName);
                if (info.Length != 64)
                {
                    MessageBox.Show("Invalid SHA256 file");
                    return;
                }

                compareButton.Text = "Generating...";
                compareButton.Enabled = false;

                string sha256 = GetSha256(fileStream);

                string sha256FromFile = File.ReadAllText(openFileDialog2.FileName);

                compareButton.Text = "Compare SHA256";
                compareButton.Enabled = true;

                compareChecksumBox.Text = sha256FromFile + Environment.NewLine + sha256;

                if (sha256 == sha256FromFile)
                {
                    MessageBox.Show("SHA256 correct");
                }
                else
                {
                    MessageBox.Show("SHA256 INCORRECT");
                }
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If tab has been changed, reset labels and openFileDialogs
            isFileSelected = false;
            isSh1256FileSelected = false;

            openFileDialog1.Reset();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;

            openFileDialog2.Reset();
            openFileDialog2.Filter = "SHA256 checksum files|*.sha256";
            openFileDialog2.FilterIndex = 0;

            fileComboBox1.Text = "";
            fileComboBox2.Text = "";
            fileComboBox3.Text = "";
            generateChecksumBox.Text = "";
            compareChecksumBox.Text = "";
        }
    }
}
