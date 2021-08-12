namespace InventoryProgramV1
{
    partial class SelectScreen
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
            this.userName = new System.Windows.Forms.Label();
            this.selectTableComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newTable = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(72, 24);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(0, 26);
            this.userName.TabIndex = 0;
            // 
            // selectTableComboBox
            // 
            this.selectTableComboBox.FormattingEnabled = true;
            this.selectTableComboBox.Location = new System.Drawing.Point(77, 135);
            this.selectTableComboBox.Name = "selectTableComboBox";
            this.selectTableComboBox.Size = new System.Drawing.Size(175, 21);
            this.selectTableComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Dept";
            // 
            // newTable
            // 
            this.newTable.Location = new System.Drawing.Point(80, 251);
            this.newTable.Name = "newTable";
            this.newTable.Size = new System.Drawing.Size(109, 34);
            this.newTable.TabIndex = 4;
            this.newTable.Text = "New Dept";
            this.newTable.UseVisualStyleBackColor = true;
            this.newTable.Click += new System.EventHandler(this.newTable_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(77, 343);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(278, 343);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // SelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.newTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectTableComboBox);
            this.Controls.Add(this.userName);
            this.Name = "SelectScreen";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.ComboBox selectTableComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newTable;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button selectButton;
    }
}