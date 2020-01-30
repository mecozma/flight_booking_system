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
            this.company_motto = new System.Windows.Forms.Label();
            this.book_flights_button = new System.Windows.Forms.Button();
            this.adminUser = new System.Windows.Forms.Button();
            this.logo_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // company_motto
            // 
            this.company_motto.AutoSize = true;
            this.company_motto.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.company_motto.Location = new System.Drawing.Point(263, 231);
            this.company_motto.Name = "company_motto";
            this.company_motto.Size = new System.Drawing.Size(429, 21);
            this.company_motto.TabIndex = 0;
            this.company_motto.Text = "Is Cyanair the best company to fly with? You bet it is!";
            // 
            // book_flights_button
            // 
            this.book_flights_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.book_flights_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.book_flights_button.FlatAppearance.BorderSize = 2;
            this.book_flights_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.book_flights_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.book_flights_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.book_flights_button.Location = new System.Drawing.Point(324, 391);
            this.book_flights_button.Name = "book_flights_button";
            this.book_flights_button.Size = new System.Drawing.Size(103, 39);
            this.book_flights_button.TabIndex = 1;
            this.book_flights_button.Text = "Book flights";
            this.book_flights_button.UseVisualStyleBackColor = false;
            this.book_flights_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminUser
            // 
            this.adminUser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.adminUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.adminUser.FlatAppearance.BorderSize = 2;
            this.adminUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.adminUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.adminUser.Location = new System.Drawing.Point(507, 391);
            this.adminUser.Name = "adminUser";
            this.adminUser.Size = new System.Drawing.Size(103, 39);
            this.adminUser.TabIndex = 2;
            this.adminUser.Text = "Admin user";
            this.adminUser.UseVisualStyleBackColor = false;
            this.adminUser.Click += new System.EventHandler(this.adminUser_Click);
            // 
            // logo_label
            // 
            this.logo_label.AutoSize = true;
            this.logo_label.Font = new System.Drawing.Font("Monotype Corsiva", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.logo_label.Location = new System.Drawing.Point(12, 9);
            this.logo_label.Name = "logo_label";
            this.logo_label.Size = new System.Drawing.Size(147, 51);
            this.logo_label.TabIndex = 3;
            this.logo_label.Text = "CyanAir";
            // 
            // firstView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(965, 525);
            this.Controls.Add(this.logo_label);
            this.Controls.Add(this.adminUser);
            this.Controls.Add(this.book_flights_button);
            this.Controls.Add(this.company_motto);
            this.Name = "firstView";
            this.Text = "Welcome view";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label company_motto;
        private System.Windows.Forms.Button book_flights_button;
        private System.Windows.Forms.Button adminUser;
        private System.Windows.Forms.Label logo_label;
    }
}

