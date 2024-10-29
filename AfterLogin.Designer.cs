namespace Project_OOP_2330506
{
    partial class AfterLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterLogin));
            label1 = new Label();
            listBox1 = new ListBox();
            buttonAddNewLog = new Button();
            button_recommend = new Button();
            buttonlogout = new Button();
            label2 = new Label();
            button_deletelog = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "You are now Logged In !";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.MintCream;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(744, 199);
            listBox1.TabIndex = 1;
            // 
            // buttonAddNewLog
            // 
            buttonAddNewLog.BackColor = Color.Honeydew;
            buttonAddNewLog.ForeColor = Color.DarkGreen;
            buttonAddNewLog.Location = new Point(24, 312);
            buttonAddNewLog.Name = "buttonAddNewLog";
            buttonAddNewLog.Size = new Size(360, 40);
            buttonAddNewLog.TabIndex = 2;
            buttonAddNewLog.Text = "Add New Log";
            buttonAddNewLog.UseVisualStyleBackColor = false;
            buttonAddNewLog.Click += buttonAddNewLog_Click;
            // 
            // button_recommend
            // 
            button_recommend.BackColor = Color.Honeydew;
            button_recommend.ForeColor = Color.DarkGreen;
            button_recommend.Location = new Point(224, 400);
            button_recommend.Name = "button_recommend";
            button_recommend.Size = new Size(168, 40);
            button_recommend.TabIndex = 2;
            button_recommend.Text = "Recommend Me";
            button_recommend.UseVisualStyleBackColor = false;
            button_recommend.Click += button_recommend_Click;
            // 
            // buttonlogout
            // 
            buttonlogout.BackColor = Color.Honeydew;
            buttonlogout.ForeColor = Color.DarkGreen;
            buttonlogout.Location = new Point(416, 400);
            buttonlogout.Name = "buttonlogout";
            buttonlogout.Size = new Size(168, 40);
            buttonlogout.TabIndex = 2;
            buttonlogout.Text = "Log Out";
            buttonlogout.UseVisualStyleBackColor = false;
            buttonlogout.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Honeydew;
            label2.Font = new Font("Impact", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(240, 48);
            label2.Name = "label2";
            label2.Size = new Size(295, 45);
            label2.TabIndex = 3;
            label2.Text = "FOOD LOG ENTRIES";
            // 
            // button_deletelog
            // 
            button_deletelog.BackColor = Color.Honeydew;
            button_deletelog.ForeColor = Color.DarkGreen;
            button_deletelog.Location = new Point(392, 312);
            button_deletelog.Name = "button_deletelog";
            button_deletelog.Size = new Size(376, 40);
            button_deletelog.TabIndex = 4;
            button_deletelog.Text = "Delete Log";
            button_deletelog.UseVisualStyleBackColor = false;
            button_deletelog.Click += button_deletelog_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 456);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // AfterLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_deletelog);
            Controls.Add(label2);
            Controls.Add(buttonlogout);
            Controls.Add(button_recommend);
            Controls.Add(buttonAddNewLog);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Name = "AfterLogin";
            Text = "AfterLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button buttonAddNewLog;
        private Button button_recommend;
        private Button buttonlogout;
        private Label label2;
        private Button button_deletelog;
        private PictureBox pictureBox2;
    }
}