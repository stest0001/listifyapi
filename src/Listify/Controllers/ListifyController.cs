using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Listify.Controllers
{
    public class ListifyController : ApiController
    {
        /// <summary>
        /// Indexes the specified begin.
        /// </summary>
        /// <param name="begin">The start of the list.</param>
        /// <param name="end">The end of the list.</param>
        /// <param name="index">The index that you want to find the value to.</param>
        /// <returns></returns>
        [HttpGet]        
        public IHttpActionResult Index(int? begin = null, int? end = null, int? index = null)
        {
            var result = new ViewModels.ListifyFetchResultViewModel
            {
                begin = begin,
                end = end,
                index = index
            };

            if (!(begin.HasValue && end.HasValue && index.HasValue))
            {
                result.success = false;
                result.message =
                    "This API requires the following query string parameters to produce a result: begin, end, index. (All integer values. End is exclusive.)";

                return Json(result);
            }

            var list = new Models.Listify(begin.Value, end.Value);
            result.result = list[index.Value];
            result.success = true;

            return Json(result);
        }
    }
}
