namespace Cyanair20012020
{
    partial class firstView
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
            this.button1 = new System.Windows.Forms.Button();
            this.adminUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Cyanair. Please select your access level below";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Book flights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminUser
            // 
            this.adminUser.Location = new System.Drawing.Point(330, 232);
            this.adminUser.Name = "adminUser";
            this.adminUser.Size = new System.Drawing.Size(75, 23);
            this.adminUser.TabIndex = 2;
            this.adminUser.Text = "Admin user";
            this.adminUser.UseVisualStyleBackColor = true;
            this.adminUser.Click += new System.EventHandler(this.adminUser_Click);
            // 
            // firstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 423);
            this.Controls.Add(this.adminUser);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "firstView";
            this.Text = "Welcome view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminUser;
    }
}

