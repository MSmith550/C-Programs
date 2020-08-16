namespace LearningApp
{
    partial class MainMenu
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
            this.soundButton = new System.Windows.Forms.Button();
            this.wordButton = new System.Windows.Forms.Button();
            this.numberButton = new System.Windows.Forms.Button();
            this.mathButton = new System.Windows.Forms.Button();
            this.sentenceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soundButton
            // 
            this.soundButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.soundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundButton.Location = new System.Drawing.Point(208, 211);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(174, 92);
            this.soundButton.TabIndex = 0;
            this.soundButton.Text = "Sounds";
            this.soundButton.UseVisualStyleBackColor = false;
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            // 
            // wordButton
            // 
            this.wordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.wordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordButton.Location = new System.Drawing.Point(418, 211);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(174, 92);
            this.wordButton.TabIndex = 1;
            this.wordButton.Text = "Words";
            this.wordButton.UseVisualStyleBackColor = false;
            this.wordButton.Click += new System.EventHandler(this.wordButton_Click);
            // 
            // numberButton
            // 
            this.numberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numberButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.numberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberButton.Location = new System.Drawing.Point(303, 327);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(174, 92);
            this.numberButton.TabIndex = 2;
            this.numberButton.Text = "Numbers";
            this.numberButton.UseVisualStyleBackColor = false;
            this.numberButton.Click += new System.EventHandler(this.numberButton_Click);
            // 
            // mathButton
            // 
            this.mathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mathButton.Location = new System.Drawing.Point(522, 327);
            this.mathButton.Name = "mathButton";
            this.mathButton.Size = new System.Drawing.Size(174, 92);
            this.mathButton.TabIndex = 3;
            this.mathButton.Text = "Math";
            this.mathButton.UseVisualStyleBackColor = false;
            this.mathButton.Click += new System.EventHandler(this.mathButton_Click);
            // 
            // sentenceButton
            // 
            this.sentenceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sentenceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sentenceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceButton.Location = new System.Drawing.Point(626, 211);
            this.sentenceButton.Name = "sentenceButton";
            this.sentenceButton.Size = new System.Drawing.Size(174, 92);
            this.sentenceButton.TabIndex = 4;
            this.sentenceButton.Text = "Sentences";
            this.sentenceButton.UseVisualStyleBackColor = false;
            this.sentenceButton.Click += new System.EventHandler(this.sentenceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(978, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome To The Learning Application";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LearningApp.Properties.Resources.MainMenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sentenceButton);
            this.Controls.Add(this.mathButton);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.soundButton);
            this.DoubleBuffered = true;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soundButton;
        private System.Windows.Forms.Button wordButton;
        private System.Windows.Forms.Button numberButton;
        private System.Windows.Forms.Button mathButton;
        private System.Windows.Forms.Button sentenceButton;
        private System.Windows.Forms.Label label1;
    }
}

