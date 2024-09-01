using System;
using System.IO;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class DisplayDataForm : Form
    {
        public DisplayDataForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageDataForm mainForm = new ManageDataForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFileName.Text.Trim();

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Please enter a file name.");
                    return;
                }

                string filePath = fileName + ".txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        txtAll.Text = sr.ReadToEnd();
                    }
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"An error occurred while accessing the file: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void DisplayDataForm_Load(object sender, EventArgs e)
        {
            txtFileName.Text = "Enter file name here";
        }
    }
}
