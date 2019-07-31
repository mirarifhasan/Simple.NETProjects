namespace Timed_Math_Quiz
{
    partial class QuizPage
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
            this.components = new System.ComponentModel.Container();
            this.header = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.plusLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusRight = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minRight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minLeft = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mulRight = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mulLeft = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.divRight = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.divLeft = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.plusRes = new System.Windows.Forms.NumericUpDown();
            this.minRes = new System.Windows.Forms.NumericUpDown();
            this.mulRes = new System.Windows.Forms.NumericUpDown();
            this.divRes = new System.Windows.Forms.NumericUpDown();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plusRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Control;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(260, 13);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(250, 40);
            this.header.TabIndex = 1;
            this.header.Text = "Math Quiz";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(280, 76);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(199, 23);
            this.timeLeftLabel.TabIndex = 2;
            this.timeLeftLabel.Text = "Time Left: ";
            this.timeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLeft
            // 
            this.plusLeft.AutoSize = true;
            this.plusLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeft.Location = new System.Drawing.Point(213, 135);
            this.plusLeft.Name = "plusLeft";
            this.plusLeft.Size = new System.Drawing.Size(18, 20);
            this.plusLeft.TabIndex = 3;
            this.plusLeft.Text = "?";
            this.plusLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "+";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRight
            // 
            this.plusRight.AutoSize = true;
            this.plusRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRight.Location = new System.Drawing.Point(352, 135);
            this.plusRight.Name = "plusRight";
            this.plusRight.Size = new System.Drawing.Size(18, 20);
            this.plusRight.TabIndex = 5;
            this.plusRight.Text = "?";
            this.plusRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "=";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minRight
            // 
            this.minRight.AutoSize = true;
            this.minRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minRight.Location = new System.Drawing.Point(352, 190);
            this.minRight.Name = "minRight";
            this.minRight.Size = new System.Drawing.Size(18, 20);
            this.minRight.TabIndex = 9;
            this.minRight.Text = "?";
            this.minRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(278, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLeft
            // 
            this.minLeft.AutoSize = true;
            this.minLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLeft.Location = new System.Drawing.Point(213, 190);
            this.minLeft.Name = "minLeft";
            this.minLeft.Size = new System.Drawing.Size(18, 20);
            this.minLeft.TabIndex = 7;
            this.minLeft.Text = "?";
            this.minLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(411, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "=";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulRight
            // 
            this.mulRight.AutoSize = true;
            this.mulRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulRight.Location = new System.Drawing.Point(352, 242);
            this.mulRight.Name = "mulRight";
            this.mulRight.Size = new System.Drawing.Size(18, 20);
            this.mulRight.TabIndex = 13;
            this.mulRight.Text = "?";
            this.mulRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "X";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulLeft
            // 
            this.mulLeft.AutoSize = true;
            this.mulLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulLeft.Location = new System.Drawing.Point(213, 242);
            this.mulLeft.Name = "mulLeft";
            this.mulLeft.Size = new System.Drawing.Size(18, 20);
            this.mulLeft.TabIndex = 11;
            this.mulLeft.Text = "?";
            this.mulLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(411, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "=";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRight
            // 
            this.divRight.AutoSize = true;
            this.divRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRight.Location = new System.Drawing.Point(352, 300);
            this.divRight.Name = "divRight";
            this.divRight.Size = new System.Drawing.Size(18, 20);
            this.divRight.TabIndex = 17;
            this.divRight.Text = "?";
            this.divRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(278, 300);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "/";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeft
            // 
            this.divLeft.AutoSize = true;
            this.divLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeft.Location = new System.Drawing.Point(213, 300);
            this.divLeft.Name = "divLeft";
            this.divLeft.Size = new System.Drawing.Size(18, 20);
            this.divLeft.TabIndex = 15;
            this.divLeft.Text = "?";
            this.divLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(333, 359);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(99, 40);
            this.submitButton.TabIndex = 19;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // plusRes
            // 
            this.plusRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRes.Location = new System.Drawing.Point(468, 135);
            this.plusRes.Name = "plusRes";
            this.plusRes.Size = new System.Drawing.Size(101, 22);
            this.plusRes.TabIndex = 20;
            // 
            // minRes
            // 
            this.minRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minRes.Location = new System.Drawing.Point(468, 190);
            this.minRes.Name = "minRes";
            this.minRes.Size = new System.Drawing.Size(101, 22);
            this.minRes.TabIndex = 21;
            // 
            // mulRes
            // 
            this.mulRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulRes.Location = new System.Drawing.Point(468, 242);
            this.mulRes.Name = "mulRes";
            this.mulRes.Size = new System.Drawing.Size(101, 22);
            this.mulRes.TabIndex = 22;
            // 
            // divRes
            // 
            this.divRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRes.Location = new System.Drawing.Point(468, 300);
            this.divRes.Name = "divRes";
            this.divRes.Size = new System.Drawing.Size(101, 22);
            this.divRes.TabIndex = 23;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(26, 43);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(122, 38);
            this.Back.TabIndex = 24;
            this.Back.Text = "Back to home";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.divRes);
            this.Controls.Add(this.mulRes);
            this.Controls.Add(this.minRes);
            this.Controls.Add(this.plusRes);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.divRight);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.divLeft);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mulRight);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mulLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.minRight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minLeft);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusLeft);
            this.Controls.Add(this.timeLeftLabel);
            this.Controls.Add(this.header);
            this.Name = "QuizPage";
            this.Text = "Quiz Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plusRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mulRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Label plusLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusRight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label minRight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label minLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label mulRight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label mulLeft;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label divRight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label divLeft;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.NumericUpDown plusRes;
        private System.Windows.Forms.NumericUpDown minRes;
        private System.Windows.Forms.NumericUpDown mulRes;
        private System.Windows.Forms.NumericUpDown divRes;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Back;
    }
}

