namespace Netch.Forms
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label password;
            username = new Label();
            textUserName = new TextBox();
            textPassWord = new TextBox();
            buttonLogin = new Button();
            password = new Label();
            SuspendLayout();
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(88, 103);
            password.Margin = new Padding(2, 0, 2, 0);
            password.Name = "password";
            password.Size = new Size(67, 17);
            password.TabIndex = 1;
            password.Text = "PassWord";
            password.TextAlign = ContentAlignment.BottomRight;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(88, 63);
            username.Margin = new Padding(2, 0, 2, 0);
            username.Name = "username";
            username.Size = new Size(70, 17);
            username.TabIndex = 0;
            username.Text = "UserName";
            // 
            // textUserName
            // 
            textUserName.Location = new Point(181, 59);
            textUserName.Margin = new Padding(2);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(173, 23);
            textUserName.TabIndex = 3;
            textUserName.TextChanged += textUserName_TextChanged;
            // 
            // textPassWord
            // 
            textPassWord.Location = new Point(181, 98);
            textPassWord.Margin = new Padding(2);
            textPassWord.Name = "textPassWord";
            textPassWord.PasswordChar = '*';
            textPassWord.Size = new Size(173, 23);
            textPassWord.TabIndex = 4;
            textPassWord.TextChanged += textBox3_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(281, 156);
            buttonLogin.Margin = new Padding(2);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(71, 24);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 319);
            Controls.Add(buttonLogin);
            Controls.Add(textPassWord);
            Controls.Add(textUserName);
            Controls.Add(password);
            Controls.Add(username);
            Margin = new Padding(2);
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private TextBox textUserName;
        private TextBox textPassWord;
        private Button buttonLogin;
    }
}