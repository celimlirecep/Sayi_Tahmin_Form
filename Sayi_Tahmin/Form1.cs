using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayi_Tahmin
{
    public partial class Form1 : Form
    {
        public int hedef;
        public int puan=50;
        public int hak=5;

        public Form1()
        {
            InitializeComponent();
        }

        void aktifEt()
        {
            txtTahminGirdi.Enabled = true;
            tblGirdiOnay.Enabled = true;
            btnBaslat.Enabled = false;
        }
        void PasifEt()
        {
            txtTahminGirdi.Enabled = false;
            tblGirdiOnay.Enabled = false;
            btnBaslat.Enabled = true;
            btnBaslat.Focus();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            hedef = rnd.Next(1, 101);
            lblHile.Text ="hile: "+ hedef.ToString();// BU SATİR SİLİNECEK
            puan =50;
            lblSonuc.Text = "OYUN BAŞLADI !!!";
            aktifEt();
            btnBaslat.Text = "YENİDEN BAŞLAT";
            lblPuan.Text = puan.ToString();
            lblHak.Text = hak.ToString();
            txtTahminGirdi.Focus();

        }

        void tahminclick()
        {
            if ( txtTahminGirdi.Text!="" )
            {
                int tahmin = int.Parse(txtTahminGirdi.Text);
                txtTahminGirdi.Clear();
                txtTahminGirdi.Focus();
                lblUserEstimate.Text = lblUserEstimate.Text + " " + tahmin.ToString();
                if (tahmin < hedef) //tahmin hedeften büyükse
                {

                    hak--;
                    puan -= 10;
                    lblPuan.Text = puan.ToString();
                    lblHak.Text = hak.ToString();
                    if (hak == 0)
                    {
                        PasifEt();
                        lblSonuc.Text = "I AM OS SORY FOR YOUR FAILURE ANSWER :-) ";
                    }
                    else
                    {
                        lblSonuc.Text = "daha büyük bir sayi giriniz";
                    }
                }
                else if (tahmin > hedef)// tahmin hedeften kücükse
                {
                    hak--;
                    puan -= 10;
                    lblPuan.Text = puan.ToString();
                    lblHak.Text = hak.ToString();
                    if (hak == 0)
                    {
                        PasifEt();
                        lblSonuc.Text = "I AM SO SORY FOR YOUR FAILURE ANSWER :-) ";
                    }
                    else
                    {
                        lblSonuc.Text = "daha küçük bir sayi giriniz";
                    }
                }

                else// tahmin dogruysa
                {
                    lblSonuc.Text = "your answer is true";
                    PasifEt();
                }
                // lblSonuc.Text = "senin puanın: " + puan.ToString();

            }
            else
            {
                lblSonuc.Text = "SAYI GİR!!!";
            }



        }

        private void tblGirdiOnay_Click(object sender, EventArgs e)
        {
            tahminclick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PasifEt();
        }

        

        private void txtTahminGirdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tahminclick();
            }
        }
    }
}
