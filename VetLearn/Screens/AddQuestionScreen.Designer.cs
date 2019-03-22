namespace VetLearn.Screens
{
    partial class AddQuestionScreen
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
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.answTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loadImgbtn = new System.Windows.Forms.Button();
            this.addQstnbtn = new System.Windows.Forms.Button();
            this.fileNamelbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.noPicturebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(33, 166);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(528, 151);
            this.descriptionTextBox.TabIndex = 0;
            // 
            // answTextBox
            // 
            this.answTextBox.Location = new System.Drawing.Point(33, 362);
            this.answTextBox.Multiline = true;
            this.answTextBox.Name = "answTextBox";
            this.answTextBox.Size = new System.Drawing.Size(528, 86);
            this.answTextBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введи информацию о вопросе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание вопроса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ответ на вопрос:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(30, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ответ:";
            // 
            // loadImgbtn
            // 
            this.loadImgbtn.Location = new System.Drawing.Point(110, 465);
            this.loadImgbtn.Name = "loadImgbtn";
            this.loadImgbtn.Size = new System.Drawing.Size(190, 39);
            this.loadImgbtn.TabIndex = 8;
            this.loadImgbtn.Text = "Загрузить картинку";
            this.loadImgbtn.UseVisualStyleBackColor = true;
            this.loadImgbtn.Click += new System.EventHandler(this.LoadImgbtn_Click);
            // 
            // addQstnbtn
            // 
            this.addQstnbtn.Location = new System.Drawing.Point(110, 576);
            this.addQstnbtn.Name = "addQstnbtn";
            this.addQstnbtn.Size = new System.Drawing.Size(364, 39);
            this.addQstnbtn.TabIndex = 9;
            this.addQstnbtn.Text = "Добавить вопрос";
            this.addQstnbtn.UseVisualStyleBackColor = true;
            this.addQstnbtn.Click += new System.EventHandler(this.AddQstnbtn_Click);
            // 
            // fileNamelbl
            // 
            this.fileNamelbl.AutoSize = true;
            this.fileNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNamelbl.Location = new System.Drawing.Point(329, 497);
            this.fileNamelbl.Name = "fileNamelbl";
            this.fileNamelbl.Size = new System.Drawing.Size(0, 20);
            this.fileNamelbl.TabIndex = 10;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(470, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 39);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "В меню";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // noPicturebtn
            // 
            this.noPicturebtn.Location = new System.Drawing.Point(110, 510);
            this.noPicturebtn.Name = "noPicturebtn";
            this.noPicturebtn.Size = new System.Drawing.Size(190, 39);
            this.noPicturebtn.TabIndex = 12;
            this.noPicturebtn.Text = "Без картинки";
            this.noPicturebtn.UseVisualStyleBackColor = true;
            this.noPicturebtn.Click += new System.EventHandler(this.NoPicturebtn_Click);
            // 
            // AddQuestionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 627);
            this.Controls.Add(this.noPicturebtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.fileNamelbl);
            this.Controls.Add(this.addQstnbtn);
            this.Controls.Add(this.loadImgbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.answTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "AddQuestionScreen";
            this.Text = "AddQuestionScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuestionScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox answTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadImgbtn;
        private System.Windows.Forms.Button addQstnbtn;
        private System.Windows.Forms.Label fileNamelbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button noPicturebtn;
    }
}