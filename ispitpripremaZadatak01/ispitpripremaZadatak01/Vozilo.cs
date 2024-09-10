using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitpripremaZadatak01
{
    public class Vozilo
    {
        public string Model { get; private set; }
        public int GodinaProizvodnje { get; private set; }
        public char Kategorija { get; private set; }

        // Konstruktor klase Vozilo
        public Vozilo(string model, int godinaProizvodnje, char kategorija)
        {
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            Kategorija = kategorija;
        }
    }

}