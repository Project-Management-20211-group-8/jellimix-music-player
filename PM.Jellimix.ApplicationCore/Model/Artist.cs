using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Jellimix.ApplicationCore.Model
{
    public class Artist : BaseModel
    {
        public int ArtistId { get; set; }

        public string ArtistName { get; set; }

        public string Country { get; set; }

        public string Style { get; set; }
    }
}
