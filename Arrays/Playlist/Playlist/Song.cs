using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Song
    {
        private string name;
        private string singer;
        private int length;

        public Song (string name, string singer, int length)
        {
            this.name = name;
            this.singer = singer;
            this.length = length;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSinger(string singer)
        {
            this.singer = singer;
        }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSinger()
        {
            return this.singer;
        }

        public int GetLength()
        {
            return this.length;
        }
    }

}
