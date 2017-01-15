using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wlasciwosci1
{
    class Osoba
    {
        private string imie;
        private int wiek;

        public void UstawWiek(int wiek) { this.wiek = wiek; }
        public int PobierzWiek() { return wiek; }

        public void UstawImie(string imie) { this.imie = imie; }
        public string PobierzImie() { return imie; }
    }
}
