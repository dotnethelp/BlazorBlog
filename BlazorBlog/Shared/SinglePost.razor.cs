using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBlog.Shared
{
   
    public partial class SinglePost
    {
        [Parameter]
        public string HeaderImage { get; set; } 
        [Parameter]
        public string Header1 { get; set; }
        [Parameter]
        public string Header2{ get; set; }

        [Parameter]
        public string PublishTime { get; set; }

        [Parameter]
        public RenderFragment Content { get; set; }

    }
}
