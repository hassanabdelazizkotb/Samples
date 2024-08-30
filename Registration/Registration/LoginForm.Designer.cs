using static System.Net.Mime.MediaTypeNames;
using System;
using System.Drawing;

using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Windows.Forms.Timer;
using Font = System.Drawing.Font;


namespace Registration
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            loginPanel = new Panel();
            label_wrongInput = new Label();
            label_login = new Label();
            button_signUp = new Button();
            button_signIn = new Button();
            textBox_password = new TextBox();
            textBox_userName = new TextBox();
            label_passwordLogin = new Label();
            label_usernameLog = new Label();
            signUpPanel = new Panel();
            textBox_signUpPassword = new TextBox();
            textBox_signUpUserName = new TextBox();
            label_passwordReg = new Label();
            label_usernameReg = new Label();
            label_signUp = new Label();
            button_Confirm = new Button();
            timer1 = new Timer(components);
            loginPanel.SuspendLayout();
            signUpPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Black;
            loginPanel.Controls.Add(label_wrongInput);
            loginPanel.Controls.Add(label_login);
            loginPanel.Controls.Add(button_signUp);
            loginPanel.Controls.Add(button_signIn);
            loginPanel.Controls.Add(textBox_password);
            loginPanel.Controls.Add(textBox_userName);
            loginPanel.Controls.Add(label_passwordLogin);
            loginPanel.Controls.Add(label_usernameLog);
            loginPanel.Dock = DockStyle.Top;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Margin = new Padding(2);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(751, 168);
            loginPanel.TabIndex = 0;
            loginPanel.Visible = false;
            // 
            // label_wrongInput
            // 
            label_wrongInput.AutoSize = true;
            label_wrongInput.BackColor = Color.Transparent;
            label_wrongInput.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_wrongInput.ForeColor = Color.Red;
            label_wrongInput.Location = new Point(500, 94);
            label_wrongInput.Name = "label_wrongInput";
            label_wrongInput.Size = new Size(201, 17);
            label_wrongInput.TabIndex = 7;
            label_wrongInput.Text = "invaild username or password";
            label_wrongInput.Visible = false;
            // 
            // label_login
            // 
            label_login.AutoSize = true;
            label_login.BackColor = Color.Transparent;
            label_login.FlatStyle = FlatStyle.Popup;
            label_login.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_login.ForeColor = SystemColors.ActiveCaption;
            label_login.Location = new Point(11, 9);
            label_login.Margin = new Padding(2, 0, 2, 0);
            label_login.Name = "label_login";
            label_login.Size = new Size(51, 19);
            label_login.TabIndex = 6;
            label_login.Text = "Login";
            // 
            // button_signUp
            // 
            button_signUp.BackColor = Color.RosyBrown;
            button_signUp.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_signUp.ForeColor = Color.White;
            button_signUp.Location = new Point(267, 105);
            button_signUp.Margin = new Padding(2);
            button_signUp.Name = "button_signUp";
            button_signUp.Size = new Size(100, 31);
            button_signUp.TabIndex = 5;
            button_signUp.Text = "Sign Up";
            button_signUp.UseVisualStyleBackColor = false;
            button_signUp.Click += button_signUp_Click;
            // 
            // button_signIn
            // 
            button_signIn.BackColor = Color.RosyBrown;
            button_signIn.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            button_signIn.ForeColor = Color.White;
            button_signIn.Location = new Point(108, 105);
            button_signIn.Margin = new Padding(2);
            button_signIn.Name = "button_signIn";
            button_signIn.Size = new Size(100, 31);
            button_signIn.TabIndex = 4;
            button_signIn.Text = "Sign In";
            button_signIn.UseVisualStyleBackColor = false;
            button_signIn.Click += button_signIn_Click;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Century Gothic", 12F);
            textBox_password.ForeColor = Color.Black;
            textBox_password.Location = new Point(471, 59);
            textBox_password.Margin = new Padding(2);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(259, 27);
            textBox_password.TabIndex = 3;
            textBox_password.UseSystemPasswordChar = true;
            textBox_password.Click += textBox_password_Click;
            // 
            // textBox_userName
            // 
            textBox_userName.Font = new Font("Century Gothic", 12F);
            textBox_userName.ForeColor = Color.Black;
            textBox_userName.Location = new Point(108, 59);
            textBox_userName.Margin = new Padding(2);
            textBox_userName.Name = "textBox_userName";
            textBox_userName.Size = new Size(259, 27);
            textBox_userName.TabIndex = 2;
            textBox_userName.Click += textBox_userName_Click;
            // 
            // label_passwordLogin
            // 
            label_passwordLogin.AutoSize = true;
            label_passwordLogin.BackColor = Color.Transparent;
            label_passwordLogin.FlatStyle = FlatStyle.Popup;
            label_passwordLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_passwordLogin.ForeColor = Color.White;
            label_passwordLogin.Location = new Point(379, 63);
            label_passwordLogin.Margin = new Padding(2, 0, 2, 0);
            label_passwordLogin.Name = "label_passwordLogin";
            label_passwordLogin.Size = new Size(84, 19);
            label_passwordLogin.TabIndex = 1;
            label_passwordLogin.Text = "Password:";
            // 
            // label_usernameLog
            // 
            label_usernameLog.AutoSize = true;
            label_usernameLog.BackColor = Color.Transparent;
            label_usernameLog.FlatStyle = FlatStyle.Popup;
            label_usernameLog.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_usernameLog.ForeColor = Color.White;
            label_usernameLog.Location = new Point(13, 63);
            label_usernameLog.Margin = new Padding(2, 0, 2, 0);
            label_usernameLog.Name = "label_usernameLog";
            label_usernameLog.Size = new Size(91, 19);
            label_usernameLog.TabIndex = 0;
            label_usernameLog.Text = "Username:";
            // 
            // signUpPanel
            // 
            signUpPanel.BackColor = Color.Black;
            signUpPanel.Controls.Add(textBox_signUpPassword);
            signUpPanel.Controls.Add(textBox_signUpUserName);
            signUpPanel.Controls.Add(label_passwordReg);
            signUpPanel.Controls.Add(label_usernameReg);
            signUpPanel.Controls.Add(label_signUp);
            signUpPanel.Controls.Add(button_Confirm);
            signUpPanel.Dock = DockStyle.Bottom;
            signUpPanel.Location = new Point(0, 169);
            signUpPanel.Margin = new Padding(2);
            signUpPanel.Name = "signUpPanel";
            signUpPanel.Size = new Size(751, 171);
            signUpPanel.TabIndex = 1;
            signUpPanel.Visible = false;
            // 
            // textBox_signUpPassword
            // 
            textBox_signUpPassword.Font = new Font("Century Gothic", 12F);
            textBox_signUpPassword.ForeColor = Color.Black;
            textBox_signUpPassword.Location = new Point(471, 60);
            textBox_signUpPassword.Margin = new Padding(2);
            textBox_signUpPassword.Name = "textBox_signUpPassword";
            textBox_signUpPassword.Size = new Size(259, 27);
            textBox_signUpPassword.TabIndex = 5;
            textBox_signUpPassword.UseSystemPasswordChar = true;
            // 
            // textBox_signUpUserName
            // 
            textBox_signUpUserName.Font = new Font("Century Gothic", 12F);
            textBox_signUpUserName.ForeColor = Color.Black;
            textBox_signUpUserName.Location = new Point(108, 60);
            textBox_signUpUserName.Margin = new Padding(2);
            textBox_signUpUserName.Name = "textBox_signUpUserName";
            textBox_signUpUserName.Size = new Size(259, 27);
            textBox_signUpUserName.TabIndex = 4;
            // 
            // label_passwordReg
            // 
            label_passwordReg.AutoSize = true;
            label_passwordReg.BackColor = Color.Transparent;
            label_passwordReg.FlatStyle = FlatStyle.Popup;
            label_passwordReg.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_passwordReg.ForeColor = Color.White;
            label_passwordReg.Location = new Point(379, 64);
            label_passwordReg.Margin = new Padding(2, 0, 2, 0);
            label_passwordReg.Name = "label_passwordReg";
            label_passwordReg.Size = new Size(84, 19);
            label_passwordReg.TabIndex = 3;
            label_passwordReg.Text = "Password:";
            // 
            // label_usernameReg
            // 
            label_usernameReg.AutoSize = true;
            label_usernameReg.BackColor = Color.Transparent;
            label_usernameReg.FlatStyle = FlatStyle.Popup;
            label_usernameReg.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_usernameReg.ForeColor = Color.White;
            label_usernameReg.Location = new Point(13, 64);
            label_usernameReg.Margin = new Padding(2, 0, 2, 0);
            label_usernameReg.Name = "label_usernameReg";
            label_usernameReg.Size = new Size(91, 19);
            label_usernameReg.TabIndex = 2;
            label_usernameReg.Text = "Username:";
            // 
            // label_signUp
            // 
            label_signUp.AutoSize = true;
            label_signUp.BackColor = Color.Transparent;
            label_signUp.FlatStyle = FlatStyle.Popup;
            label_signUp.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_signUp.ForeColor = SystemColors.ActiveCaption;
            label_signUp.Location = new Point(11, 10);
            label_signUp.Margin = new Padding(2, 0, 2, 0);
            label_signUp.Name = "label_signUp";
            label_signUp.Size = new Size(67, 19);
            label_signUp.TabIndex = 1;
            label_signUp.Text = "Sign Up";
            // 
            // button_Confirm
            // 
            button_Confirm.BackColor = Color.RosyBrown;
            button_Confirm.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Confirm.ForeColor = Color.White;
            button_Confirm.Location = new Point(108, 107);
            button_Confirm.Margin = new Padding(2);
            button_Confirm.Name = "button_Confirm";
            button_Confirm.Size = new Size(100, 31);
            button_Confirm.TabIndex = 0;
            button_Confirm.Text = "Confirm";
            button_Confirm.UseVisualStyleBackColor = false;
            button_Confirm.Click += button_Confirm_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Modern_Cover;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(751, 340);
            Controls.Add(signUpPanel);
            Controls.Add(loginPanel);
            Cursor = Cursors.AppStarting;
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            signUpPanel.ResumeLayout(false);
            signUpPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel loginPanel;
        private Button button_signUp;
        private Button button_signIn;
        private TextBox textBox_password;
        private TextBox textBox_userName;
        private Label label_passwordLogin;
        private Label label_usernameLog;
        private Panel signUpPanel;
        private TextBox textBox_signUpPassword;
        private TextBox textBox_signUpUserName;
        private Label label_passwordReg;
        private Label label_usernameReg;
        private Label label_signUp;
        private Timer timer1;
        private Button button_Confirm;
        private Label label_login;
        private Label label_wrongInput;
    }
}
