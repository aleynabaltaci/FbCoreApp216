using AutoMapper;
using FbCoreApp216.Api.DTOs;
using FbCoreApp216.Core.Models;
using FbCoreApp216.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FbCoreApp216.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _proService;
        private IMapper _mapper;

        public ProductController(IProductService proService, IMapper mapper)
        {
            _proService = proService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pro = await _proService.Where(x => x.IsDeleted != true);
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(pro));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var pro= await _proService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(pro));
        }
        [HttpPost]
        public async Task<IActionResult> Save(ProductDto proDto)
        {
            var pro =await _proService.AddAsync(_mapper.Map<Product>(proDto));
            return Created(string.Empty,_mapper.Map<ProductDto>(pro));
        }
        [HttpPut]
        public IActionResult Update(ProductDto proDto)
        {
            var pro =_proService.Update(_mapper.Map<Product>(proDto));
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _proService.GetByIdAsync(id).Result;
            pro.IsDeleted = true;
            _proService.Update(pro);
            return NoContent();
        }
    }
}
