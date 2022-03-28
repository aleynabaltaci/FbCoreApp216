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
            var cat = await _catService.Where(x=>x.IsDeleted!=true);
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(cat));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cat = await _catService.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryDto>(cat));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto catdto)
        {
            var newCat = await _catService.AddAsync(_mapper.Map<Category>(catdto));
            return Created(string.Empty, _mapper.Map<CategoryDto>(newCat));
        }
        [HttpPut]
        public IActionResult Update(CategoryDto catDto)
        {
            //catDTo içinden Id ve NAme Alanı geliyor
            //catDto işe GetByIdAsync kullanrak dbdeki kayıtlı olan bilgiye ulaştım Bunu catBul nesnesşne yükledim.
            //Güncellemek istediğim alan Name alanı olduğundan
            //catBuldaki name alanının 
            Task<Category> catBul=_catService.GetByIdAsync(catDto.ID);
            catBul.Result.CategoryName = catDto.CategoryName;

            var cat = _catService.Update(catBul.Result);
            //
            //return NoContent();
            //sonuc göstermek istersek
            return Ok(_mapper.Map<CategoryDto>(cat));
        }
        //[HttpDelete("{id:int}")]
        //public IActionResult Remove(int id)
        //{
        //    var cat=_catService.GetByIdAsync(id).Result;//result dersek asenkron metod asenkron olmayan yerde çalışır hata vermez.
        //    _catService.Remove(cat);
        //    return NoContent();
        //}

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id) // direk silmek yerine IsDeleted'ı true döndürmemiz lazım
        {
            var cat=_catService.GetByIdAsync(id).Result;//result dersek asenkron metod asenkron olmayan yerde çalışır hata vermez.
            cat.IsDeleted = true;
            _catService.Update(cat);
            return NoContent();
        }
        [HttpGet("{id:int}/product")]
        public async Task<IActionResult> GetWithProductById(int id)
        {
            var cat=await _catService.GetWithByIdAsync(id);
            return Ok(_mapper.Map<CategoryWtihProductDto>(cat));
        }


    }
}
