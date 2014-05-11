using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jukebox
{
    public class Zanr
    {
        public List<string> pesni;
        public string ime;
        public Zanr(List<string> lista,string ime) {
            pesni = lista;
        }
        public override string ToString()
        {
            return ime;
        }
        public void add(string song) {
            this.pesni.Add(song);
        }
    }
}
