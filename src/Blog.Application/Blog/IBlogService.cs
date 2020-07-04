using Blog.Application.Contracts.Blog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Blog
{
    public interface IBlogService
    {
        Task<bool> InsertBlogAsync(PostDto dto);
        Task<bool> UpdateBlogAsync(int Id,PostDto dto);
        Task<bool> DeleteBlogAsync(int Id);
        Task<PostDto> GetBlogAsync(int Id);
    }
}
