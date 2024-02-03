using CoreProjectApi.DAL.ApiContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            var c = new Context();
            return Ok(c.Categories2.ToList()); //apilerde sonucun başarılı olduğunu gösterir
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using var c = new Context();
            var value = c.Categories2.Find(id);
            if(value == null)
            {
                return NotFound(); //hiçbir şey bulunamadı döndür
            }
            else
            {
                return Ok(value);
            }
        }
    }
}
