﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Jellimix.ApplicationCore.Model
{
    public class Playlist : BaseModel
    {
        public int PlaylistId { get; set; }

        public string Name { get; set; }

        public int AccountId { get; set; }
    }
}
