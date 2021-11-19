using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PM.Jellimix.ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM.Jellimix.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseModel
    {
    }
}
