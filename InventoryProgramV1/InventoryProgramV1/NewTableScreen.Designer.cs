namespace InventoryProgramV1
{
    partial class NewTableScreen
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
            this.tableName = new System.Windows.Forms.Label();
            this.tableNameBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.saveColumnButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(25, 9);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(57, 20);
            this.userName.TabIndex = 0;
            this.userName.Text = "label1";
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Location = new System.Drawing.Point(219, 65);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(93, 13);
            this.tableName.TabIndex = 1;
            this.tableName.Text = "Department Name";
            // 
            // tableNameBox
            // 
            this.tableNameBox.Location = new System.Drawing.Point(212, 81);
            this.tableNameBox.Name = "tableNameBox";
            this.tableNameBox.Size = new System.Drawing.Size(100, 20);
            this.tableNameBox.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backButton.AutoSize = true;
            this.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backButton.Location = new System.Drawing.Point(29, 452);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(42, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // saveColumnButton
            // 
            this.saveColumnButton.Location = new System.Drawing.Point(204, 452);
            this.saveColumnButton.Name = "saveColumnButton";
            this.saveColumnButton.Size = new System.Drawing.Size(108, 23);
            this.saveColumnButton.TabIndex = 9;
            this.saveColumnButton.Text = "Save Department";
            this.saveColumnButton.UseVisualStyleBackColor = true;
            this.saveColumnButton.Click += new System.EventHandler(this.saveColumnButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // tableMessage
            // 
            this.tableMessage.AutoSize = true;
            this.tableMessage.Enabled = false;
            this.tableMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableMessage.Location = new System.Drawing.Point(98, 136);
            this.tableMessage.Name = "tableMessage";
            this.tableMessage.Size = new System.Drawing.Size(0, 20);
            this.tableMessage.TabIndex = 12;
            // 
            // NewTableScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(603, 510);
            this.Controls.Add(this.tableMessage);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.saveColumnButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tableNameBox);
            this.Controls.Add(this.tableName);
            this.Controls.Add(this.userName);
            this.Name = "NewTableScreen";
            this.Text = "New Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.TextBox tableNameBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button saveColumnButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label tableMessage;
    }
}