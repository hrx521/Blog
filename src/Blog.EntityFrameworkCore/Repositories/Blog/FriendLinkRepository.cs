using Blog.Domain.Blog;
using Blog.Domain.Blog.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Blog.EntityFrameworkCore.Repositories.Blog
{
    public class FriendLinkRepository:EfCoreRepository<BlogDbContext,FriendLink,int>,IFriendLinkRepository
    {
        public FriendLinkRepository(IDbContextProvider<BlogDbContext> dbContextProvider):base(dbContextProvider)
        {

        }
    }
}
