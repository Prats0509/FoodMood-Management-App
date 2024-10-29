namespace Project_OOP_2330506
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            buttonLogin = new Button();
            buttonGuestRegister = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 24);
            label1.Name = "label1";
            label1.Size = new Size(644, 41);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO MOOD FOOD TRACKER";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.WhiteSmoke;
            buttonLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.Fuchsia;
            buttonLogin.Location = new Point(208, 368);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 56);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // buttonGuestRegister
            // 
            buttonGuestRegister.BackColor = Color.WhiteSmoke;
            buttonGuestRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGuestRegister.ForeColor = Color.Fuchsia;
            buttonGuestRegister.Location = new Point(424, 368);
            buttonGuestRegister.Name = "buttonGuestRegister";
            buttonGuestRegister.Size = new Size(192, 56);
            buttonGuestRegister.TabIndex = 2;
            buttonGuestRegister.Text = "Guest/Register";
            buttonGuestRegister.UseVisualStyleBackColor = false;
            buttonGuestRegister.Click += buttonGuestRegister_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 456);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGuestRegister);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Main_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Button buttonLogin;
        private Button buttonGuestRegister;
        private PictureBox pictureBox2;
    }
}
