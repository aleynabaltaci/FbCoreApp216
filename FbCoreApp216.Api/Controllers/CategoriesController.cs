using AutoMapper;
using FbCoreApp216.Api.DTOs;
using FbCoreApp216.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FbCoreApp216.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryService _catService;
        private IMapper _mapper;

        public CategoriesController(ICategoryService catService, IMapper mapper)
        {
            _catService = catService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cat=await _catService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(cat));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cat=await _catService.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryDto>(cat));
        }

    }
}
