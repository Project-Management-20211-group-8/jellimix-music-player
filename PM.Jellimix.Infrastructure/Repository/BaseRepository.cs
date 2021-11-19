using PM.Jellimix.ApplicationCore.Interface;
using PM.Jellimix.ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Jellimix.Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
    }
}
