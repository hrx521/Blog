using Blog.Application.Blog;
using Blog.Application.Contracts.Blog;
using Blog.Domain.Shared;
using Blog.ToolKits.Base;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blog.HttpApi
{
    [ApiController]
    [Route("Controller")]
    [ApiExplorerSettings(GroupName =Grouping.GroupName_v1)]
    public class BlogController
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService blogService)
        {
            this.blogService = blogService;
        }
        /// <summary>
        /// 新增博客
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ServiceTResult<string>> InsertBlogAsync([FromBody]PostDto dto)
        {
            return await this.blogService.InsertBlogAsync(dto);
        }
        /// <summary>
        /// 查询博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ServiceTResult<PostDto>> GetBlogAsync(int id)
        {
            return await this.blogService.GetBlogAsync(id);
        }
        /// <summary>
        /// 更新博客
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<ServiceTResult<string>> UpdateBlogAsync(int id,PostDto dto)
        {
            return await this.blogService.UpdateBlogAsync(id, dto);
        }
        /// <summary>
        /// 删除博客
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public async Task<ServiceResult> DeleteBlogAsync(int id)
        {
            return await this.blogService.DeleteBlogAsync(id);
        }
    }
}
