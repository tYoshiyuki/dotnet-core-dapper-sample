using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DotnetCoreDapperSample.Api.Models;
using DotnetCoreDapperSample.Api.Repositories;

namespace DotnetCoreDapperSample.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogRepository _blogRepository;

        public BlogController(BlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return _blogRepository.GetList();
        }
    }
}
