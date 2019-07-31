namespace Timed_Math_Quiz
{
    partial class HomePage
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
            this.Intro = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.Label();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Intro
            // 
            this.Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Intro.Location = new System.Drawing.Point(226, 30);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(368, 47);
            this.Intro.TabIndex = 1;
            this.Intro.Text = "Welcome to Math Quiz Game";
            this.Intro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Intro.Click += new System.EventHandler(this.label2_Click);
            // 
            // Category
            // 
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(83, 145);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(145, 23);
            this.Category.TabIndex = 2;
            this.Category.Text = "Choose a level:";
            // 
            // easyButton
            // 
            this.easyButton.AutoSize = true;
            this.easyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.Location = new System.Drawing.Point(136, 202);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(85, 26);
            this.easyButton.TabIndex = 3;
            this.easyButton.Text = "Easy Level";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.AutoSize = true;
            this.mediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.Location = new System.Drawing.Point(357, 202);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(116, 26);
            this.mediumButton.TabIndex = 4;
            this.mediumButton.Text = "Medium Level";
            this.mediumButton.UseVisualStyleBackColor = true;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.AutoSize = true;
            this.hardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.Location = new System.Drawing.Point(608, 202);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(84, 26);
            this.hardButton.TabIndex = 5;
            this.hardButton.Text = "Hard Level";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Intro);
            this.Name = "HomePage";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Intro;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button hardButton;
    }
}

