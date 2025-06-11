using System;
using System.Windows.Forms;

namespace RentACar
{
    public partial class Uploading: Form
    {
        public Uploading()
        {
            InitializeComponent();
        }

        private void Uploading_Load(object sender, EventArgs e)
        {

        }

        public void SetInfoText(string text)
        {
            infoLabel.Text = text;
        }
        public void SetMainText(string text)
        {
            label1.Text = text;
        }
    }
}
