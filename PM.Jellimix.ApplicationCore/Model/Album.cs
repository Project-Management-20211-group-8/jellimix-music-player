using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Jellimix.ApplicationCore.Model
{
    public class Album : BaseModel
    {
        public int AlbumId { get; set; }

        public int ArtistId { get; set; }

        public string Title { get; set; }

        public string Year { get; set; }

        public string Genres { get; set; }
    }
}
