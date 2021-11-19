using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Jellimix.ApplicationCore.Model
{
    public class Song : BaseModel
    {
        public int SongId { get; set; }

        public int AlbumId { get; set; }

        public string Title { get; set; }

        public int Duration { get; set; }

        public string Genres { get; set; }
    }
}
