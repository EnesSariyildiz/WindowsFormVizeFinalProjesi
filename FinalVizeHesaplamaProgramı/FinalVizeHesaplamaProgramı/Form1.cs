namespace FinalVizeHesaplamaProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float vize, final,ortalama;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrtalamaLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HesaplaButton_Click(object sender, EventArgs e)
        {
            vize = float.Parse(VizeText.Text);
            final = float.Parse(FinalText.Text);
            float VizeYüzdeKırk = (vize * 40) / 100;
            float FizeYüzdeAltmış = (final * 60) / 100;
            ortalama = VizeYüzdeKırk + FizeYüzdeAltmış;
            OrtalamaLabel.Text = ortalama.ToString();


            if (ortalama > 90 && ortalama <= 100)
            {
                HarfNotuLabel.Text ="AA ";
            }
            else if (ortalama > 85 && ortalama <= 89)
            {
                HarfNotuLabel.Text = "BA ";
            }
            else if (ortalama > 80 && ortalama <= 84)
            {
                HarfNotuLabel.Text = "BB ";
            }
            else if (ortalama > 75 && ortalama <= 79)
            {
                HarfNotuLabel.Text = "CB ";
            }
            else if (ortalama > 65 && ortalama <= 74)
            {
                HarfNotuLabel.Text = "CC ";
            }
            else if (ortalama > 60 && ortalama <= 64)
            {
                HarfNotuLabel.Text = "DC ";
            }
            else if (ortalama > 55 && ortalama <= 59)
            {
                HarfNotuLabel.Text = "DD ";
            }
            else if (ortalama > 50 && ortalama <= 54)
            {
                HarfNotuLabel.Text = "FD ";
                ;
            }
            else if (ortalama > 00 && ortalama <= 49)
            {
                HarfNotuLabel.Text = "FF ";
            }

        }
    }
}