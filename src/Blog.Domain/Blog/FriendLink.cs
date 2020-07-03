using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace Blog.Domain.Blog
{
    public class FriendLink:Entity<int>

    {
        public string Title { get; set; }
        public string LinkUrl { get; set; }
    }
}
