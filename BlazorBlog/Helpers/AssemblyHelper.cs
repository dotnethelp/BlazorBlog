using Microsoft.AspNetCore.Components;
using BlazorBlog.Core.Attributes;
using BlazorBlog.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BlazorBlog.Helpers
{
    public static class AssemblyHelper
    {
        public static ICollection<LatestPostsViewModel> GetLatestPost()
        {
            ICollection<LatestPostsViewModel> viewModels = new List<LatestPostsViewModel>();
            // Get all the components whose base class is ComponentBase
            var components = Assembly.GetExecutingAssembly()
                                   .ExportedTypes
                                   .Where(t =>
                                  t.IsSubclassOf(typeof(ComponentBase)));

            foreach (var component in components)
            {
                // Now check if this component contains the Authorize attribute
                var allAttributes = component.GetCustomAttributes(inherit: true);

                var postAttribute =
                       allAttributes.OfType<PostAttribute>().FirstOrDefault();
                if (postAttribute != null)
                {
                    viewModels.Add(new LatestPostsViewModel 
                    {  
                        Tilte= postAttribute.Title,
                        Description= postAttribute.Description, 
                        PublishTime = postAttribute.PublishTime,
                        Url = component.GetCustomAttribute<RouteAttribute>().Template
                    });
                }
            }

            return viewModels;
        }
    }
}
