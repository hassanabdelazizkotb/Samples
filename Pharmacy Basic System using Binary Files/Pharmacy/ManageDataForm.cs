using System;
using System.IO;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class ManageDataForm : Form
    {
        public ManageDataForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFileName.Text.Trim();
                string id = txtId.Text.Trim();
                string name = txtName.Text.Trim();
                string price = txtPrice.Text.Trim();

                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Please enter a file name.");
                    return;
                }

                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
                {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                string filePath = fileName + ".txt";

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string content = sr.ReadToEnd();
                        if (content.Contains(id + "\t"))
                        {
                            MessageBox.Show("This ID already exists. Please use a different ID.");
                            return;
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    string data = $"{id}\t{name}\t{price} LE";
                    sw.WriteLine(data);
                }

                MessageBox.Show("Data added to the file successfully.");
                ClearInputs();
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

        private void btnCreate_Click(object sender, EventArgs e)
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

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    // File is created if it does not exist
                }

                MessageBox.Show("File created successfully.");
                txtFileName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = txtFileName.Text.Trim();
                string id = txtId.Text.Trim();

                if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please enter both file name and ID.");
                    return;
                }

                string filePath = fileName + ".txt";
                bool found = false;

                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] data = line.Split('\t');
                            if (data.Length >= 3 && data[0] == id)
                            {
                                txtId.Text = data[0];
                                txtName.Text = data[1];
                                txtPrice.Text = data[2];
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        MessageBox.Show("ID not found.");
                        ClearInputs();
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

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayDataForm displayForm = new DisplayDataForm();
            displayForm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    File.Delete(filePath);
                    MessageBox.Show("File deleted.");
                    txtFileName.Clear();
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void ClearInputs()
        {
            txtPrice.Clear();
            txtName.Clear();
            txtId.Clear();
            txtName.Focus();
        }
    }
}
