using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBlog.Core.ViewModels
{
    public class LatestPostsViewModel
    {
        public string Tilte { get; set; }
        public string Description { get; set; }
        public string PublishTime { get; set; }
        public string Url { get; set; }
    }
}
