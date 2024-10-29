namespace Project_OOP_2330506
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            buttonLoginNow = new Button();
            pictureBox2 = new PictureBox();
            buttonGoBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LavenderBlush;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.Location = new Point(240, 304);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LavenderBlush;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(240, 336);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(352, 304);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(208, 23);
            usernameTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = SystemColors.Window;
            passwordTextBox.Location = new Point(352, 336);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(208, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // buttonLoginNow
            // 
            buttonLoginNow.BackColor = Color.LavenderBlush;
            buttonLoginNow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoginNow.ForeColor = Color.MediumVioletRed;
            buttonLoginNow.Location = new Point(240, 392);
            buttonLoginNow.Name = "buttonLoginNow";
            buttonLoginNow.Size = new Size(144, 39);
            buttonLoginNow.TabIndex = 5;
            buttonLoginNow.Text = "Login Now";
            buttonLoginNow.UseVisualStyleBackColor = false;
            buttonLoginNow.Click += buttonLoginNow_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-8, -88);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(808, 544);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // buttonGoBack
            // 
            buttonGoBack.BackColor = Color.LavenderBlush;
            buttonGoBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGoBack.ForeColor = Color.MediumVioletRed;
            buttonGoBack.Location = new Point(416, 392);
            buttonGoBack.Name = "buttonGoBack";
            buttonGoBack.Size = new Size(144, 39);
            buttonGoBack.TabIndex = 8;
            buttonGoBack.Text = "Go Back";
            buttonGoBack.UseVisualStyleBackColor = false;
            buttonGoBack.Click += buttonGoBack_Click_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGoBack);
            Controls.Add(buttonLoginNow);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "LoginForm";
            Text = "Go Back";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button buttonLoginNow;
        private PictureBox pictureBox2;
        private Button buttonGoBack;
    }
}