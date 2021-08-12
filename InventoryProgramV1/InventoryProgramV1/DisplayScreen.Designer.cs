namespace InventoryProgramV1
{
    partial class DisplayScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.upcBox = new System.Windows.Forms.TextBox();
            this.stockBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemID = new System.Windows.Forms.Label();
            this.itemIDBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 270);
            this.dataGridView1.TabIndex = 6;
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(138, 486);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(259, 20);
            this.itemBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(50, 600);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item Name";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(48, 40);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 20);
            this.userName.TabIndex = 7;
            this.userName.Text = "label1";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(51, 388);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(85, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Item";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(165, 388);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(88, 23);
            this.removeBtn.TabIndex = 9;
            this.removeBtn.Text = "Remove item";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // upcBox
            // 
            this.upcBox.Location = new System.Drawing.Point(138, 521);
            this.upcBox.Name = "upcBox";
            this.upcBox.Size = new System.Drawing.Size(259, 20);
            this.upcBox.TabIndex = 10;
            // 
            // stockBox
            // 
            this.stockBox.Location = new System.Drawing.Point(138, 558);
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(259, 20);
            this.stockBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "UPC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 561);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "In Stock Amount";
            // 
            // itemID
            // 
            this.itemID.AutoSize = true;
            this.itemID.Location = new System.Drawing.Point(49, 429);
            this.itemID.Name = "itemID";
            this.itemID.Size = new System.Drawing.Size(58, 13);
            this.itemID.TabIndex = 14;
            this.itemID.Text = "Item Name";
            // 
            // itemIDBox
            // 
            this.itemIDBox.Location = new System.Drawing.Point(138, 426);
            this.itemIDBox.Name = "itemIDBox";
            this.itemIDBox.Size = new System.Drawing.Size(259, 20);
            this.itemIDBox.TabIndex = 15;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(162, 449);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(222, 13);
            this.messageLabel.TabIndex = 16;
            this.messageLabel.Text = "Item ID only used for REMOVING item";
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.Location = new System.Drawing.Point(266, 40);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(57, 20);
            this.tableName.TabIndex = 17;
            this.tableName.Text = "label1";
            // 
            // DisplayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(602, 637);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.itemIDBox);
            this.Controls.Add(this.itemID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.upcBox);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Name = "DisplayScreen";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.TextBox upcBox;
        private System.Windows.Forms.TextBox stockBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemID;
        private System.Windows.Forms.TextBox itemIDBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label tableName;
    }
}