using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] pizzalar = { "Karışık Pizza 15 ₺", "İtalyan Pizza 14 ₺", "Vejeteryan Pizza 12 ₺", "Bol Sucuklu pizza 16 ₺", "NoMalzemos 10 ₺" };
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPizzalar.Items.AddRange(pizzalar);
        }
        decimal sepetFiyat = 0;
        private void cmbPizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPizzalar.SelectedIndex == -1)
                return;
            gbEkstraMalzeme.Visible = true;
            gbIcecekler.Visible = true;
        }

        private void cmbSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSecim.SelectedIndex == -1) return;
            else if (cmbSecim.SelectedIndex == 0)
            {
                btnHemenSiparis.Visible = true;
                gbIleriTarih.Visible = false;
            }
            else
            {
                btnHemenSiparis.Visible = false;
                gbIleriTarih.Visible = true;
                dtpTarih.MinDate = DateTime.Now.AddMinutes(30);
                dtpTarih.MaxDate = DateTime.Now.AddDays(15);
            }
        }

        private void cbSucuk_CheckedChanged(object sender, EventArgs e)
        {
            sepetFiyat = Hesapla();

        }
        decimal Hesapla()
        {
            decimal toplam = 0;
            switch (cmbPizzalar.SelectedIndex)
            {
                case 0:
                    toplam = 15;
                    break;
                case 1:
                    toplam = 14;
                    break;
                case 2:
                    toplam = 12;
                    break;
                case 3:
                    toplam = 16;
                    break;
                case 4:
                    toplam = 10;
                    break;
                default:
                    break;
            }
            foreach (CheckBox item in gbEkstraMalzeme.Controls)
            {
                if (item.Checked)
                {
                    switch (item.Text)
                    {
                        case "Ekstra Salam 3TL":
                            toplam += 3;
                            break;
                        case "Ekstra Peynir 2TL":
                            toplam += 2;
                            break;
                        case "Ekstra Sucuk 4TL":
                            toplam += 4;
                            break;
                        default:
                            break;
                    }
                }
            }

            // içecekler için siz hesaplayacaksınız :)
            return toplam;
        }

        private void btnHemenSiparis_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Siparişin tarafımıza ulaştı.\nPizzanız {DateTime.Now.AddMinutes(30): dd MMMM HH:mm}'da size ulaşacaktır");
        }

        private void btnIleriSiparis_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Siparişin tarafımıza ulaştı.\nPizzanız {dtpTarih.Value: dd MMMM HH:mm}'da size ulaşacaktır");
        }
    }
}
