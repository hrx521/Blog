using Blog.Application.Blog;
using Blog.Application.Contracts.Blog;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.HttpApi
{
    [ApiController]
    [Route("Controller")]
    public class BlogController
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        [HttpPost]
        public async Task<bool> InsertBlogAsync([FromBody]PostDto dto)
        {
            return await this.blogService.InsertBlogAsync(dto);
        }

        [HttpGet]
        public async Task<PostDto> GetBlogAsync(int id)
        {
            return await this.blogService.GetBlogAsync(id);
        }
        [HttpPut]
        public async Task<bool> UpdateBlogAsync(int id,PostDto dto)
        {
            return await this.blogService.UpdateBlogAsync(id, dto);
        }
        [HttpDelete]
        public async Task<bool> DeleteBlogAsync(int id)
        {
            return await this.blogService.DeleteBlogAsync(id);
        }
    }
}
