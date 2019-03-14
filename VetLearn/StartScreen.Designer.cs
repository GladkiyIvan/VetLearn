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
            this.category1 = new System.Windows.Forms.Button();
            this.category2 = new System.Windows.Forms.Button();
            this.category3 = new System.Windows.Forms.Button();
            this.category4 = new System.Windows.Forms.Button();
            this.category5 = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выбери категорию";
            // 
            // category1
            // 
            this.category1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category1.Location = new System.Drawing.Point(55, 94);
            this.category1.Name = "category1";
            this.category1.Size = new System.Drawing.Size(316, 70);
            this.category1.TabIndex = 1;
            this.category1.Text = "Анатомия";
            this.category1.UseVisualStyleBackColor = true;
            // 
            // category2
            // 
            this.category2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category2.Location = new System.Drawing.Point(55, 196);
            this.category2.Name = "category2";
            this.category2.Size = new System.Drawing.Size(316, 70);
            this.category2.TabIndex = 2;
            this.category2.Text = "Фармакогнозия";
            this.category2.UseVisualStyleBackColor = true;
            // 
            // category3
            // 
            this.category3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category3.Location = new System.Drawing.Point(55, 297);
            this.category3.Name = "category3";
            this.category3.Size = new System.Drawing.Size(316, 70);
            this.category3.TabIndex = 3;
            this.category3.Text = "Эмбриология";
            this.category3.UseVisualStyleBackColor = true;
            // 
            // category4
            // 
            this.category4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category4.Location = new System.Drawing.Point(55, 399);
            this.category4.Name = "category4";
            this.category4.Size = new System.Drawing.Size(316, 70);
            this.category4.TabIndex = 4;
            this.category4.Text = "Гистология (общая)";
            this.category4.UseVisualStyleBackColor = true;
            // 
            // category5
            // 
            this.category5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category5.Location = new System.Drawing.Point(55, 504);
            this.category5.Name = "category5";
            this.category5.Size = new System.Drawing.Size(316, 70);
            this.category5.TabIndex = 5;
            this.category5.Text = "Гистология (специфическая)";
            this.category5.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(374, 12);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(41, 40);
            this.addbtn.TabIndex = 6;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 594);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.category5);
            this.Controls.Add(this.category4);
            this.Controls.Add(this.category3);
            this.Controls.Add(this.category2);
            this.Controls.Add(this.category1);
            this.Controls.Add(this.label1);
            this.Name = "StartScreen";
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button category1;
        private System.Windows.Forms.Button category2;
        private System.Windows.Forms.Button category3;
        private System.Windows.Forms.Button category4;
        private System.Windows.Forms.Button category5;
        private System.Windows.Forms.Button addbtn;
    }
}