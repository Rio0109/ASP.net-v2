using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispitpripremaZadatak01
{
    public class Motocikl : Vozilo, IVozilo
    {
        public bool Jednosjed { get; private set; }

        // Konstruktor klase Motocikl
        public Motocikl(string model, int godinaProizvodnje, char kategorija, bool jednosjed)
            : base(model, godinaProizvodnje, kategorija)
        {
            Jednosjed = jednosjed;
        }

        // Implementacija metode iz sučelja IVozilo
        public string Kotaci()
        {
            return "Motocikl ima 2 kotača.";
        }
    }
}

