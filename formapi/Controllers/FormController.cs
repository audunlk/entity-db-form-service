using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using formapi.EFcore;
using formapi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FormController : ControllerBase
    {

        private readonly DbHelper _db;

        public FormController(DbHelper db)
        {
            _db = db;
        }


        // GET: api/<FormController>
        [HttpGet]
        public IActionResult GetFormDatas()
        {
            try
            {
                List<FormDataModel> formData = _db.GetFormDatas();

                if (formData == null)
                {
                    return NotFound();
                }

                return Ok(formData);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }


        // GET api/<FormController>/5
        [HttpGet("{id}")]
        public IActionResult GetFormData(int id)
        {
            try
            {
                FormDataModel formData = _db.GetFormData(id);

                if (formData == null)
                {
                    return NotFound();
                }

                return Ok(formData);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }



        // POST api/<FormController>
        [HttpPost]
        public IActionResult Post([FromBody] FormDataModel formData)
        {
            try
            {
                if (formData == null)
                {
                    return BadRequest();
                }

                var createdFormData = _db.CreateFormData(formData);

                return Created("formData", createdFormData);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

    }

}
