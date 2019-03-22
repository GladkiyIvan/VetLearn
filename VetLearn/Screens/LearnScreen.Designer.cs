namespace VetLearn
{
    partial class LearnScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LearnScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.answerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Описание";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(73, 93);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(774, 138);
            this.descriptionTextBox.TabIndex = 2;
            this.descriptionTextBox.Text = resources.GetString("descriptionTextBox.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(73, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // nextBtn
            // 
            this.nextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextBtn.BackgroundImage")));
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBtn.Location = new System.Drawing.Point(805, 30);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(42, 44);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(715, 30);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 44);
            this.backBtn.TabIndex = 5;
            this.backBtn.Text = "В меню";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // answerBtn
            // 
            this.answerBtn.Location = new System.Drawing.Point(715, 771);
            this.answerBtn.Name = "answerBtn";
            this.answerBtn.Size = new System.Drawing.Size(132, 44);
            this.answerBtn.TabIndex = 6;
            this.answerBtn.Text = "Ответ";
            this.answerBtn.UseVisualStyleBackColor = true;
            this.answerBtn.Click += new System.EventHandler(this.AnswerBtn_Click);
            // 
            // LearnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 827);
            this.Controls.Add(this.answerBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LearnScreen";
            this.Text = "LearnScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LearnScreen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button answerBtn;
    }
}