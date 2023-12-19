using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz
{
    public partial class Form1 : Form
    {
        SoundPlayer zvuk = new SoundPlayer(@"correct.wav");
        Random generator = new Random();
        int prviPribrojnik, drugiPribrojnik,
            umanjenik, umanjitelj,
            prviFaktor, drugiFaktor,
            djeljenik, djelitelj;

        private void zbroj_ValueChanged(object sender, EventArgs e)
        {
            if (prviPribrojnik + drugiPribrojnik == zbroj.Value)
                zvuk.Play();
        }

        private void razlika_ValueChanged(object sender, EventArgs e)
        {
            if (umanjenik - umanjitelj == razlika.Value)
                zvuk.Play();
        }

        private void umnožak_ValueChanged(object sender, EventArgs e)
        {
            if(prviFaktor * drugiFaktor == umnožak.Value)
                zvuk.Play();
        }

        private void kvocijent_ValueChanged(object sender, EventArgs e)
        {
            if(djelitelj != 0 && djeljenik / djelitelj == kvocijent.Value)
                zvuk.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ProvjeriOdgovore())
            {
                timer1.Stop();
                MessageBox.Show("Svi odgovori su točni!",
                    "Čestitamo!");
                gumbPočetak.Enabled = true;
            }
            else if(preostaloVrijeme > 0)
            {
                preostaloVrijeme--;
                if (preostaloVrijeme <= 5)
                    labelaVrijeme.BackColor = Color.Red;
                labelaVrijeme.Text = preostaloVrijeme
                    + " sekundi";
            }
            else
            {
                timer1.Stop();
                labelaVrijeme.Text = "Isteklo!";
                MessageBox.Show("Vrijeme isteklo!",
                    "Niste uspjeli riješiti kviz!");
                zbroj.Value = prviPribrojnik + drugiPribrojnik;
                razlika.Value = umanjenik - umanjitelj;
                umnožak.Value = prviFaktor * drugiFaktor;
                kvocijent.Value = djeljenik / djelitelj;
                gumbPočetak.Enabled = true;
            }
        }

        int preostaloVrijeme;

        /// <summary>
        /// Provjeri jesu li svi odgovori korisnika točni.
        /// </summary>
        /// <returns>True ako je sve točno, inače false.</returns>
        private bool ProvjeriOdgovore()
            => prviPribrojnik + drugiPribrojnik == zbroj.Value
            && umanjenik - umanjitelj == razlika.Value
            && prviFaktor * drugiFaktor == umnožak.Value
            && djeljenik / djelitelj == kvocijent.Value;

        private void gumbPočetak_Click(object sender, EventArgs e)
        {
            PokreniKviz();
            gumbPočetak.Enabled = false;
        }

        private void unosEnter(object sender, EventArgs e)
        {
            if(sender is NumericUpDown polje)
            {
                polje.Select(0, polje.Value.ToString().Length);
            }
        }

        /// <summary>
        /// Generira probleme i pokreće štopericu.
        /// </summary>
        public void PokreniKviz()
        {
            preostaloVrijeme = 30;
            labelaVrijeme.Text = preostaloVrijeme +
                " sekundi";
            labelaVrijeme.BackColor = DefaultBackColor;
            timer1.Start();
            prviPribrojnik = generator.Next(100);
            drugiPribrojnik = generator.Next(100);
            labelaPrviPribrojnik.Text = prviPribrojnik.ToString();
            labelaDrugiPribrojnik.Text = drugiPribrojnik.ToString();
            zbroj.Value = 0;

            umanjenik = generator.Next(100);
            umanjitelj = generator.Next(umanjenik + 1);
            labelaUmanjenik.Text = umanjenik.ToString();
            labelaUmanjitelj.Text = umanjitelj.ToString();
            razlika.Value = 0;

            prviFaktor = generator.Next(1,11);
            drugiFaktor = generator.Next(1,11);
            labelaPrviFaktor.Text = prviFaktor.ToString();
            labelaDrugiFaktor.Text = drugiFaktor.ToString();
            umnožak.Value = 0;

            djelitelj = generator.Next(1, 11);
            djeljenik = djelitelj * generator.Next(1, 11);
            labelaDjelitelj.Text = djelitelj.ToString();
            labelaDjeljenik.Text = djeljenik.ToString();
            kvocijent.Value = 0;
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
