namespace Project_OOP_2330506
{
    partial class FoodEntry
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
            textBoxMoodBefore = new TextBox();
            textBoxPortionSize = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBoxMoodAfter = new TextBox();
            buttonLogEntry = new Button();
            pictureBox1 = new PictureBox();
            comboBox_food = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxMoodBefore
            // 
            textBoxMoodBefore.Location = new Point(392, 248);
            textBoxMoodBefore.Name = "textBoxMoodBefore";
            textBoxMoodBefore.Size = new Size(248, 23);
            textBoxMoodBefore.TabIndex = 14;
            // 
            // textBoxPortionSize
            // 
            textBoxPortionSize.Location = new Point(392, 208);
            textBoxPortionSize.Name = "textBoxPortionSize";
            textBoxPortionSize.Size = new Size(248, 23);
            textBoxPortionSize.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Honeydew;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(208, 24);
            label5.Name = "label5";
            label5.Size = new Size(432, 65);
            label5.TabIndex = 11;
            label5.Text = "FOOD LOG ENTRY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MintCream;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(240, 168);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 10;
            label3.Text = "Food Item Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(120, 248);
            label2.Name = "label2";
            label2.Size = new Size(253, 21);
            label2.TabIndex = 9;
            label2.Text = "Mood Rating Before Eating (0-10)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MintCream;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(216, 208);
            label4.Name = "label4";
            label4.Size = new Size(158, 21);
            label4.TabIndex = 8;
            label4.Text = "Portion Size (in gms)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MintCream;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(256, 128);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 15;
            label1.Text = "Date and Time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(392, 128);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.MintCream;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGreen;
            label6.Location = new Point(136, 288);
            label6.Name = "label6";
            label6.Size = new Size(241, 21);
            label6.TabIndex = 9;
            label6.Text = "Mood Rating After Eating (0-10)";
            // 
            // textBoxMoodAfter
            // 
            textBoxMoodAfter.Location = new Point(392, 288);
            textBoxMoodAfter.Name = "textBoxMoodAfter";
            textBoxMoodAfter.Size = new Size(248, 23);
            textBoxMoodAfter.TabIndex = 14;
            // 
            // buttonLogEntry
            // 
            buttonLogEntry.BackColor = Color.MintCream;
            buttonLogEntry.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogEntry.ForeColor = Color.DarkGreen;
            buttonLogEntry.Location = new Point(328, 352);
            buttonLogEntry.Name = "buttonLogEntry";
            buttonLogEntry.Size = new Size(176, 40);
            buttonLogEntry.TabIndex = 17;
            buttonLogEntry.Text = "Log Entry";
            buttonLogEntry.UseVisualStyleBackColor = false;
            buttonLogEntry.Click += buttonLogEntry_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._97cbd8b5_d5e5_4b3e_88c8_efb5008715ac;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 456);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // comboBox_food
            // 
            comboBox_food.FormattingEnabled = true;
            comboBox_food.Location = new Point(392, 168);
            comboBox_food.Name = "comboBox_food";
            comboBox_food.Size = new Size(248, 23);
            comboBox_food.TabIndex = 19;
            // 
            // FoodEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_food);
            Controls.Add(buttonLogEntry);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(textBoxMoodAfter);
            Controls.Add(textBoxMoodBefore);
            Controls.Add(textBoxPortionSize);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Name = "FoodEntry";
            Text = "FoodEntry";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMoodBefore;
        private TextBox textBoxPortionSize;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBoxMoodAfter;
        private Button buttonLogEntry;
        private PictureBox pictureBox1;
        private ComboBox comboBox_food;
    }
}