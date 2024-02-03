using CoreProjectApi.DAL.ApiContext;
using CoreProjectApi.DAL.ApiContext.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
        public IActionResult CategoryGet(int id)
        {
            using var c = new Context();
            var value = c.Categories2.Find(id);
            if (value == null)
            {
                return NotFound(); //hiçbir şey bulunamadı döndür
            }
            else
            {
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category2 p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);// geriye oluşturuldu metodu döndür
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories2.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(value);
                c.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult UpdateCategory(Category2 p)
        {
            using var c = new Context();
            var value = c.Find<Category2>(p.Category2ID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.Category2Name = p.Category2Name;
                c.Update(value);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
