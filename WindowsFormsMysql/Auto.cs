using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMysql
{
    class Auto
    {
        private string rendszam;
        int kod;
        string gyartmany;
        string tipus;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public int Kod { get => kod; set => kod = value; }
        public string Gyartmany { get => gyartmany; set => gyartmany = value; }
        public string Tipus { get => tipus; set => tipus = value; }

        public Auto(int kod,string rendszam, string gyartmany, string tipus)
        {
            Rendszam = rendszam;
            Kod = kod;
            Gyartmany = gyartmany;
            Tipus = tipus;
        }
        public override string ToString()
        {
            return rendszam;
        }
    }
}
