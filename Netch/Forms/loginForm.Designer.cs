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
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            username = new Label();
            textUserName = new TextBox();
            textPassWord = new TextBox();
            buttonLogin = new Button();
            password = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // password
            // 
            password.AutoSize = true;
            password.Location = new Point(138, 145);
            password.Name = "password";
            password.Size = new Size(46, 24);
            password.TabIndex = 1;
            password.Text = "密码";
            password.TextAlign = ContentAlignment.BottomRight;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(138, 89);
            username.Name = "username";
            username.Size = new Size(64, 24);
            username.TabIndex = 0;
            username.Text = "用户名";
            // 
            // textUserName
            // 
            textUserName.Location = new Point(284, 83);
            textUserName.Name = "textUserName";
            textUserName.Size = new Size(270, 30);
            textUserName.TabIndex = 3;
            textUserName.TextChanged += textUserName_TextChanged;
            // 
            // textPassWord
            // 
            textPassWord.Location = new Point(284, 138);
            textPassWord.Name = "textPassWord";
            textPassWord.PasswordChar = '*';
            textPassWord.Size = new Size(270, 30);
            textPassWord.TabIndex = 4;
            textPassWord.TextChanged += textBox3_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(442, 220);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 34);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "登录";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 322);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 6;
            label1.Text = "3BET VIP 专用加速";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 469);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(textPassWord);
            Controls.Add(textUserName);
            Controls.Add(password);
            Controls.Add(username);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "loginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "登录-VIP-测试";
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