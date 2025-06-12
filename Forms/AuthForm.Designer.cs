namespace RentACar
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.UsernamePlaceholder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.ErrorText = new System.Windows.Forms.Label();
            this.seePW = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Location = new System.Drawing.Point(150, 355);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(170, 54);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Prijavi se";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(109, 234);
            this.Username.MaxLength = 40;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(245, 22);
            this.Username.TabIndex = 2;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UsernamePlaceholder
            // 
            this.UsernamePlaceholder.AutoSize = true;
            this.UsernamePlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.UsernamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernamePlaceholder.Location = new System.Drawing.Point(184, 213);
            this.UsernamePlaceholder.Name = "UsernamePlaceholder";
            this.UsernamePlaceholder.Size = new System.Drawing.Size(98, 18);
            this.UsernamePlaceholder.TabIndex = 3;
            this.UsernamePlaceholder.Text = "Ime i Prezime";
            this.UsernamePlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lozinka";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(109, 286);
            this.Password.MaxLength = 40;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(245, 22);
            this.Password.TabIndex = 4;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.UseSystemPasswordChar = true;
            // 
            // ErrorText
            // 
            this.ErrorText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ErrorText.BackColor = System.Drawing.Color.Transparent;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.Brown;
            this.ErrorText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ErrorText.Location = new System.Drawing.Point(28, 325);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(414, 16);
            this.ErrorText.TabIndex = 6;
            this.ErrorText.Text = "Nešto nije ispravno!";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seePW
            // 
            this.seePW.BackColor = System.Drawing.Color.Transparent;
            this.seePW.BackgroundImage = global::RentACar.Properties.Resources.oko;
            this.seePW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seePW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePW.Location = new System.Drawing.Point(332, 286);
            this.seePW.Name = "seePW";
            this.seePW.Size = new System.Drawing.Size(22, 22);
            this.seePW.TabIndex = 7;
            this.seePW.UseVisualStyleBackColor = false;
            this.seePW.Click += new System.EventHandler(this.seePW_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RentACar.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 421);
            this.Controls.Add(this.seePW);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UsernamePlaceholder);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijavljivanje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label UsernamePlaceholder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Button seePW;
    }
}

