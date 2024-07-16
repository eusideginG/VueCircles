using Microsoft.AspNetCore.Mvc;
using VueApp.Server.Data;
using VueApp.Server.Models.DTOs;
using VueApp.Server.Models.Entitys;

namespace VueApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CirclesController : ControllerBase
    {
        private ApplicationDbContext dBcontext;

        public CirclesController(ApplicationDbContext applicationDbContext) 
        {
            this.dBcontext = applicationDbContext;
        }

        // GET api/<CirclesController>/91ca1a58-f55d-4fd7-86e8-c6e4d90c7f5c
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var circles = (from crcl in this.dBcontext.Circles
                          join d in dBcontext.Data
                          on crcl.DataId equals d.Id
                          where d.Id == id
                          select crcl).ToList();

            if (circles.Count == 0)
            {
                return Ok("No circles found");
            }
            else
            {
                return Ok(circles);
            }
        }

        // POST api/<CirclesController>
        [HttpPost]
        public IActionResult Post([FromBody] CircleDTO values)
        {
            if (values.DataId.GetType() != typeof(Guid))
            {
                return BadRequest("the url parameter is not a Guid");
            }

            // check if data exists
            var data = (from d in dBcontext.Data where d.Id == values.DataId select d).FirstOrDefault();

            // insert data if not exist
            if (values.DataId != data?.Id)
            {
                dBcontext.Data.Add(new() { Id = values.DataId });
                dBcontext.SaveChanges();
            }



            var circles = (from crcl in this.dBcontext.Circles
                           join d in dBcontext.Data
                           on crcl.DataId equals d.Id
                           where d.Id == data.Id
                           select crcl).ToList();

            if (circles.Where(c => c.XAxis == values.XAxis && c.YAxis == values.YAxis).Count() > 0)
            {
                return Ok("Circles cannot have the same x and y axis");
            }

            // add new circle
            CirclesEntity circle  = new() 
            {
                Id = new Guid(),
                Time = values.Time,
                XAxis = values.XAxis,
                YAxis = values.YAxis,
                Color = values.Color,
                Diameter = values.Diameter,
                DataId = values.DataId,
            };

            dBcontext.Circles.Add(circle);
            dBcontext.SaveChanges();

            return Ok(circle);
        }

    }
}
