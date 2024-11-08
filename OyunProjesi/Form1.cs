using System;
using System.Windows.Forms;

namespace OyunProjesi
{
    public partial class Form1 : Form
    {
        private int skorOyuncu = 0;
        private int skorBilgisayar = 0;
        private Random rastgele = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GuncelleSkor();
        }

        private void ButtonTas_Click(object sender, EventArgs e)
        {
            OyuncuHamlesi("Taş");
        }

        private void ButtonKagit_Click(object sender, EventArgs e)
        {
            OyuncuHamlesi("Kağıt");
        }

        private void ButtonMakas_Click(object sender, EventArgs e)
        {
            OyuncuHamlesi("Makas");
        }

        private void OyuncuHamlesi(string oyuncuSecim)
        {
            if (oyuncuSecim == "Taş")
                pictureBoxOyuncu.Image = Properties.Resources.Tas;
            else if (oyuncuSecim == "Kağıt")
                pictureBoxOyuncu.Image = Properties.Resources.Kagit;
            else
                pictureBoxOyuncu.Image = Properties.Resources.Makas;

            string bilgisayarSecim = BilgisayarSecimi();
            if (bilgisayarSecim == "Taş")
                pictureBoxBilgisayar.Image = Properties.Resources.Tas;
            else if (bilgisayarSecim == "Kağıt")
                pictureBoxBilgisayar.Image = Properties.Resources.Kagit;
            else
                pictureBoxBilgisayar.Image = Properties.Resources.Makas;

            // Skorları güncelle
            SkorGuncelle(oyuncuSecim, bilgisayarSecim);
        }

        private string BilgisayarSecimi()
        {
            int secim = rastgele.Next(1, 4); 
            if (secim == 1) return "Taş";
            else if (secim == 2) return "Kağıt";
            else return "Makas";
        }

        private void SkorGuncelle(string oyuncuSecim, string bilgisayarSecim)
        {
            if (oyuncuSecim == bilgisayarSecim)
            {
                MessageBox.Show("Beraberlik!");
            }
            else if ((oyuncuSecim == "Taş" && bilgisayarSecim == "Makas") ||
                     (oyuncuSecim == "Kağıt" && bilgisayarSecim == "Taş") ||
                     (oyuncuSecim == "Makas" && bilgisayarSecim == "Kağıt"))
            {
                skorOyuncu++;
                MessageBox.Show("Kazandınız!");
            }
            else
            {
                skorBilgisayar++;
                MessageBox.Show("Bilgisayar Kazandı!");
            }

            GuncelleSkor();
        }

        private void GuncelleSkor()
        {
            labelOyuncuSkor.Text = "Oyuncu Skor: " + skorOyuncu;
            labelBilgisayarSkor.Text = "Bilgisayar Skor: " + skorBilgisayar;
        }
    }
}
