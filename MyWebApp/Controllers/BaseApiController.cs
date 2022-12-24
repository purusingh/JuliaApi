using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MyWebApp.Controllers
{

    public class BaseApiController : ApiController
    {
        protected ILog logger;
        public BaseApiController()
        {
            logger = LogManager.GetLogger(this.GetType());
        }

    }
}