using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOb3Music
{
    class DooWop: RandB
    {
        private string Sound = "Duwopwop";

        public DooWop(string tytul, string wykonawca)
            :base(tytul, wykonawca)
        {

        }

        public override void Play()
        {
            base.Play();
            Console.Write(Sound + " ");
        }
    }
}
