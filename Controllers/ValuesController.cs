using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab1_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly IDataManager _dataManager;

        public ValuesController(IDataManager dataManager)
        {
            _dataManager = dataManager;
        }

        //GET: api/values
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    return Ok(_dataManager.GenerateNumbers());
        //}

        //GET: api/values?start=1&end=5
        [HttpGet]
        public IActionResult Get([FromQuery] int start, [FromQuery] int end)
        {

            if (start >= 0 && end >= 1 && start < end)
            {
                return Ok(_dataManager.GenerateNumbers(start, end));
            } else
            {
                return Ok(_dataManager.GenerateNumbers());
            }

        }

        // GET: api/value/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            if (_dataManager.GenerateNumbersId(id) > 0)
            {
                return Ok(id + " is " + _dataManager.GenerateNumbersId(id));
            } else
            {
                return BadRequest(id + " is not exists");
            }
        }

        // POST: api/value
        [HttpPost]
        public IActionResult Post([FromBody] int value)
        {
            if (_dataManager.GenerateNumbersPost(value))
            {
                return StatusCode(201, value + " is add");
            } else
            {
                return BadRequest();
            }
        }

        // PUT: api/value/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] int value)
        {
            if (_dataManager.GenerateNumbersPut(id, value))
            {
                return StatusCode(201, id + " is changed");
            } else
            {
                return StatusCode(422);
            }
        }

        // DELETE: api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_dataManager.GenerateNumberDelete(id))
            {
                return StatusCode(204, id + " is deleted");
            } else
            {
                return StatusCode(422);
            }
        }
    }
}
