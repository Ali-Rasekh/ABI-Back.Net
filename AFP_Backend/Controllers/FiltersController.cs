using AFP_Backend.Controllers;
using AutoMapper;
using Context.MaroonContext;
using Contract.Dtos.MaroonModels;
using MaroonModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ABI_Back.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("[controller]")]
    public class FiltersController : MyBaseController
    {
        private readonly MaroonContext _MaroonDbContext;
        private readonly IMapper _Mapper;

        public FiltersController(MaroonContext maroonDbContext, IMapper mapper)
        {
            _MaroonDbContext = maroonDbContext;
            _Mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BiFilter>>> GetFilters()
        {
            var filters = new List<BiFilter>();
            using var transaction = await _MaroonDbContext.Database.BeginTransactionAsync();
            try
            {
                filters = await _MaroonDbContext.BiFilters.ToListAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
            }
           //var result = _Mapper.Map<IEnumerable<BiFilterDto>>(filters);
            string json = JsonConvert.SerializeObject(filters);

            return Ok(json);
        }
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetCity(int id, bool includePointOfIntrest = false)
        //{
        //    var city = await cityInfoRepository.GetCityAsync(id, includePointOfIntrest);
        //    if (city == null)
        //    {
        //        return NotFound();
        //    }
        //    if (includePointOfIntrest)
        //    {
        //        return Ok(mapper.Map<CityDto>(city));
        //    }
        //    return Ok(mapper.Map<CityWithoutPointOfIntrestDto>(city));
        //}
    }
}
