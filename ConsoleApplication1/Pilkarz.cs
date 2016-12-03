using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pilkarz : Osoba
    {
        public Pilkarz(string imie_, string nazwisko_, string dataUrodzenia_, string pozycja_, string klub_):
            base( imie_,  nazwisko_,  dataUrodzenia_)
        {
            pozycja = pozycja_;
            klub = klub_;
        }


        private string pozycja;
        private string klub;
        private int liczbaGoli = 0;


        public override void  WypiszInfo()
        {
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataUrodzenia);
            Console.WriteLine(pozycja);
            Console.WriteLine(liczbaGoli);
            Console.WriteLine(klub);
        }
        public virtual void StrzelGola()
        {
            liczbaGoli++;
        }
    }
}
