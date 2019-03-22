namespace VetLearn
{
    partial class AnswerScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.RichTextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ответ:";
            // 
            // answerTextBox
            // 
            this.answerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTextBox.Location = new System.Drawing.Point(29, 71);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.ReadOnly = true;
            this.answerTextBox.Size = new System.Drawing.Size(572, 165);
            this.answerTextBox.TabIndex = 3;
            this.answerTextBox.Text = "";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(438, 253);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(163, 44);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "Вернуться";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // AnswerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 309);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AnswerScreen";
            this.Text = "AnswerScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnswerScreen_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox answerTextBox;
        private System.Windows.Forms.Button okBtn;
    }
}