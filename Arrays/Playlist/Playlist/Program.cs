using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("song1", "Singer1", 150);
            Song song2 = new Song("song2", "Singer2", 120);
            Song song3 = new Song("song3", "Singer3", 190);
            Song song4 = new Song("song4", "Singer4", 170);

            Playlist playlist = new Playlist("My Playlist");

            playlist.AddSong(song1);
            playlist.AddSong(song2);
            playlist.AddSong(song3);
            playlist.AddSong(song4);

            for (int i = 0; i < playlist.GetLength(); i++)
            {
                Console.WriteLine(playlist[i].GetName());
            }

        }
    }
}
