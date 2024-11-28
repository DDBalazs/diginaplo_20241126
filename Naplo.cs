using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diginaplo
{
    internal class Naplo
    {
        string nev;
        int otosok;
        int negyesek;
        int harmasok;
        int kettesek;
        int egyesek;
        double atlag;
        int osztondij;

        public string Nev { get => nev; set => nev = value; }
        public int Otosok { get => otosok; set => otosok = value; }
        public int Negyesek { get => negyesek; set => negyesek = value; }
        public int Harmasok { get => harmasok; set => harmasok = value; }
        public int Kettesek { get => kettesek; set => kettesek = value; }
        public int Egyesek { get => egyesek; set => egyesek = value; }
        public double Atlag { get => atlag; set => atlag = value; }
        public int Osztondij { get => osztondij; set => osztondij = value; }

        public Naplo(string sor)
        {
            string[] darabok =sor.Split(';');
            nev = darabok[0];
            otosok = int.Parse(darabok[1]);
            negyesek = int.Parse(darabok[2]);
            harmasok = int.Parse(darabok[3]);
            kettesek = int.Parse(darabok[4]);
            egyesek = int.Parse(darabok[5]);
            double darabszam = otosok+negyesek+harmasok+kettesek+egyesek;
            atlag = (otosok*5+negyesek*4+harmasok*3+kettesek*2+egyesek)/darabszam;
            atlag = Math.Round(atlag,2);
            if(atlag >= 2 && atlag < 3)
            {
                osztondij = 8000;
            }
            else if(atlag >= 3 && atlag < 4)
            {
                osztondij = 25000;
            }
            else if (atlag >= 4 && atlag < 4.5)
            {
                osztondij = 42000;
            }
            else if(atlag >= 4.5)
            {
                osztondij = 59000;
            }
            else
            {
                osztondij = 0;
            }
        }
        public int pontszamitas()
        {
            return otosok * 3 + negyesek * 2 + kettesek * (-1) + egyesek * (-2);
        }

    }
}
