using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using BlazorBlog.Core.Attributes;
using BlazorBlog.Helpers;
using BlazorBlog.Core.ViewModels;

namespace BlazorBlog.Pages
{
    public partial class Index
    {
        ICollection<LatestPostsViewModel> Posts;

        protected override void OnAfterRender(bool firstRender)
        {

            if (firstRender)
            {
                Posts = AssemblyHelper.GetLatestPost();
                StateHasChanged();
            }
        }
    }
}
