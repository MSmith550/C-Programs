namespace LearningApp
{
    partial class Math
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mathQuestionButton = new System.Windows.Forms.Button();
            this.mathAnswerButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lessGreaterQuestionButton = new System.Windows.Forms.Button();
            this.greaterThanButton = new System.Windows.Forms.Button();
            this.lessThanButton = new System.Windows.Forms.Button();
            this.wordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(304, 166);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(532, 63);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time for Some Math";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(302, 232);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(544, 115);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mathQuestionButton
            // 
            this.mathQuestionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mathQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mathQuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mathQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathQuestionButton.Location = new System.Drawing.Point(304, 466);
            this.mathQuestionButton.Name = "mathQuestionButton";
            this.mathQuestionButton.Size = new System.Drawing.Size(174, 44);
            this.mathQuestionButton.TabIndex = 12;
            this.mathQuestionButton.Text = "New Addition Question";
            this.mathQuestionButton.UseVisualStyleBackColor = false;
            this.mathQuestionButton.Click += new System.EventHandler(this.mathQuestionButton_Click);
            // 
            // mathAnswerButton
            // 
            this.mathAnswerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mathAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mathAnswerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mathAnswerButton.Enabled = false;
            this.mathAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathAnswerButton.Location = new System.Drawing.Point(501, 466);
            this.mathAnswerButton.Name = "mathAnswerButton";
            this.mathAnswerButton.Size = new System.Drawing.Size(174, 44);
            this.mathAnswerButton.TabIndex = 13;
            this.mathAnswerButton.Text = "Addition Answer";
            this.mathAnswerButton.UseVisualStyleBackColor = false;
            this.mathAnswerButton.Click += new System.EventHandler(this.mathAnswerButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(401, 678);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(363, 45);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "Back to Main Menu";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(304, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 43);
            this.button3.TabIndex = 15;
            this.button3.Text = "New Subtraction Question";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.subtractionButton_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(501, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 43);
            this.button4.TabIndex = 16;
            this.button4.Text = "Subtraction Answer";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.subtractionAnswer_Click);
            // 
            // lessGreaterQuestionButton
            // 
            this.lessGreaterQuestionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessGreaterQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lessGreaterQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessGreaterQuestionButton.Location = new System.Drawing.Point(304, 590);
            this.lessGreaterQuestionButton.Name = "lessGreaterQuestionButton";
            this.lessGreaterQuestionButton.Size = new System.Drawing.Size(174, 41);
            this.lessGreaterQuestionButton.TabIndex = 17;
            this.lessGreaterQuestionButton.Text = "New Less/Greater Question";
            this.lessGreaterQuestionButton.UseVisualStyleBackColor = false;
            this.lessGreaterQuestionButton.Click += new System.EventHandler(this.lessGreaterQuestionButton_Click);
            // 
            // greaterThanButton
            // 
            this.greaterThanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greaterThanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greaterThanButton.Enabled = false;
            this.greaterThanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greaterThanButton.Location = new System.Drawing.Point(501, 590);
            this.greaterThanButton.Name = "greaterThanButton";
            this.greaterThanButton.Size = new System.Drawing.Size(107, 41);
            this.greaterThanButton.TabIndex = 18;
            this.greaterThanButton.Text = "Greater Than >";
            this.greaterThanButton.UseVisualStyleBackColor = false;
            this.greaterThanButton.Click += new System.EventHandler(this.greaterThanButton_Click);
            // 
            // lessThanButton
            // 
            this.lessThanButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lessThanButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lessThanButton.Enabled = false;
            this.lessThanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessThanButton.Location = new System.Drawing.Point(614, 590);
            this.lessThanButton.Name = "lessThanButton";
            this.lessThanButton.Size = new System.Drawing.Size(118, 41);
            this.lessThanButton.TabIndex = 19;
            this.lessThanButton.Text = "Less Than <";
            this.lessThanButton.UseVisualStyleBackColor = false;
            this.lessThanButton.Click += new System.EventHandler(this.lessThanButton_Click);
            // 
            // wordButton
            // 
            this.wordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.wordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordButton.Location = new System.Drawing.Point(701, 466);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(147, 44);
            this.wordButton.TabIndex = 20;
            this.wordButton.Text = "Word Question";
            this.wordButton.UseVisualStyleBackColor = false;
            this.wordButton.Click += new System.EventHandler(this.wordButton_Click);
            // 
            // Math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningApp.Properties.Resources.MathSceneBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 795);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.lessThanButton);
            this.Controls.Add(this.greaterThanButton);
            this.Controls.Add(this.lessGreaterQuestionButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mathAnswerButton);
            this.Controls.Add(this.mathQuestionButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Math";
            this.Text = "Math";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button mathQuestionButton;
        private System.Windows.Forms.Button mathAnswerButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button lessGreaterQuestionButton;
        private System.Windows.Forms.Button greaterThanButton;
        private System.Windows.Forms.Button lessThanButton;
        private System.Windows.Forms.Button wordButton;
    }
}