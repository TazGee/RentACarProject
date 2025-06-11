namespace RentACar
{
    partial class ProfileForm
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ImeiPrezimeLabel = new System.Windows.Forms.Label();
            this.promenaLozinke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pozicijaPlaceholder = new System.Windows.Forms.Label();
            this.pozicijaLabel = new System.Windows.Forms.Label();
            this.changeImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LogoutButton.BackColor = System.Drawing.Color.White;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.Location = new System.Drawing.Point(166, 121);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(120, 37);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Text = "Odjavi se";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ImeiPrezimeLabel
            // 
            this.ImeiPrezimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ImeiPrezimeLabel.AutoSize = true;
            this.ImeiPrezimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ImeiPrezimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeiPrezimeLabel.Location = new System.Drawing.Point(127, 32);
            this.ImeiPrezimeLabel.Name = "ImeiPrezimeLabel";
            this.ImeiPrezimeLabel.Size = new System.Drawing.Size(200, 24);
            this.ImeiPrezimeLabel.TabIndex = 1;
            this.ImeiPrezimeLabel.Text = "Imenko Prezimenkovic";
            // 
            // promenaLozinke
            // 
            this.promenaLozinke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.promenaLozinke.BackColor = System.Drawing.Color.White;
            this.promenaLozinke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promenaLozinke.Location = new System.Drawing.Point(12, 129);
            this.promenaLozinke.Name = "promenaLozinke";
            this.promenaLozinke.Size = new System.Drawing.Size(100, 23);
            this.promenaLozinke.TabIndex = 3;
            this.promenaLozinke.Text = "Promena Lozinke";
            this.promenaLozinke.UseVisualStyleBackColor = false;
            this.promenaLozinke.Click += new System.EventHandler(this.promenaLozinke_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime i prezime:";
            // 
            // pozicijaPlaceholder
            // 
            this.pozicijaPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pozicijaPlaceholder.AutoSize = true;
            this.pozicijaPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.pozicijaPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pozicijaPlaceholder.Location = new System.Drawing.Point(127, 65);
            this.pozicijaPlaceholder.Name = "pozicijaPlaceholder";
            this.pozicijaPlaceholder.Size = new System.Drawing.Size(112, 20);
            this.pozicijaPlaceholder.TabIndex = 7;
            this.pozicijaPlaceholder.Text = "Uloga/Pozicija:";
            // 
            // pozicijaLabel
            // 
            this.pozicijaLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pozicijaLabel.AutoSize = true;
            this.pozicijaLabel.BackColor = System.Drawing.Color.Transparent;
            this.pozicijaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pozicijaLabel.Location = new System.Drawing.Point(127, 85);
            this.pozicijaLabel.Name = "pozicijaLabel";
            this.pozicijaLabel.Size = new System.Drawing.Size(119, 24);
            this.pozicijaLabel.TabIndex = 6;
            this.pozicijaLabel.Text = "Administrator";
            // 
            // changeImage
            // 
            this.changeImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.changeImage.BackColor = System.Drawing.Color.Transparent;
            this.changeImage.BackgroundImage = global::RentACar.Properties.Resources.user_icon;
            this.changeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeImage.Location = new System.Drawing.Point(12, 12);
            this.changeImage.Name = "changeImage";
            this.changeImage.Size = new System.Drawing.Size(100, 100);
            this.changeImage.TabIndex = 9;
            this.changeImage.UseVisualStyleBackColor = false;
            this.changeImage.Click += new System.EventHandler(this.changeImage_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::RentACar.Properties.Resources.Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(437, 170);
            this.Controls.Add(this.changeImage);
            this.Controls.Add(this.pozicijaPlaceholder);
            this.Controls.Add(this.pozicijaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.promenaLozinke);
            this.Controls.Add(this.ImeiPrezimeLabel);
            this.Controls.Add(this.LogoutButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnik";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label ImeiPrezimeLabel;
        private System.Windows.Forms.Button promenaLozinke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pozicijaPlaceholder;
        private System.Windows.Forms.Label pozicijaLabel;
        private System.Windows.Forms.Button changeImage;
    }
}