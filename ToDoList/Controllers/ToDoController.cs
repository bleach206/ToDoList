using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System.Collections.Generic;

using Model;
using Repository;
using Service.Interface;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;

namespace ToDoList.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        #region Fields

        private readonly IToDoService _service;
        private readonly ILogger _logger;
        #endregion

        #region Constructor

        public ToDoController(IToDoService service, ILogger<ToDoController> logger) => (_service, _logger) = (service, logger);
        #endregion


        // GET: api/ToDo
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ToDo/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201, Type = typeof(CreateDTO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(409)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Create([FromBody] CreateDTO value)
        {
            try
            {
                if (value == null)
                {
                    return BadRequest();
                }

                var Id = await _service.CreateToDo(value);
                return CreatedAtRoute("Get", new { id = Id }, value);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error Creating ToDo");
                return StatusCode(StatusCodes.Status500InternalServerError);
            }            
        }

        // PUT: api/ToDo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
