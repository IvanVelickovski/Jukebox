using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jukebox
{
    public class Song
    {
        string pesna;
        string izveduvac;
        public string pat{get;set;}
        public Song(string song, string artist, string path) {
            pesna = song;
            izveduvac = artist;
            pat = path;
        }
        public override string ToString()
        {
            return String.Format("{0} - {1}", pesna, izveduvac);
        }

    }
}
