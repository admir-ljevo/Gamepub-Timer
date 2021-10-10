using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erkoAlma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStop4_1.Enabled = false;
            btnStop4_2.Enabled = false;
            btnStop5_1.Enabled = false;
            btnStop5_2.Enabled = false;
        }
        private DateTime VrijemePocetka4_1;
        private DateTime VrijemePocetka4_2;
        private DateTime VrijemePocetka5_1;
        private DateTime VrijemePocetka5_2;

        private DateTime VrijemeZavrsetka4_1;
        private DateTime VrijemeZavrsetka4_2;
        private DateTime VrijemeZavrsetka5_1;
        private DateTime VrijemeZavrsetka5_2;

        private TimeSpan UkupnoVremena4_1;
        private TimeSpan UkupnoVremena4_2;
        private TimeSpan UkupnoVremena5_1;
        private TimeSpan UkupnoVremena5_2;

        private double UkupnoPlatit4_1;
        private double UkupnoPlatit4_2;
        private double UkupnoPlatit5_1;
        private double UkupnoPlatit5_2;
        NumberFormatInfo setPrecision = new NumberFormatInfo();
        private void StopDugme(Label lblKraj, DateTime VrijemePocetka, DateTime VrijemeZavrsetka, TimeSpan UkupnoVremena, Label lblUkupno, double UkupnoPlatit, TextBox txtUkupno, Button btnStart, Button btnStop)
        {
            lblKraj.Text = $"Vrijeme završetka: {DateTime.Now}";
            VrijemeZavrsetka = DateTime.Now;
            UkupnoVremena = VrijemeZavrsetka - VrijemePocetka;
            setPrecision.NumberDecimalDigits = 4;

            // lblUkupno4_1.Text = $"Ukupno vremena: {(DateTime.Now.TimeOfDay - VrijemePocetka4_1.TimeOfDay).ToString()}";
            lblUkupno.Text = $"Ukupno vremena: {UkupnoVremena.Duration().ToString()}";

            //UkupnoPlatit4_1 = double.Parse(UkupnoVremena4_1.Minute.ToString()) / 17.14285714285714;           
            UkupnoPlatit = (double.Parse(UkupnoVremena.Hours.ToString()) * 60 + double.Parse(UkupnoVremena.Minutes.ToString())) / 20.00;
            decimal zaPlatit = decimal.Parse(UkupnoPlatit.ToString());
            //UkupnoPlatit4_1 /= 100;
            txtUkupno.Text = $"Ukupno: {zaPlatit.ToString(setPrecision)} KM";
            btnStart.Enabled = true;
            btnStop.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OcistiPolja(Label lblKraj, Label lblUkupno, TextBox txtUkupno)
        {
            lblKraj.Text = "Vrijeme završetka: ";
            lblUkupno.Text = "Ukupno vremena: ";
            txtUkupno.Text = "";
        }
        private void btnStart4_1_Click(object sender, EventArgs e)
        {
            VrijemePocetka4_1 = DateTime.Now;
            lblPocetak4_1.Text = $" Vrijeme početka: {DateTime.Now.ToString()}";
            btnStart4_1.Enabled = false;
            btnStop4_1.Enabled = true;
            OcistiPolja(lblKraj4_1, lblUkupno4_1, txtUkupno4_1);
        }

        private void btnStop4_1_Click(object sender, EventArgs e)
        {
            StopDugme(lblKraj4_1, VrijemePocetka4_1, VrijemeZavrsetka4_1, UkupnoVremena4_1, lblUkupno4_1, UkupnoPlatit4_1, txtUkupno4_1, btnStart4_1, btnStop4_1);
        }

        private void btnStart4_2_Click(object sender, EventArgs e)
        {
            VrijemePocetka4_2 = DateTime.Now;
            lblPocetak4_2.Text = $" Vrijeme početka: {DateTime.Now.ToString()}";
            btnStart4_2.Enabled = false;
            btnStop4_2.Enabled = true;
            OcistiPolja(lblKraj4_2, lblUkupno4_2, txtUkupno4_2);
        }

        private void btnStop4_2_Click(object sender, EventArgs e)
        {
            StopDugme(lblKraj4_2, VrijemePocetka4_2, VrijemeZavrsetka4_2, UkupnoVremena4_2, lblUkupno4_2, UkupnoPlatit4_2, txtUkupno4_2, btnStart4_2, btnStop4_2);
        }

        private void btnStart5_1_Click(object sender, EventArgs e)
        {
            VrijemePocetka5_1 = DateTime.Now;
            lblPocetak5_1.Text = $" Vrijeme početka: {DateTime.Now.ToString()}";
            btnStart5_1.Enabled = false;
            btnStop5_1.Enabled = true;
            OcistiPolja(lblKraj5_1, lblUkupno5_1, txtUkupno5_1);
        }

        private void StopDugme_5(Label lblKraj, DateTime VrijemePocetka, DateTime VrijemeZavrsetka, TimeSpan UkupnoVremena, Label lblUkupno, double UkupnoPlatit, TextBox txtUkupno, Button btnStart, Button btnStop)
        {
            lblKraj.Text = $"Vrijeme završetka: {DateTime.Now}";
            VrijemeZavrsetka = DateTime.Now;
            UkupnoVremena = VrijemeZavrsetka - VrijemePocetka;

            // lblUkupno4_1.Text = $"Ukupno vremena: {(DateTime.Now.TimeOfDay - VrijemePocetka4_1.TimeOfDay).ToString()}";
            lblUkupno.Text = $"Ukupno vremena: {UkupnoVremena.Duration().ToString()}";

            //UkupnoPlatit4_1 = double.Parse(UkupnoVremena4_1.Minute.ToString()) / 17.14285714285714;           
            UkupnoPlatit = (double.Parse(UkupnoVremena.Hours.ToString()) * 60 + double.Parse(UkupnoVremena.Minutes.ToString())) / 12.00;

            //UkupnoPlatit4_1 /= 100;
            txtUkupno.Text = $"Ukupno: {(UkupnoPlatit).ToString()} KM";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnStop5_1_Click(object sender, EventArgs e)
        {
            StopDugme_5(lblKraj5_1, VrijemePocetka5_1, VrijemeZavrsetka5_1, UkupnoVremena5_1, lblUkupno5_1, UkupnoPlatit5_1, txtUkupno5_1, btnStart5_1, btnStop5_1);
        }

        private void btnStart5_2_Click(object sender, EventArgs e)
        {
            VrijemePocetka5_2 = DateTime.Now;
            lblPocetak5_2.Text = $" Vrijeme početka: {DateTime.Now.ToString()}";
            btnStart5_2.Enabled = false;
            btnStop5_2.Enabled = true;
            OcistiPolja(lblKraj5_2, lblUkupno5_2, txtUkupno5_2);
        }

        private void btnStop5_2_Click(object sender, EventArgs e)
        {
            StopDugme_5(lblKraj5_2, VrijemePocetka5_2, VrijemeZavrsetka5_2, UkupnoVremena5_2, lblUkupno5_2, UkupnoPlatit5_2, txtUkupno5_2, btnStart5_2, btnStop5_2);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Da li sigurno želite izaći?", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No)
                e.Cancel = true;
        }
    }
}
