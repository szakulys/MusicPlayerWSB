using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOb3Music
{
    class Song
    {
        public string Tytul;
        public string Wykonawca;

        public Song(string tytul, string wykonawca)
        {
            this.Tytul = tytul;
            this.Wykonawca = wykonawca;
        }

        public virtual void Play()
        {
            Console.WriteLine("Tytul: " + Tytul + " " + "Wykonawca: " + Wykonawca + "\n");
        }
    }
}
