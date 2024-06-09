using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NzWalks.API.Data;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;
        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Get All Region
        [HttpGet]
        public IActionResult GetAll()
        {
           var regions = dbContext.Regions.ToList();

            return Ok(regions);
        }

        //Get Single Region
        //[HttpGet]
        //[Route("{id:Guid}")]
        //public IActionResult GetById([FromRoute] Guid id)
        //{

        //}

    }
}
