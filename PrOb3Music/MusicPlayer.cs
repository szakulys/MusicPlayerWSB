using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrOb3Music
{
    class MusicPlayer
    {
        public List<Song> playlist = new List<Song>();

        public void Add(Song song)
        {
            playlist.Add(song);
        }

        public void Remove(int songNumber)
        {
            playlist.RemoveAt(songNumber);
        }

        public void Play(int songNumber)
        {
            playlist[songNumber].Play();
        }
    }
}
