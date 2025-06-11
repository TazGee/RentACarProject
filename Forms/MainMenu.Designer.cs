namespace RentACar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.profilePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ListVozila = new System.Windows.Forms.Button();
            this.istorijaRacunaButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilePanel.AutoSize = true;
            this.profilePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profilePanel.BackColor = System.Drawing.Color.LightGray;
            this.profilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePanel.Controls.Add(this.profilePicture);
            this.profilePanel.Controls.Add(this.nameLabel);
            this.profilePanel.Location = new System.Drawing.Point(1006, 12);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(166, 58);
            this.profilePanel.TabIndex = 2;
            this.profilePanel.Click += new System.EventHandler(this.UserPanelClick);
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.profilePicture.BackColor = System.Drawing.Color.Transparent;
            this.profilePicture.BackgroundImage = global::RentACar.Properties.Resources.user_icon;
            this.profilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePicture.ErrorImage = global::RentACar.Properties.Resources.user_icon;
            this.profilePicture.InitialImage = global::RentACar.Properties.Resources.user_icon;
            this.profilePicture.Location = new System.Drawing.Point(3, 3);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(50, 50);
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(59, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(102, 36);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "\r\nNikola Tasic";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = global::RentACar.Properties.Resources.IznajmiButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(400, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 200);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ListVozila
            // 
            this.ListVozila.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ListVozila.AutoSize = true;
            this.ListVozila.BackgroundImage = global::RentACar.Properties.Resources.ListaVozilaButton;
            this.ListVozila.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ListVozila.FlatAppearance.BorderSize = 2;
            this.ListVozila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListVozila.Location = new System.Drawing.Point(180, 220);
            this.ListVozila.Name = "ListVozila";
            this.ListVozila.Size = new System.Drawing.Size(400, 200);
            this.ListVozila.TabIndex = 3;
            this.ListVozila.UseVisualStyleBackColor = true;
            this.ListVozila.Click += new System.EventHandler(this.ListVozila_Click);
            // 
            // istorijaRacunaButton
            // 
            this.istorijaRacunaButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.istorijaRacunaButton.AutoSize = true;
            this.istorijaRacunaButton.BackgroundImage = global::RentACar.Properties.Resources.IstorijaIznajmljivanjaButton;
            this.istorijaRacunaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.istorijaRacunaButton.FlatAppearance.BorderSize = 2;
            this.istorijaRacunaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.istorijaRacunaButton.Location = new System.Drawing.Point(620, 220);
            this.istorijaRacunaButton.Name = "istorijaRacunaButton";
            this.istorijaRacunaButton.Size = new System.Drawing.Size(400, 200);
            this.istorijaRacunaButton.TabIndex = 4;
            this.istorijaRacunaButton.UseVisualStyleBackColor = true;
            this.istorijaRacunaButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::RentACar.Properties.Resources.RENT_A_CAR;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(350, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(500, 205);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(12, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(151, 55);
            this.TimeLabel.TabIndex = 6;
            this.TimeLabel.Text = "22:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateLabel
            // 
            this.DateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(12, 54);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(160, 34);
            this.DateLabel.TabIndex = 7;
            this.DateLabel.Text = "31.12.2004.";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(500, 666);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(200, 15);
            this.versionLabel.TabIndex = 8;
            this.versionLabel.Text = "Verzija 1.1.0.25.5.23 by Tasić";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::RentACar.Properties.Resources.Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 690);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ListVozila);
            this.Controls.Add(this.istorijaRacunaButton);
            this.Controls.Add(this.profilePanel);
            this.Controls.Add(this.logo);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glavni Meni";
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion


        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.FlowLayoutPanel profilePanel;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button ListVozila;
        private System.Windows.Forms.Button istorijaRacunaButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}