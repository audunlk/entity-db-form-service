using formapi.EFcore;
using formapi.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace formapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterDatabasesController : ControllerBase
    {

        private readonly DbHelper _db;

        public MasterDatabasesController(DbHelper db)
        {
            _db = db;
        }

        // GET: api/<MasterDatabasesController>
        [HttpGet]
      
        public IActionResult GetMasterDatabases()
        {
            try
            {
                List<MasterDatabaseModel> masterDatabases = _db.GetMasterDatabases();
                if (masterDatabases == null)
                {
                    return NotFound();
                }

                return Ok(masterDatabases);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // GET api/<MasterDatabasesController>/5
        [HttpGet("{id}")]
        
        public IActionResult GetMasterDatabase(int id)
        {
            try
            {
                MasterDatabaseModel masterDatabase = _db.GetMasterDatabase(id);
                if (masterDatabase == null)
                {
                    return NotFound();
                }

                return Ok(masterDatabase);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // POST api/<MasterDatabasesController>
        [HttpPost]
        
        public IActionResult CreateMasterDatabase([FromBody] MasterDatabaseModel masterDatabase)
        {
            try
            {
                MasterDatabaseModel createdMasterDatabase = _db.CreateMasterDatabase(masterDatabase);
                if (createdMasterDatabase == null)
                {
                    return BadRequest();
                }

                return Ok(createdMasterDatabase);
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }

        // PUT api/<MasterDatabasesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MasterDatabasesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
