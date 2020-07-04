using Blog.Application.Contracts.Blog;
using Blog.ToolKits.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Blog
{
    public interface IBlogService
    {
        Task<ServiceTResult<string>> InsertBlogAsync(PostDto dto);
        Task<ServiceTResult<string>> UpdateBlogAsync(int Id,PostDto dto);
        Task<ServiceResult> DeleteBlogAsync(int Id);
        Task<ServiceTResult<PostDto>> GetBlogAsync(int Id);
    }
}
