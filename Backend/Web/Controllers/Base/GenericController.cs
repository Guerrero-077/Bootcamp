
using Business.Interfases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Web.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, D> : ControllerBase
    {
        protected readonly IBaseBusiness<T, D> _business;

        public GenericController(IBaseBusiness<T, D> business)
        {
            _business = business;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _business.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var resul= await _business.GetById(id);
                return Ok(resul);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] D entity)
        {
            try
            {
                var result = await _business.Save(entity);
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] D entity)
        {
            try
            {
                var result = await _business.Update(entity); 
                return Ok(result);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _business.Delete(id);
                return Ok(result);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
