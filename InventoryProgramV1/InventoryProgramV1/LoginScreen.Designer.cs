namespace InventoryProgramV1
{
    partial class loginScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.Label();
            this.newUser = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.errorMessageText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "New User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(234, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.Location = new System.Drawing.Point(280, 134);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(132, 26);
            this.userName.TabIndex = 2;
            this.userName.Text = "User Name";
            // 
            // newUser
            // 
            this.newUser.AutoSize = true;
            this.newUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUser.Location = new System.Drawing.Point(280, 293);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(116, 26);
            this.newUser.TabIndex = 3;
            this.newUser.Text = "New User";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(97, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(536, 71);
            this.Title.TabIndex = 4;
            this.Title.Text = "Inventory Program";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(299, 202);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 5;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // errorMessageText
            // 
            this.errorMessageText.AutoSize = true;
            this.errorMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageText.Location = new System.Drawing.Point(234, 253);
            this.errorMessageText.Name = "errorMessageText";
            this.errorMessageText.Size = new System.Drawing.Size(0, 20);
            this.errorMessageText.TabIndex = 6;
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.errorMessageText);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "loginScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label newUser;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label errorMessageText;
    }
}

