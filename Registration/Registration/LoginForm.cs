using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Windows.Forms;
using Registration; // Adjust the namespace if needed
using Timer = System.Windows.Forms.Timer;
namespace Registration
{
    public partial class LoginForm : Form
    {
        private Timer _timer;
        private const int TimerInterval = 5000; // 5 seconds
        private readonly UserRepository _userRepository;
        
        
        public LoginForm()
        {
            InitializeComponent();
            InitializeTimer();
            _userRepository = new UserRepository();
            KeyPreview = true;
            KeyDown += LoginForm_KeyDown;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void InitializeTimer()
        {
            _timer = new Timer
            {
                Interval = TimerInterval
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            loginPanel.BackColor = Color.FromArgb(100, 0, 0, 0); // Semi-transparent overlay
            loginPanel.Visible = true;
            Cursor = Cursors.Default;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_signIn.PerformClick();
            }
        }

        private void button_signIn_Click(object sender, EventArgs e)
        {
            string userName = textBox_userName.Text.Trim();
            string password = textBox_password.Text.Trim();

            if (_userRepository.ValidateUser(userName, password))
            {
                MessageBox.Show("Login Successfully");
                ShowHomeForm();
            }
            else
            {
                label_wrongInput.Visible = true;

                DisplayLoginError();
            }
        }

        private void button_signUp_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            
            signUpPanel.BackColor = Color.FromArgb(100, 0, 0, 0); // Semi-transparent overlay
            signUpPanel.Visible = true;
        }

        private void ShowHomeForm()
        {
            /*Home homeForm = new Home();
            homeForm.FormClosed += Home_FormClosed;
            homeForm.Show();
            Hide();
            */
        }

        private void DisplayLoginError()
        {
           
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CustomMessage()
        {
            // Hide the message label if username and password fields are not empty
            label_wrongInput.Visible=false;
        }

        private void textBox_userName_Click(object sender, EventArgs e)
        {
            CustomMessage();
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {
            CustomMessage();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            string userName = textBox_signUpUserName.Text.Trim();
            string password = textBox_signUpPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_userRepository.UserExists(userName))
            {
                MessageBox.Show("User already exists.", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _userRepository.AddUser(userName, password);
            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox_signUpUserName.Clear();
            textBox_signUpPassword.Clear();

            signUpPanel.Visible = false;
            loginPanel.Visible = true;
        }
    }
}
