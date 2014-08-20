using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WildFireWeb.Models
{
    public class WildFireConfig
    {
        public string SiteName { get; set; }
        public string SiteOwnerName { get; set; }
        public string SiteUrl { get; set; }
        public string TwitterSite { get; set; }
        public string TwitterCreator { get; set; }
        public string Links { get; set; }
        public string AnalyticsId { get; set; }
    }
}