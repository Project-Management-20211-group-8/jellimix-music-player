using PM.Jellimix.ApplicationCore.Interface;
using PM.Jellimix.ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PM.Jellimix.ApplicationCore.Service
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel
    {
    }
}
