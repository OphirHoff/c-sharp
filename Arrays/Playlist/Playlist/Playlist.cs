using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Playlist
    {
        private string name;
        private int length;
        private Song[] songs;

        public Playlist(string name)
        {
            this.name = name;
            this.songs = new Song[100];
            this.length = 0;
        }

        public bool AddSong(Song song)
        {
            if (length < 100)
            {
                songs[length] = song;
                length++;
                return true;
            }
            return false;
        }

        public bool AddSong(string name, string Singer, int length)
        {
            Song song = new Song(name, Singer, length);
            return AddSong(song);
        }

        public int OverAll()
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += songs[i].GetLength();
            }
            return sum;
        }

        public string Longest()
        {
            Song longestSong = songs[0];
            for (int i = 0; i < length; i++)
            {
                if (songs[i].GetLength() > longestSong.GetLength())
                    longestSong = songs[i];
            }
            return longestSong.GetName();
        }
    }
}
