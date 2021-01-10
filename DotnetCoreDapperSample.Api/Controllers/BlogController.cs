using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using DotnetCoreDapperSample.Api.Exceptions;
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

        [HttpGet("{id}")]
        public Blog Get(int id)
        {
            return _blogRepository.Get(id);
        }

        [HttpPost]
        public Blog Post(Blog blog)
        {
            if (_blogRepository.Get(blog.Id) != null)
            {
                throw new AppException("対象のデータは既に登録されています。");
            }

            using IDbTransaction tran = _blogRepository.BeginTransaction();
            _blogRepository.Create(blog);
            tran.Commit();
            return _blogRepository.Get(blog.Id);
        }
    }
}
