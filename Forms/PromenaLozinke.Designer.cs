namespace RentACar
{
    partial class PromenaLozinke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromenaLozinke));
            this.naslov = new System.Windows.Forms.Label();
            this.promeni = new System.Windows.Forms.Button();
            this.SifraPlaceholder = new System.Windows.Forms.Label();
            this.oldPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sigurnosniKOD = new System.Windows.Forms.TextBox();
            this.errorText = new System.Windows.Forms.Label();
            this.seePW1 = new System.Windows.Forms.Button();
            this.seePW2 = new System.Windows.Forms.Button();
            this.seePW3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // naslov
            // 
            this.naslov.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.naslov.BackColor = System.Drawing.Color.Transparent;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.Location = new System.Drawing.Point(31, 9);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(511, 43);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "Promena lozinke";
            this.naslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promeni
            // 
            this.promeni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.promeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promeni.Location = new System.Drawing.Point(209, 248);
            this.promeni.Name = "promeni";
            this.promeni.Size = new System.Drawing.Size(150, 50);
            this.promeni.TabIndex = 1;
            this.promeni.Text = "Promeni loznku";
            this.promeni.UseVisualStyleBackColor = true;
            this.promeni.Click += new System.EventHandler(this.promeni_Click);
            // 
            // SifraPlaceholder
            // 
            this.SifraPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SifraPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.SifraPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SifraPlaceholder.Location = new System.Drawing.Point(29, 84);
            this.SifraPlaceholder.Name = "SifraPlaceholder";
            this.SifraPlaceholder.Size = new System.Drawing.Size(245, 18);
            this.SifraPlaceholder.TabIndex = 5;
            this.SifraPlaceholder.Text = "Unesite staru lozinku";
            this.SifraPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oldPW
            // 
            this.oldPW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.oldPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPW.Location = new System.Drawing.Point(29, 105);
            this.oldPW.MaxLength = 40;
            this.oldPW.Name = "oldPW";
            this.oldPW.Size = new System.Drawing.Size(245, 22);
            this.oldPW.TabIndex = 4;
            this.oldPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.oldPW.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unesite novu lozinku";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPW
            // 
            this.newPW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.newPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPW.Location = new System.Drawing.Point(297, 105);
            this.newPW.MaxLength = 40;
            this.newPW.Name = "newPW";
            this.newPW.Size = new System.Drawing.Size(245, 22);
            this.newPW.TabIndex = 6;
            this.newPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPW.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ponovite novu lozinku";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repPW
            // 
            this.repPW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.repPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repPW.Location = new System.Drawing.Point(297, 161);
            this.repPW.MaxLength = 40;
            this.repPW.Name = "repPW";
            this.repPW.Size = new System.Drawing.Size(245, 22);
            this.repPW.TabIndex = 8;
            this.repPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repPW.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Unesite sigurnosni kod";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sigurnosniKOD
            // 
            this.sigurnosniKOD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sigurnosniKOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sigurnosniKOD.Location = new System.Drawing.Point(29, 161);
            this.sigurnosniKOD.MaxLength = 40;
            this.sigurnosniKOD.Name = "sigurnosniKOD";
            this.sigurnosniKOD.Size = new System.Drawing.Size(245, 22);
            this.sigurnosniKOD.TabIndex = 10;
            this.sigurnosniKOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorText
            // 
            this.errorText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.errorText.BackColor = System.Drawing.Color.Transparent;
            this.errorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Brown;
            this.errorText.Location = new System.Drawing.Point(56, 203);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(460, 33);
            this.errorText.TabIndex = 12;
            this.errorText.Text = "greška greška 123";
            this.errorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // seePW1
            // 
            this.seePW1.BackColor = System.Drawing.Color.Transparent;
            this.seePW1.BackgroundImage = global::RentACar.Properties.Resources.oko;
            this.seePW1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seePW1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePW1.Location = new System.Drawing.Point(520, 105);
            this.seePW1.Name = "seePW1";
            this.seePW1.Size = new System.Drawing.Size(22, 22);
            this.seePW1.TabIndex = 13;
            this.seePW1.UseVisualStyleBackColor = false;
            this.seePW1.Click += new System.EventHandler(this.seePW1_Click);
            // 
            // seePW2
            // 
            this.seePW2.BackColor = System.Drawing.Color.Transparent;
            this.seePW2.BackgroundImage = global::RentACar.Properties.Resources.oko;
            this.seePW2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seePW2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePW2.Location = new System.Drawing.Point(520, 161);
            this.seePW2.Name = "seePW2";
            this.seePW2.Size = new System.Drawing.Size(22, 22);
            this.seePW2.TabIndex = 14;
            this.seePW2.UseVisualStyleBackColor = false;
            this.seePW2.Click += new System.EventHandler(this.seePW2_Click);
            // 
            // seePW3
            // 
            this.seePW3.BackColor = System.Drawing.Color.Transparent;
            this.seePW3.BackgroundImage = global::RentACar.Properties.Resources.oko;
            this.seePW3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.seePW3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePW3.Location = new System.Drawing.Point(252, 105);
            this.seePW3.Name = "seePW3";
            this.seePW3.Size = new System.Drawing.Size(22, 22);
            this.seePW3.TabIndex = 15;
            this.seePW3.UseVisualStyleBackColor = false;
            this.seePW3.Click += new System.EventHandler(this.seePW3_Click);
            // 
            // PromenaLozinke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RentACar.Properties.Resources.Background_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(573, 310);
            this.Controls.Add(this.seePW3);
            this.Controls.Add(this.seePW2);
            this.Controls.Add(this.seePW1);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sigurnosniKOD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.repPW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newPW);
            this.Controls.Add(this.SifraPlaceholder);
            this.Controls.Add(this.oldPW);
            this.Controls.Add(this.promeni);
            this.Controls.Add(this.naslov);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PromenaLozinke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promena lozinke";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button promeni;
        private System.Windows.Forms.Label SifraPlaceholder;
        private System.Windows.Forms.TextBox oldPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox repPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sigurnosniKOD;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Button seePW1;
        private System.Windows.Forms.Button seePW2;
        private System.Windows.Forms.Button seePW3;
    }
}