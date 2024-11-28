using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diginaplo
{
    public partial class Form1 : Form
    {
        List<Naplo> lista = new List<Naplo>();
        void betoltes()
        {
            lista.Clear();
            dgnaplo.Rows.Clear();
            FileStream fs = new FileStream("enaplo.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                Naplo n = new Naplo(sr.ReadLine());
                lista.Add(n);
                dgnaplo.Rows.Add(n.Nev, n.Otosok, n.Negyesek, n.Harmasok, n.Kettesek, n.Egyesek, n.Atlag, n.pontszamitas(), n.Osztondij);
            }
            sr.Close();
            fs.Close();
            double atlag = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                atlag = atlag + lista[i].pontszamitas();
            }
            atlag = Math.Round(atlag / lista.Count, 1);
            lbatlagpontszam.Text = atlag.ToString();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].pontszamitas() < atlag)
                {
                    rtbatlagalattiak.Text = rtbatlagalattiak.Text + lista[i].Nev.ToString() + "\n";
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();

        }

        private void tbotosok_TextChanged(object sender, EventArgs e)
        {
            if (tbotosok.TextLength < 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tbotosok.Text);
                }
                catch
                {
                    MessageBox.Show("szamot adjon meg", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbotosok.Clear();
                    tbotosok.Focus();
                }
            }
        }

        private void tbnegyesek_TextChanged(object sender, EventArgs e)
        {
            if (tbnegyesek.TextLength < 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tbnegyesek.Text);
                }
                catch
                {
                    MessageBox.Show("szamot adjon meg", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbnegyesek.Clear();
                    tbnegyesek.Focus();
                }
            }
        }

        private void tbharmasok_TextChanged(object sender, EventArgs e)
        {
            if (tbharmasok.TextLength < 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tbharmasok.Text);
                }
                catch
                {
                    MessageBox.Show("szamot adjon meg", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbharmasok.Clear();
                    tbharmasok.Focus();
                }
            }
        }

        private void tbkettesek_TextChanged(object sender, EventArgs e)
        {
            if (tbegyesek.TextLength < 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tbkettesek.Text);
                }
                catch
                {
                    MessageBox.Show("szamot adjon meg", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbkettesek.Clear();
                    tbkettesek.Focus();
                }
            }
        }

        private void tbegyesek_TextChanged(object sender, EventArgs e)
        {
            if (tbegyesek.TextLength < 0)
            {
                try
                {
                    int szam = Convert.ToInt32(tbegyesek.Text);
                }
                catch
                {
                    MessageBox.Show("szamot adjon meg", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbegyesek.Clear();
                    tbegyesek.Focus();
                }
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            if (tbnev.TextLength == 0)
            {
                MessageBox.Show("Adja meg a nevet", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbnev.Clear();
                tbnev.Focus();
            }
            else if (tbotosok.TextLength == 0)
            {
                MessageBox.Show("adja meg az otosok szamat", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbotosok.Clear();
                tbotosok.Focus();
            }
            else if (tbnegyesek.TextLength == 0)
            {
                MessageBox.Show("adja meg az negyesek szamat", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbnegyesek.Clear();
                tbnegyesek.Focus();
            }
            else if (tbharmasok.TextLength == 0)
            {
                MessageBox.Show("adja meg az harmasok szamat", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbharmasok.Clear();
                tbharmasok.Focus();
            }
            else if (tbkettesek.TextLength == 0)
            {
                MessageBox.Show("adja meg az kettesek szamat", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbkettesek.Clear();
                tbkettesek.Focus();
            }
            else if (tbegyesek.TextLength == 0)
            {
                MessageBox.Show("adja meg az egyesek szamat", "uzenet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbegyesek.Clear();
                tbegyesek.Focus();
            }
            else
            {
                FileStream fs = new FileStream("enaplo.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("\n"+tbnev.Text+";" + tbotosok.Text + ";" + tbnegyesek.Text + ";" + tbharmasok.Text + ";" + tbkettesek.Text + ";" + tbegyesek.Text + ";");

                sw.Close();
                fs.Close();
                betoltes();

                tbnev.Clear();
                tbotosok.Clear();
                tbnegyesek.Clear();
                tbharmasok.Clear();
                tbkettesek.Clear();
                tbegyesek.Clear();

                MessageBox.Show("adatok mentése sikeresen megtortent", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);


                

            }
        }
    }

}
