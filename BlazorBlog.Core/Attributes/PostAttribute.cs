using System;
using System.Collections.Generic;
using System.Text;


namespace BlazorBlog.Core.Attributes
{
    public class PostAttribute: Attribute
    {
        public string Title { get; }
        public string Description { get; }
        public string PublishTime { get; }

        public PostAttribute(string title,string description,string publishTime)
        {
            Title = title;
            Description = description;
            PublishTime = publishTime;
        }

    }
}
