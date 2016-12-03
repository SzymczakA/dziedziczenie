using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student : Osoba
    {
        public Student(string imie_, string nazwisko_, string dataUrodzenia_, int rok_, int grupa_, int nrIndeksu_) :
            base(imie_, nazwisko_, dataUrodzenia_)
        {
            rok = rok_;
            grupa = grupa_;
            nrIndeksu = nrIndeksu_;
        }

        private int rok;
        private int grupa;
        private int nrIndeksu;
        List<Ocena> oceny = new List<Ocena>();


        public override void WypiszInfo()
        {
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataUrodzenia);
            Console.WriteLine(rok);
            Console.WriteLine(grupa);
            Console.WriteLine(nrIndeksu);
            foreach (var item in oceny)
            {
                item.WypiszInfo();
            }
        }
        public void DodajOcene(string nazwaPrzedmiotu_, string data_, double wartosc_)
        {
            oceny.Add(new Ocena(nazwaPrzedmiotu_, data_, wartosc_));
        }
        public void WypiszOceny()
        {
            foreach (var item in oceny)
            {
                item.WypiszInfo();
            }
        }
        public void WypiszOceny(string nazwaPrzedmiotu_)
        {
            foreach (var item in oceny)
            {
                if (item.NazwaPrzedmiotu == nazwaPrzedmiotu_) item.WypiszInfo();
            }
        }
        public void UsunOcene(string nazwaPrzedmiotu_, string data_, double wartosc_)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu_ && o.Data == data_ && o.Wartosc == wartosc_)
                    oceny.RemoveAt(i);
                else
                {
                    ++i;
                }
            }
        }
        public void UsunOceny()
        {
            oceny.Clear();
        }
        public void UsunOceny(string nazwaPrzedmiotu_)
        {
            for (int i = 0; i < oceny.Count;)
            {
                Ocena o = oceny[i];
                if (o.NazwaPrzedmiotu == nazwaPrzedmiotu_)
                    oceny.RemoveAt(i);
                else
                {
                    ++i;
                }
            }
        }
    }
}