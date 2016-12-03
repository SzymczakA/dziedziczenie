using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ocena
    {
        public Ocena(string nazwaPrzedmiotu_, string data_, double wartosc_)
        {
            NazwaPrzedmiotu = nazwaPrzedmiotu_;
            Data = data_;
            Wartosc = wartosc_;
        }


        private string nazwaPrzedmiotu;
        private string data;
        private double wartosc;

        public string NazwaPrzedmiotu
        {
            get
            {
                return nazwaPrzedmiotu;
            }

            set
            {
                nazwaPrzedmiotu = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public double Wartosc
        {
            get
            {
                return wartosc;
            }

            set
            {
                wartosc = value;
            }
        }

        public void WypiszInfo()
        {
            Console.WriteLine(NazwaPrzedmiotu);
            Console.WriteLine(Data);
            Console.WriteLine(Wartosc);
        }
    }
}
