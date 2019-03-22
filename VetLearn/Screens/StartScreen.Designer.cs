namespace VetLearn
{
    partial class StartScreen
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
            this.addCatbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addQstnbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбери категорию";
            // 
            // addCatbtn
            // 
            this.addCatbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addCatbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCatbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCatbtn.Location = new System.Drawing.Point(49, 122);
            this.addCatbtn.Name = "addCatbtn";
            this.addCatbtn.Size = new System.Drawing.Size(112, 47);
            this.addCatbtn.TabIndex = 6;
            this.addCatbtn.Text = "+Категория";
            this.addCatbtn.UseVisualStyleBackColor = false;
            this.addCatbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(49, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(430, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Учиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // addQstnbtn
            // 
            this.addQstnbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addQstnbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addQstnbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQstnbtn.Location = new System.Drawing.Point(211, 122);
            this.addQstnbtn.Name = "addQstnbtn";
            this.addQstnbtn.Size = new System.Drawing.Size(109, 47);
            this.addQstnbtn.TabIndex = 9;
            this.addQstnbtn.Text = "+Вопрос";
            this.addQstnbtn.UseVisualStyleBackColor = false;
            this.addQstnbtn.Click += new System.EventHandler(this.AddQstnbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.Salmon;
            this.delbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delbtn.Location = new System.Drawing.Point(370, 122);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(109, 47);
            this.delbtn.TabIndex = 10;
            this.delbtn.Text = "- Категория";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 259);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.addQstnbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.addCatbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addCatbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addQstnbtn;
        private System.Windows.Forms.Button delbtn;
    }
}