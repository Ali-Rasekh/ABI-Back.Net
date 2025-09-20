using AFP_Backend.Contexts;
using AFP_Backend.Modules.BiFilters.Contracts.IRepository;
using AFP_Backend.Modules.BiFilters.Models;
using AFP_Backend.Modules.Public.Controllers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AFP_Backend.Modules.BiFilters.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("[controller]")]
    public class FiltersController : MyBaseController
    {
        private readonly IMapper _Mapper;
        private readonly IBiFilterRepository _filterRepository;

        public FiltersController(IMapper mapper, IBiFilterRepository filterRepository)
        {
            _Mapper = mapper;
            _filterRepository = filterRepository;
        }

        [HttpGet("getfilters")]

        public async Task<ActionResult<IEnumerable<BiFilter>>> GetFilters()
        {
            var filters = await _filterRepository.GetAll();
            if (filters == null)
            {
                return NotFound();
            }
            //var result = _Mapper.Map<IEnumerable<BiFilterDto>>(filters);
            string json = JsonConvert.SerializeObject(filters);
            return Ok(json);
        }
        [HttpGet]
        public async Task<IActionResult> GetFilter(int id)
        {
            var filter = await _filterRepository.Get(id);
            if (filter == null)
            {
                return NotFound();
            }
            return Ok(JsonConvert.SerializeObject(filter));
        }
    }
}
