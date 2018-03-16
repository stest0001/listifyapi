using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// ReSharper disable InconsistentNaming

namespace Listify.ViewModels
{
    public class ListifyFetchResultViewModel
    {
        public int? begin { get; set; }
        public int? end { get; set; }
        public int? index { get; set; }
        public int? result { get; set; }

        public bool success { get; set; }
        public string message { get; set; }
    }
}