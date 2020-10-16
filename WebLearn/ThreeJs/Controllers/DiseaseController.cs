using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ThreeJs.Controllers
{
    public class DiseaseController : ApiController
    {
        /// <summary>
        /// 测试id
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public int GetId()
        {
            return 0;
        }
    }
}
