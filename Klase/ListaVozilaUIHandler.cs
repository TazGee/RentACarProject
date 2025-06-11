using RentACar.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace RentACar.Klase
{
    class ListaVozilaUIHandler
    {
        public List<object> listaSvihObjekata;
        public FlowLayoutPanel listaVozilaPanel;

        public ListaVozilaUIHandler(List<object> listaSvihObjekata, FlowLayoutPanel listaVozilaPanel)
        {
            this.listaSvihObjekata = listaSvihObjekata;
            this.listaVozilaPanel = listaVozilaPanel;
        }

        public PictureBox CreateIcon(Image image, FlowLayoutPanel panel)
        {
            PictureBox slika = new PictureBox();
            slika.Width = (panel.Height - 35) / 2;
            slika.Height = (panel.Height - 35) / 2;
            slika.SizeMode = PictureBoxSizeMode.StretchImage;
            if (slika != null)
            {
                slika.Image = image;
            }
            else
            {
                slika.BackgroundImage = Resources.user_icon;
                slika.BackgroundImageLayout = ImageLayout.Stretch;
            }
            slika.Anchor = AnchorStyles.Left;
            panel.Controls.Add(slika);
            listaSvihObjekata.Add(slika);
            return slika;
        }

        public FlowLayoutPanel CreateFlowPanel(BorderStyle b, FlowDirection f, int height)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Width = 940;
            panel.Height = height;
            panel.Margin = new Padding(5);
            panel.BorderStyle = b;
            panel.FlowDirection = f;
            panel.BackColor = Color.WhiteSmoke;
            panel.AutoSize = false;
            listaSvihObjekata.Add(panel);
            return panel;
        }

        public TableLayoutPanel CreateTablePanel(BorderStyle b, int r, int c)
        {
            TableLayoutPanel panel = new TableLayoutPanel();
            panel.AutoSize = false;
            panel.RowCount = r;
            panel.ColumnCount = c;
            panel.Width = listaVozilaPanel.Width - 355;
            panel.Height = 100;
            panel.Margin = new Padding(5);
            panel.BorderStyle = b;
            panel.RowStyles.Add(new RowStyle());
            panel.RowStyles[0].Height = 75;
            panel.RowStyles[0].SizeType = SizeType.Absolute;
            listaSvihObjekata.Add(panel);
            return panel;
        }

        public PictureBox CreateImage(Vozilo v)
        {
            PictureBox slika = new PictureBox();
            slika.Width = 285;
            slika.Height = 190;
            slika.SizeMode = PictureBoxSizeMode.StretchImage;
            using (var client = new WebClient())
            {
                byte[] data = client.DownloadData(v.slikaPath);
                using (var stream = new MemoryStream(data))
                {
                    slika.BackgroundImage = Image.FromStream(stream);
                    slika.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
            slika.Anchor = AnchorStyles.Left;
            listaSvihObjekata.Add(slika);
            return slika;
        }

        public Label CreateNaziv(Vozilo v)
        {
            Label naziv = new Label();
            naziv.Text = "  " + v.naziv;
            naziv.AutoSize = false;
            naziv.Width = 700;
            naziv.Height = 55;
            naziv.TextAlign = ContentAlignment.MiddleLeft;
            listaSvihObjekata.Add(naziv);
            return naziv;
        }

        public Label CreateIconText(string text, FlowLayoutPanel panel, int size)
        {
            Label icntext = new Label();
            panel.Controls.Add(icntext);
            icntext.Text = text;
            icntext.AutoSize = false;
            icntext.Width = size;
            icntext.Height = (panel.Height - 2) / 2;
            icntext.TextAlign = ContentAlignment.MiddleLeft;
            icntext.Font = new Font(icntext.Font.FontFamily, 13, icntext.Font.Style);
            listaSvihObjekata.Add(icntext);
            return icntext;
        }

        public void DodajSeparator(FlowLayoutPanel panel, int sirina)
        {
            Splitter separator = new Splitter();
            separator.Width = sirina;
            separator.Height = (panel.Height - 2) / 2;
            panel.Controls.Add(separator);
            listaSvihObjekata.Add(separator);
        }
    }
}
