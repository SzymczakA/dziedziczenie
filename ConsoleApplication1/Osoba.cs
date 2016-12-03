using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Osoba
    {
        public Osoba(string imie_, string nazwisko_, string dataUrodzenia_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
            dataUrodzenia = dataUrodzenia_;
        }


        protected string imie;
        protected string nazwisko;
        protected string dataUrodzenia;


        public virtual void WypiszInfo()
        {
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataUrodzenia);
        }
    }
}
