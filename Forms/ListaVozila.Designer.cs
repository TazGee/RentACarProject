namespace RentACar
{
    partial class ListaVozila
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaVozila));
            this.glavniPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listaVozilaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.filersPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.dodajVozilo = new System.Windows.Forms.Button();
            this.filteriNaslov = new System.Windows.Forms.Label();
            this.manuelni = new System.Windows.Forms.CheckBox();
            this.automatski = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.glavniPanel1.SuspendLayout();
            this.filersPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glavniPanel1
            // 
            this.glavniPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.glavniPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.glavniPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.glavniPanel1.ColumnCount = 1;
            this.glavniPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.glavniPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.glavniPanel1.Controls.Add(this.listaVozilaPanel, 0, 1);
            this.glavniPanel1.Controls.Add(this.filersPanel, 0, 0);
            this.glavniPanel1.Location = new System.Drawing.Point(0, 0);
            this.glavniPanel1.Name = "glavniPanel1";
            this.glavniPanel1.RowCount = 2;
            this.glavniPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29947F));
            this.glavniPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.70053F));
            this.glavniPanel1.Size = new System.Drawing.Size(984, 561);
            this.glavniPanel1.TabIndex = 0;
            // 
            // listaVozilaPanel
            // 
            this.listaVozilaPanel.AutoScroll = true;
            this.listaVozilaPanel.AutoSize = true;
            this.listaVozilaPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listaVozilaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.listaVozilaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listaVozilaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaVozilaPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listaVozilaPanel.Location = new System.Drawing.Point(3, 72);
            this.listaVozilaPanel.Name = "listaVozilaPanel";
            this.listaVozilaPanel.Padding = new System.Windows.Forms.Padding(10);
            this.listaVozilaPanel.Size = new System.Drawing.Size(978, 486);
            this.listaVozilaPanel.TabIndex = 0;
            this.listaVozilaPanel.WrapContents = false;
            // 
            // filersPanel
            // 
            this.filersPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filersPanel.Controls.Add(this.panel1);
            this.filersPanel.Controls.Add(this.dodajVozilo);
            this.filersPanel.Controls.Add(this.filteriNaslov);
            this.filersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filersPanel.Location = new System.Drawing.Point(3, 3);
            this.filersPanel.Name = "filersPanel";
            this.filersPanel.Size = new System.Drawing.Size(978, 63);
            this.filersPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::RentACar.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(538, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv vozila";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // search
            // 
            this.search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(285, 24);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(247, 24);
            this.search.TabIndex = 2;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dodajVozilo
            // 
            this.dodajVozilo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dodajVozilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajVozilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajVozilo.Location = new System.Drawing.Point(825, 9);
            this.dodajVozilo.Name = "dodajVozilo";
            this.dodajVozilo.Size = new System.Drawing.Size(144, 41);
            this.dodajVozilo.TabIndex = 1;
            this.dodajVozilo.Text = "Dodaj Vozilo";
            this.dodajVozilo.UseVisualStyleBackColor = false;
            this.dodajVozilo.Click += new System.EventHandler(this.dodajVozilo_Click_1);
            // 
            // filteriNaslov
            // 
            this.filteriNaslov.BackColor = System.Drawing.Color.Transparent;
            this.filteriNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteriNaslov.Location = new System.Drawing.Point(3, 0);
            this.filteriNaslov.Name = "filteriNaslov";
            this.filteriNaslov.Size = new System.Drawing.Size(183, 50);
            this.filteriNaslov.TabIndex = 0;
            this.filteriNaslov.Text = "Lista vozila:";
            this.filteriNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // manuelni
            // 
            this.manuelni.AutoSize = true;
            this.manuelni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manuelni.Location = new System.Drawing.Point(78, 25);
            this.manuelni.Name = "manuelni";
            this.manuelni.Size = new System.Drawing.Size(86, 22);
            this.manuelni.TabIndex = 12;
            this.manuelni.Text = "Manuelni";
            this.manuelni.UseVisualStyleBackColor = true;
            // 
            // automatski
            // 
            this.automatski.AutoSize = true;
            this.automatski.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automatski.Location = new System.Drawing.Point(170, 26);
            this.automatski.Name = "automatski";
            this.automatski.Size = new System.Drawing.Size(101, 22);
            this.automatski.TabIndex = 13;
            this.automatski.Text = "Automatski";
            this.automatski.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tip menjača";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.automatski);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.manuelni);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(171, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 54);
            this.panel1.TabIndex = 15;
            // 
            // ListaVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.glavniPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ListaVozila";
            this.Text = "Lista vozila";
            this.glavniPanel1.ResumeLayout(false);
            this.glavniPanel1.PerformLayout();
            this.filersPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel glavniPanel1;
        private System.Windows.Forms.FlowLayoutPanel listaVozilaPanel;
        private System.Windows.Forms.Panel filersPanel;
        private System.Windows.Forms.Label filteriNaslov;
        private System.Windows.Forms.Button dodajVozilo;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox manuelni;
        private System.Windows.Forms.CheckBox automatski;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}