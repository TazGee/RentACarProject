namespace RentACar
{
    partial class IstorijaRacuna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstorijaRacuna));
            this.glavniPanelZaRacune = new System.Windows.Forms.TableLayoutPanel();
            this.listaRacunaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filteriNaslov = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nazivVozila = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aktivni = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.imeText = new System.Windows.Forms.TextBox();
            this.glavniPanelZaRacune.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniPanelZaRacune
            // 
            this.glavniPanelZaRacune.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.glavniPanelZaRacune.BackColor = System.Drawing.Color.Gainsboro;
            this.glavniPanelZaRacune.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.glavniPanelZaRacune.ColumnCount = 1;
            this.glavniPanelZaRacune.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.glavniPanelZaRacune.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.glavniPanelZaRacune.Controls.Add(this.listaRacunaPanel, 0, 1);
            this.glavniPanelZaRacune.Controls.Add(this.headerPanel, 0, 0);
            this.glavniPanelZaRacune.Location = new System.Drawing.Point(1, 0);
            this.glavniPanelZaRacune.Name = "glavniPanelZaRacune";
            this.glavniPanelZaRacune.RowCount = 2;
            this.glavniPanelZaRacune.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29947F));
            this.glavniPanelZaRacune.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.70053F));
            this.glavniPanelZaRacune.Size = new System.Drawing.Size(984, 561);
            this.glavniPanelZaRacune.TabIndex = 1;
            // 
            // listaRacunaPanel
            // 
            this.listaRacunaPanel.AutoScroll = true;
            this.listaRacunaPanel.AutoSize = true;
            this.listaRacunaPanel.BackColor = System.Drawing.Color.White;
            this.listaRacunaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listaRacunaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaRacunaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaRacunaPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listaRacunaPanel.Location = new System.Drawing.Point(3, 72);
            this.listaRacunaPanel.Name = "listaRacunaPanel";
            this.listaRacunaPanel.Padding = new System.Windows.Forms.Padding(10);
            this.listaRacunaPanel.Size = new System.Drawing.Size(978, 486);
            this.listaRacunaPanel.TabIndex = 0;
            this.listaRacunaPanel.WrapContents = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.filteriNaslov);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(978, 63);
            this.headerPanel.TabIndex = 1;
            // 
            // filteriNaslov
            // 
            this.filteriNaslov.BackColor = System.Drawing.Color.Transparent;
            this.filteriNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteriNaslov.Location = new System.Drawing.Point(3, 0);
            this.filteriNaslov.Name = "filteriNaslov";
            this.filteriNaslov.Size = new System.Drawing.Size(214, 57);
            this.filteriNaslov.TabIndex = 1;
            this.filteriNaslov.Text = "Istorija računa:";
            this.filteriNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nazivVozila);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.aktivni);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.imeText);
            this.panel1.Location = new System.Drawing.Point(223, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 56);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Naziv vozila";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nazivVozila
            // 
            this.nazivVozila.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nazivVozila.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazivVozila.Location = new System.Drawing.Point(183, 25);
            this.nazivVozila.Name = "nazivVozila";
            this.nazivVozila.Size = new System.Drawing.Size(233, 24);
            this.nazivVozila.TabIndex = 18;
            this.nazivVozila.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Aktivnost";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // aktivni
            // 
            this.aktivni.AutoSize = true;
            this.aktivni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktivni.Location = new System.Drawing.Point(16, 27);
            this.aktivni.Name = "aktivni";
            this.aktivni.Size = new System.Drawing.Size(156, 22);
            this.aktivni.TabIndex = 16;
            this.aktivni.Text = "Samo aktivni računi";
            this.aktivni.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RentACar.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(688, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ime mušterije";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imeText
            // 
            this.imeText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imeText.Location = new System.Drawing.Point(425, 25);
            this.imeText.Name = "imeText";
            this.imeText.Size = new System.Drawing.Size(247, 24);
            this.imeText.TabIndex = 8;
            this.imeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IstorijaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.glavniPanelZaRacune);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "IstorijaRacuna";
            this.Text = "Istorija Racuna";
            this.glavniPanelZaRacune.ResumeLayout(false);
            this.glavniPanelZaRacune.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel glavniPanelZaRacune;
        private System.Windows.Forms.FlowLayoutPanel listaRacunaPanel;
        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.Label filteriNaslov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox aktivni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nazivVozila;
    }
}