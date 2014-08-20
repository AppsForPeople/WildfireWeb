using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WildFireWeb.Models
{
    public class FireEventModel
    {
        public string SiteName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string OgImage { get; set; }
        public string TwitterShareText { get; set; }
        public string PageUrl { get; set; }
        public string PageSlug { get; set; }
        public string MapId { get; set; }
        public string SearchTerm { get; set; }
        public string Hashtag { get; set; }
        public string TwitterTermWidget { get; set; }
        public string TwitterHashTagWidget { get; set; }
    }
}