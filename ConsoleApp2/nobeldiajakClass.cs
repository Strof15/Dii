using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class nobeldiajakClass
    {
        //evszam tipus keresztnev vezeteknev
        int evszam;
        string tipus;
        string keresznev;
        string vezeteknev;

        public int Evszam { get => evszam; set => evszam = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public string Keresznev { get => keresznev; set => keresznev = value; }
        public string Vezeteknev { get => vezeteknev; set => vezeteknev = value; }

        public nobeldiajakClass(int evszam, string tipus, string keresznev, string vezeteknev)
        {
            this.evszam = evszam;
            this.tipus = tipus;
            this.keresznev = keresznev;
            this.vezeteknev = vezeteknev;
        }

        public nobeldiajakClass(string CsvSorok)
        {
            var mezo = CsvSorok.Split(';');
            this.evszam = int.Parse(mezo[0]);
            this.tipus = mezo[1];
            this.keresznev = mezo[2];
            this.vezeteknev = mezo[3];


        }

        
    }
}
